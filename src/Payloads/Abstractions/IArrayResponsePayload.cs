/*
 * IArrayResponsePayload{T} copy.cs
 *
 *   Created: 2022-11-28-09:35:32
 *   Modified: 2022-11-28-09:35:32
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads.Abstractions;

/// <summary>Represents a response payload with an array of values</summary>
/// <remarks>
///  <para>
///  <see cref="IArrayResponsePayload"/> is a <see cref="IArrayResponsePayload{Object}"/> with an array of <see langword="object" />s.
/// </para>
///  <para>
///  <see cref="ArrayResponsePayload"/> is a <see cref="ArrayResponsePayload{Object}"/> with an array of <see langword="object" />s.
/// </para>
/// </remarks>
public interface IArrayResponsePayload : IArrayResponsePayload<object>
{
}
