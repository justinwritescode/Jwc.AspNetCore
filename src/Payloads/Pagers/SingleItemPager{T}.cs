/*
 * SingleItemPager{T}.cs
 *
 *   Created: 2022-11-29-08:46:23
 *   Modified: 2022-11-29-08:46:23
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads;

using System.Diagnostics;
using System.Net;
using JustinWritesCode.Payloads.Abstractions;
using Microsoft.OpenApi.Models;

/// <inheritdoc cref="ISingleItemPager{T}"/>
[DebuggerDisplay(
    $"{{{nameof(StringValue)}}}, {nameof(Page)}: {{{nameof(Page)}}} of {{{nameof(TotalRecords)}}}"
)]
public class SingleItemPager<T> : Pager<T>, ISingleItemPager<T>, IPager
{
    public SingleItemPager() : this(default, 0, 0) { }

    public SingleItemPager(T value, int pageNumber, int totalRecords)
        : base(new[] { value }, pageNumber, 1, totalRecords)
    {
        Page = pageNumber;
        TotalRecords = totalRecords;
        Message = string.Empty;
        StringValue = value.ToString();
    }

    [JProp("item")]
    public virtual T? Item
    {
        get => (Items ?? new T?[] { default }).FirstOrDefault();
        set => Items = new[] { value }!;
    }

    [JIgnore]
    public override T[]? Items
    {
        get => base.Items;
        set => base.Items = value;
    }

    [JIgnore]
    public override T[]? Value
    {
        get => base.Value;
        set => base.Value = value;
    }

    [JIgnore]
    T? IPayload<T>.Value
    {
        get => Item;
        set => Item = value;
    }
    object[]? IPager.Items
    {
        get => (Items ?? new[] { default(T) }).OfType<object>().ToArray();
        set => Items = (value ?? new[] { default(object) }).OfType<T>().ToArray();
    }

    public static new OpenApiSchema GetOpenApiSchema()
    {
        var schema = Pager<T>.GetOpenApiSchema();
        schema.Properties.Remove("items");
        // schema.Properties.Add("page", new OpenApiSchema { Type = "integer", Format = "int32" });
        // schema.Properties.Add("pageSize", new OpenApiSchema { Type = "integer", Format = "int32" });
        // schema.Properties.Add("totalRecords", new OpenApiSchema { Type = "integer", Format = "int32" });
        schema.Properties.Add(
            "item",
            new OpenApiSchema
            {
                Reference = new OpenApiReference
                {
                    Id = typeof(T).Name,
                    Type = ReferenceType.Schema
                }
            }
        );
        return schema;
    }

    public static new SingleItemPager<T> NotFound() =>
        new() { StatusCode = (int)HttpStatusCode.NotFound };

    public static new SingleItemPager<T> BadRequest() =>
        new() { StatusCode = (int)HttpStatusCode.BadRequest };

    public static new SingleItemPager<T> NoContent() =>
        new() { StatusCode = (int)HttpStatusCode.NoContent };
}
