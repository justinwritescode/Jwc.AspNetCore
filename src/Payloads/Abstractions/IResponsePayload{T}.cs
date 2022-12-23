/*
 * IResponsePayload copy.cs
 *
 *   Created: 2022-11-26-04:29:28
 *   Modified: 2022-11-26-04:29:28
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads.Abstractions;
using System.Net;

/// <summary>Represents <inheritdoc cref="IResponsePayload{T}" path="/value/node()" />.</summary>
/// <value>a strongly-typed response payload of type <typeparamref name="T" /></value>
public interface IResponsePayload<T> : IPayload<T>, IResponsePayload
{
    public static new virtual IResponsePayload<T> NotFound() => new ResponsePayload<T> { StatusCode = (int)HttpStatusCode.NotFound };
    public static new virtual IResponsePayload<T> BadRequest() => new ResponsePayload<T> { StatusCode = (int)HttpStatusCode.BadRequest };
    public static new virtual IResponsePayload<T> NoContent() => new ResponsePayload<T> { StatusCode = (int)HttpStatusCode.NoContent };
}
