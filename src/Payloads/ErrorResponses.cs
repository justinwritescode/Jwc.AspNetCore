/*
 * ErrorResponsePayload.cs
 *
 *   Created: 2022-11-26-04:57:24
 *   Modified: 2022-11-26-04:57:24
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.AspNetCore.Mvc;

namespace JustinWritesCode.Payloads;

public static class ErrorResponse
{
    public static ProblemDetails FromException(Exception ex) => new() { Detail = ex.Message };

    public static ProblemDetails ArgumentNullResponse(string argumentName) =>
        new() { Detail = $"Argument '{argumentName}' cannot be null." };
}
