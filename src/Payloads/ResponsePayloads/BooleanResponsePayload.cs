//
// BooleanResponsePayload.cs
//
//   Created: 2022-10-31-08:33:05
//   Modified: 2022-10-31-08:33:50
//
//   Author: Justin Chase <justin@justinwritescode.com>
//
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//


namespace JustinWritesCode.Payloads;

using System.Xml.Serialization;
using JustinWritesCode.Payloads.Abstractions;
using static Microsoft.AspNetCore.Http.StatusCodes;

/// <summary>Represents a response payload with a <see langword="bool" /> value</summary>
public class BooleanResponsePayload : ResponsePayload<bool>
{
    public BooleanResponsePayload(bool value, string? message = default!) : base(value, message) { }

    /// <inheritdoc />
    [
        JProp("stringValue"),
        JIgnore(Condition = JIgnoreCond.WhenWritingNull),
        XmlAttribute("stringValue")
    ]
    public override string? StringValue
    {
        get => Value.ToString();
        set => Value = bool.Parse(value);
    }
}
