//
// Payload.cs
//
//   Created: 2022-10-31-08:33:05
//   Modified: 2022-10-31-08:35:51
//
//   Author: Justin Chase <justin@justinwritescode.com>
//
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace JustinWritesCode.Payloads;

using System.Diagnostics;
using JustinWritesCode.Payloads.Abstractions;

[DebuggerDisplay($"{{{nameof(StringValue)}}}")]
public class Payload<T> : IPayload<T>
{
    public Payload() : this(default, default) { }

    public Payload(T value, string? stringValue = default)
    {
        Value = value;
        StringValue = stringValue;
    }

    [JProp("value")]
    public virtual T? Value { get; set; }
    [JProp("stringValue")]
    public virtual string? StringValue
    {
        get => _stringValue ?? ToString();
        set => _stringValue = value;
    }
    object? IPayload.Value { get => Value; set => Value = value is T t ? t : default; }
    private string? _stringValue;

    public override string ToString() => _stringValue ?? Value?.ToString()!;
}
