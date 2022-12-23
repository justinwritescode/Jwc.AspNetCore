/*
 * Http403ForbiddenException copy.cs
 *
 *   Created: 2022-12-05-08:07:22
 *   Modified: 2022-12-05-08:07:22
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

/*
 * Http403ForbiddenException.cs
 *
 *   Created: 2022-12-05-11:48:11
 *   Modified: 2022-12-05-11:49:05
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.AspNetCore;
using System;

public class Http400BadRequestException : HttpRequestException
{
    public const string DefaultMessage = "Your input was not in the correct format.";

    public Http400BadRequestException() : this(DefaultMessage) { }
    public Http400BadRequestException(string message = DefaultMessage) : base(message, null, BadRequest) { }
    public Http400BadRequestException(string message = DefaultMessage, Exception? inner = default) : base(message, inner, BadRequest) { }
}
