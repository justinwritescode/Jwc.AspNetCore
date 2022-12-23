/*
 * IArrayPayload copy.cs
 *
 *   Created: 2022-11-26-04:40:58
 *   Modified: 2022-11-26-04:40:58
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads.Abstractions;

public interface IArrayPayload<T> : IPayload<T[]>
{
    /// <summary>The array of values</summary>
    /// <remarks>Defaults to <see langword="null"/></remarks>
    /// <default>null</default>
    /// <example>[1, 2, 3]</example>
    T[]? Values { get; set; }
    /// <summary>The number of values in the array</summary>
    /// <example>3</example>
    /// <default>0</default>
    int Count { get; }
}
