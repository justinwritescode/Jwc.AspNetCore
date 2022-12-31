/*
 * ResponsePayload{T}.cs
 *
 *   Created: 2022-11-29-05:25:22
 *   Modified: 2022-11-29-05:25:35
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads;

using System.Net;
using JustinWritesCode.Payloads.Abstractions;

/// <inheritdoc cref="IResponsePayload"/>
public class ResponsePayload : ResponsePayload<object>, IResponsePayload
{
    public ResponsePayload()
        : this(default, true, default)
    { }

    public ResponsePayload(object? value, bool isSuccess = true, string? message = default)
    {
        Value = value;
        Message = message ?? string.Empty;
        StringValue = value.ToString();
    }

    public static ResponsePayload NotFound() => new () { StatusCode = (int)HttpStatusCode.NotFound };
    public static ResponsePayload BadRequest() => new () { StatusCode = (int)HttpStatusCode.BadRequest };
    public static ResponsePayload NoContent() => new () { StatusCode = (int)HttpStatusCode.NoContent };
}
