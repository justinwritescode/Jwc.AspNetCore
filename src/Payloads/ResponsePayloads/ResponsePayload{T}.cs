/*
 * ResponsePayload.cs
 *
 *   Created: 2022-11-20-07:14:18
 *   Modified: 2022-11-29-05:25:05
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Serialization;

using JustinWritesCode.Payloads.Abstractions;
using JustinWritesCode.Payloads.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

[DebuggerDisplay($"{{{nameof(StringValue)}}}")]
// [SwaggerSubType(typeof(ResponsePayload))]
public class ResponsePayload<T> : Payload<T>, IResponsePayload<T>, IPayload
{
    public ResponsePayload() : this(default, default) { }

    public ResponsePayload(T? value, string? stringValue = default, string? message = default, HttpStatusCode statusCode = HttpStatusCode.OK) : base(value, stringValue)
    {
        Message = message ?? string.Empty;
        StatusCode = (int)statusCode;
    }

    [JProp("isSuccess"), XmlAttribute("isSuccess")]
    public virtual bool IsSuccess => StatusCode!.Value.IsBetween(200, 299);
    [XmlAttribute("message"), JProp("message"), JIgnore(Condition = JIgnoreCond.WhenWritingNull)]
    public virtual string Message { get; set; }
    [JIgnore, XmlIgnore]
    public virtual int? StatusCode { get; set; }
    [JIgnore, XmlIgnore]
    T? IPayload<T>.Value { get; set; }
    [JIgnore, XmlIgnore]
    object? IPayload.Value { get => Value; set => Value = value is T t ? t : default; }

    [JIgnore, XmlIgnore]
    public ICollection<IOutputFormatter> OutputFormatters { get; } = new List<IOutputFormatter>();

    [JIgnore, XmlIgnore]
    public MediaTypeCollection ContentTypes  { get; } = new MediaTypeCollection();

    [JIgnore, XmlIgnore]
    HttpStatusCode? IResponsePayload.StatusCode => StatusCode.HasValue ? (HttpStatusCode)StatusCode.Value : default;

    public static implicit operator ResponsePayload<T>(T value)
    {
        return new ResponsePayload<T>(value);
    }

    public static implicit operator T?(ResponsePayload<T> payload)
    {
        return payload.Value;
    }

    public virtual Task ExecuteResultAsync(ActionContext context)
    {
        var services = context.HttpContext.RequestServices;
        var executor = services.GetService<IActionResultExecutor<IResponsePayload<T>>>() ?? new ResponsePayloadExecutor<T>(
            services.GetService<OutputFormatterSelector>(),
            services.GetRequiredService<ILogger<ResponsePayloadExecutor<T>>>(),
            services.GetService<IOptions<MvcOptions>>()
        );
        return executor.ExecuteAsync(context, this);
    }

    public void OnFormatting(OutputFormatterWriteContext context)
    {
        if (context.Object is IResponsePayload payload)
        {
            context.HttpContext.Response.StatusCode =
                Value is null ? (int)HttpStatusCode.NoContent :
                (int?)payload.StatusCode ?? (int)HttpStatusCode.OK;
        }
    }

    public static OpenApiSchema GetOpenApiSchema()
    {
        var schema = new OpenApiSchema
        {
            Type = "object",
            Properties =
            {
                [nameof(IResponsePayload.Value).ToLower()] = new OpenApiSchema { Reference = new OpenApiReference { Id = typeof(T).Name, Type = ReferenceType.Schema } },
                [nameof(IResponsePayload.Message).ToLower()] = new OpenApiSchema { Type = "string" }/*,
                [nameof(IResponsePayload.StatusCode)] = new OpenApiSchema { Type = "integer", Format = "int32" },*/
            },
            Required = { nameof(IResponsePayload.Value).ToLower() }
        };
        return schema;
    }
    public static ResponsePayload<T> NotFound(string? messaage = "Not found") => new () { StatusCode = (int)HttpStatusCode.NotFound };
    public static ResponsePayload<T> BadRequest(string? messaage = "Bad request") => new () { StatusCode = (int)HttpStatusCode.BadRequest };
    public static ResponsePayload<T> NoContent(string? messaage = "No content") => new () { StatusCode = (int)HttpStatusCode.NoContent };
    public static ResponsePayload<T> Created(T value, string? messaage = "Created at {0}", uri? location = default)
        => new CreatedResponsePayload<T>(value, location) { Message = Format(messaage ?? string.Empty, location) };
}