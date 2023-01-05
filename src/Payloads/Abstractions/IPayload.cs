/*
 * IPayload.cs
 *
 *   Created: 2022-11-26-04:22:22
 *   Modified: 2022-11-26-04:22:23
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace JustinWritesCode.Payloads.Abstractions;

/// <summary>Represents an object or scalar valued payload</summary>
public interface IPayload
{
    /// <summary>The value of the payload</summary>
    /// <remarks>Defaults to <see langword="null"/></remarks>
    /// <default>null</default>
    /// <example>5</example>
    /// <example>0</example>
    /// <example>Hello, world!</example>
    object? Value { get; set; }

    /// <summary>The value of the payload as a string</summary>
    /// <remarks>Defaults to <see langword="null"/></remarks>
    /// <default>null</default>
    /// <example>"5"</example>
    /// <example>"0"</example>
    /// <example>"Hello, world!"</example>
    string? StringValue { get; set; }
}
