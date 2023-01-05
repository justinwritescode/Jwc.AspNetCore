/*
 * StringPayload.cs
 *
 *   Created: 2022-11-20-07:14:18
 *   Modified: 2022-11-26-04:38:42
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


namespace JustinWritesCode.Payloads;

public class StringPayload : Payload<string>
{
    public StringPayload() : this(default) { }

    public StringPayload(string? value) => Value = value ?? string.Empty;

    [JProp("value")]
    public override string? Value { get; set; }

    [JIgnore]
    public override string? StringValue
    {
        get => Value;
        set => Value = value;
    }
}
