/*
 * HttpExceptionBase.cs
 *
 *   Created: 2022-12-05-11:53:05
 *   Modified: 2022-12-05-11:53:05
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.AspNetCore;

public abstract class HttpExceptionBase : Exception
{
    public const string DefaultMessage = "An error occurred while processing your request.";

    public HttpExceptionBase(int statusCode, string message = DefaultMessage) : base(message) { }

    public HttpExceptionBase(
        int statusCode,
        string message = DefaultMessage,
        Exception? inner = null
    ) : base(message, inner) { }

    public abstract ProblemDetails ToProblemDetails();

    public HttpExceptionBase()
    {
    }
}
