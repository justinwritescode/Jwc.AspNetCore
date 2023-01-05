/*
 * Pager.cs
 *
 *   Created: 2022-11-20-07:14:18
 *   Modified: 2022-11-29-08:42:37
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Collections;
using System.Net;

namespace JustinWritesCode.Payloads;

/// <inheritdoc cref="IPager"/>
/// <remarks>Items are of type <see langword="object" />.</remarks>
[DebuggerDisplay(
    $"{{{nameof(StringValue)}}}, {nameof(Page)}: {{{nameof(Page)}}} of {{{nameof(TotalRecords)}}}"
)]
public class Pager : Pager<object>
{
    public Pager() : this(default, 0, 0, 0) { }

    public Pager(IEnumerable? items, int page, int pageSize, int totalRecords)
        : base((items ?? Empty<object>()).Cast<object>().ToArray(), page, pageSize, totalRecords)
    { }

    public static new Pager NotFound() => new() { StatusCode = (int)HttpStatusCode.NotFound };

    public static new Pager BadRequest() => new() { StatusCode = (int)HttpStatusCode.BadRequest };

    public static new Pager NoContent() => new() { StatusCode = (int)HttpStatusCode.NoContent };
}
