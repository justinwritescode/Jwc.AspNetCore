//
// NumericPayload.cs
//
//   Created: 2022-10-31-08:33:05
//   Modified: 2022-10-31-08:42:45
//
//   Author: Justin Chase <justin@justinwritescode.com>
//
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace JustinWritesCode.Payloads;

using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(StringValue)}}}")]
public class NumericPayload : Payload<decimal>
{
    public NumericPayload() : this(default) { }

    public NumericPayload(decimal value, string? stringValue = default) : base(value, stringValue)
    {
    }

    [JProp("stringValue")]
    public override string? StringValue { get => Value.ToString(); set => Value = decimal.Parse(value); }
}
