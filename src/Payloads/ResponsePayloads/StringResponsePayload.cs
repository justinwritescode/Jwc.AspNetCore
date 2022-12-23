//
// StringResponsePayload.cs
//
//   Created: 2022-10-31-08:33:05
//   Modified: 2022-10-31-08:46:26
//
//   Author: Justin Chase <justin@justinwritescode.com>
//
//   Copyright © 2022 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace JustinWritesCode.Payloads;

public class StringResponsePayload : ResponsePayload<string>
{
    public StringResponsePayload(string value, string? message = default!, string stringValue = default!) : base(value, message, stringValue)
    {
    }
}
