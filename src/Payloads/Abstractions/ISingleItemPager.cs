/*
 * ISingleItemPager.cs
 *
 *   Created: 2022-11-26-05:18:42
 *   Modified: 2022-11-26-05:18:43
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


namespace JustinWritesCode.Payloads.Abstractions;

/// <summary>Represents a single-item pager (i.e., one item per page).</summary>
public interface ISingleItemPager : ISingleItemPager<object>, IPayload<object> { }
