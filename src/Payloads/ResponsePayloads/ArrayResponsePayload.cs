/*
 * ArrayResponsePayload.cs
 *
 *   Created: 2022-11-28-09:44:00
 *   Modified: 2022-11-28-09:44:15
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Collections;

namespace JustinWritesCode.Payloads;

using System.Diagnostics;
using JustinWritesCode.Payloads.Abstractions;

/// <inheritdoc cref="IArrayResponsePayload"/>
[DebuggerDisplay($"{{{nameof(StringValue)}}}; Count = {{{nameof(Count)}}}")]
public class ArrayResponsePayload : ArrayResponsePayload<object>, IArrayResponsePayload
{
    public ArrayResponsePayload() : this(Empty<object>()) { }

    public ArrayResponsePayload(
        IEnumerable value,
        string? message = default,
        string? stringValue = default,
        string itemSeparator = ArrayPayload<object>.DefaultItemSeparator
    ) : base(value.OfType<object>().ToArray(), message, stringValue) { }
}
