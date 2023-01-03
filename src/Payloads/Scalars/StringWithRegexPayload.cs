/*
 * StringWithRegexPayload.cs
 *
 *   Created: 2022-11-26-04:38:20
 *   Modified: 2022-11-26-04:38:23
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads;

public class StringWithRegexPayload : Payload<string>
{
    public StringWithRegexPayload() : this(default, default) { }

    public StringWithRegexPayload(string? value, string? regex = default)
    {
        Value = value ?? string.Empty;
        Regex = regex ?? string.Empty;
    }

    [JProp("value")]
    public override string? Value { get; set; }

    [JProp("regex")]
    public virtual string Regex { get; set; }

    [JProp("stringValue")]
    public override string? StringValue
    {
        get => Value;
        set => Value = value;
    }
}
