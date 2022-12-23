/*
 * Http404NotFoundException.cs
 *
 *   Created: 2022-12-05-11:47:13
 *   Modified: 2022-12-05-11:47:14
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System;
namespace Microsoft.AspNetCore;

public class Http404NotFoundException : HttpRequestException
{
    public const string DefaultMessage = "The requested item could not be found.";

    public Http404NotFoundException() : this(DefaultMessage) { }
    public Http404NotFoundException(string message = DefaultMessage) : base(message, null, NotFound) { }
    public Http404NotFoundException(string message = DefaultMessage, Exception? inner = default) : base(message, inner, NotFound) { }
}
