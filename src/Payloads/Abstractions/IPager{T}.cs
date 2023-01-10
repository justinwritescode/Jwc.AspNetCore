/*
 * IPager{T}.cs
 *
 *   Created: 2022-11-29-08:40:53
 *   Modified: 2022-11-29-08:41:06
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads.Abstractions;

/// <summary>Represents a srrongly-typed response payload with a page of items of type <typeparamref name="T"/></summary>
public interface IPager<T> : IResponsePayload<T[]>, IPager
{
    /// <summary>The array of items in the current page</summary>
    /// <remarks>Defaults to <see langword="null"/></remarks>
    /// <example>[1, 2, 3]</example>
    /// <default>null</default>
    [JProp("items")]
    new T[]? Items { get; set; }
    // int TotalRecords { get; set; }
    // int PageSize { get; set; }

    // int Page { get; set; }
    // int PageStartIndex { get; }
    // int PageEndIndex { get; }
    // int TotalPages { get; }
    // bool IsLastPage { get; }
    // bool HasPreviousPage { get; }
    // bool HasNextPage { get; }
}
