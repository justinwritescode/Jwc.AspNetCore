//
// UriResponsePayload.cs
//
//   Created: 2022-10-31-08:33:05
//   Modified: 2022-10-31-08:47:44
//
//   Author: Justin Chase <justin@justinwritescode.com>
//
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace JustinWritesCode.Payloads;
using System;
using System.Xml.Serialization;

/// <summary>Represents a response payload with a <see langword="uri" /> value</summary>.
public class UriResponsePayload : ResponsePayload<uri?>
{
    public UriResponsePayload(uri value, string? message = default!) : base(value, message) { }

    /// <inheritdoc />
    [
        JProp("stringValue"),
        JIgnore(Condition = JIgnoreCond.WhenWritingNull),
        XmlAttribute("stringValue")
    ]
    public override string? StringValue
    {
        get => Value.ToString();
        set => Value = value?.ToUri();
    }
}
