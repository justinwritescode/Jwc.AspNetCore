/*
 * ErrorResponsePayload.cs
 *
 *   Created: 2022-11-26-04:57:24
 *   Modified: 2022-11-26-04:57:24
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads;

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using JustinWritesCode.Payloads.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.HttpStatusCode;
// public class ErrorResponsePayload : ProblemDetails, IErrorResponsePayload
// {
//     public const string DefaultMessage = "An error has occurred.";

//     public ErrorResponsePayload(Exception? ex = default)
//         : this(ex.Message, ex)
//     { }

//     public ErrorResponsePayload()
//         : this(DefaultMessage)
//     {     }

//     public ErrorResponsePayload(string? message = DefaultMessage)
//         : this(message, default)
//     {     }

//     public ErrorResponsePayload(string? message = DefaultMessage, Exception? inner = default)
//         : this(message, inner, InternalServerError)
//     {     }

//     public ErrorResponsePayload(string? message = DefaultMessage, Exception? inner = default, HttpStatusCode statusCode = InternalServerError)
//         : base(message, inner)
//     {
//         StatusCode = (int)statusCode;
//         StringValue = message;
//     }
//     public virtual bool IsSuccess { get => false; set { } }
//     public virtual string? StringValue { get; set; }
//     public virtual int? StatusCode { get; set; }
//     public virtual object? Value { get; set; }

//     public ICollection<IOutputFormatter> OutputFormatters { get; } = new List<IOutputFormatter>();

//     public MediaTypeCollection ContentTypes { get; } = new MediaTypeCollection();

//     HttpStatusCode? IResponsePayload.StatusCode => StatusCode.HasValue ? (HttpStatusCode)StatusCode.Value : default;

//     public virtual Task ExecuteResultAsync(ActionContext context)
//     {
//         var result = new ObjectResult(this)
//         {
//             DeclaredType = typeof(ErrorResponsePayload)
//         };

//         var executor = context.HttpContext.RequestServices.GetRequiredService<IActionResultExecutor<ObjectResult>>();
//         return executor.ExecuteAsync(context, result);
//     }

//     public void OnFormatting(OutputFormatterWriteContext context)
//     {
//         context.HttpContext.Response.StatusCode = StatusCode ?? (int)InternalServerError;
//     }
// }
