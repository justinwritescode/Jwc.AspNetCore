/*
 * CreatedResponsePayload.cs
 *
 *   Created: 2022-12-19-07:18:15
 *   Modified: 2022-12-19-07:18:16
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Net;

namespace JustinWritesCode.Payloads;

/// <summary>Represents a payload of a newly-created resource</summary>
public class CreatedResponsePayload<T> : ResponsePayload<T>
{
    public uri? Location { get; }

    public CreatedResponsePayload(T data, uri? location = null)
        : base(data, message: location is not null ? $"Created at {location}." : null)
    {
        StatusCode = (int)HttpStatusCode.Created;
        Location = location;
    }
}

/// <summary>Represents a payload of a newly-created resource</summary>
public class CreatedResponsePayload : ResponsePayload
{
    public uri? Location { get; }

    public CreatedResponsePayload(object data, uri? location = null)
        : base(data, message: location is not null ? $"Created at {location}." : null)
    {
        StatusCode = (int)HttpStatusCode.Created;
        Location = location;
    }
}
