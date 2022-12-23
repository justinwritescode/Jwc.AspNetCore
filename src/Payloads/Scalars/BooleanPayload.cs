//
// BooleanPayload.cs
//
//   Created: 2022-10-31-08:33:05
//   Modified: 2022-10-31-08:33:46
//
//   Author: Justin Chase <justin@justinwritescode.com>
//
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace JustinWritesCode.Payloads;

public class BooleanPayload : Payload<bool>
{
    public BooleanPayload() : this(true) { }
    public BooleanPayload(bool value = true) => Value = value;

    /// <inheritdoc />
    public override string? StringValue { get => Value.ToString(); set => Value = bool.Parse(value); }
}
