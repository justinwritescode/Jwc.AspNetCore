/*
 * ISingleItemPager{T}.cs
 *
 *   Created: 2022-11-29-05:22:42
 *   Modified: 2022-11-29-05:23:38
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads.Abstractions;

/// <summary>Represents a strongly-typed single-item pager (i.e., one item per page) of items of type <typeparamref name="T"/>.</summary>
public interface ISingleItemPager<T> : IResponsePayload<T>
{
    [JProp("item")]
    T? Item { get; set; }

    [JProp("totalRecords")]
    int TotalRecords { get; set; }
    int PageSize { get; set; }
    int Page { get; set; }
    int PageStartIndex { get; }
    int PageEndIndex { get; }
    int TotalPages { get; }
    bool IsLastPage { get; }
    bool HasPreviousPage { get; }
    bool HasNextPage { get; }
}
