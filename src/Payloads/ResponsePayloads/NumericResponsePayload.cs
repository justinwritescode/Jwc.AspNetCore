//
// NumericResponsePayload.cs
//
//   Created: 2022-10-31-08:33:05
//   Modified: 2022-10-31-08:48:08
//
//   Author: Justin Chase <justin@justinwritescode.com>
//
//   Copyright © 2022-2023 Justin Chase, All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace JustinWritesCode.Payloads;

/// <summary>Represents a response payload with a <see langword="decimal" /> value</summary>
[DebuggerDisplay($"{{{nameof(StringValue)}}}")]
public class NumericResponsePayload : ResponsePayload<decimal>
{
    public NumericResponsePayload(
        decimal value,
        string? message = default!,
        string stringValue = default!
    )
    {
        Value = value;
        Message = message ?? string.Empty;
        StringValue = stringValue ?? value.ToString();
    }

    /// <inheritdoc />
    public override string? StringValue
    {
        get => Value.ToString();
        set => Value = decimal.Parse(value);
    }
}
