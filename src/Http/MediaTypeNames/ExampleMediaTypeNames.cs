/*
 * ExampleMediaTypeNames.cs
 *
 *   Created: 2023-01-06-07:26:23
 *   Modified: 2023-01-06-07:26:24
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Net.Mime.MediaTypes;

using System.Runtime.Serialization;

public static class ExampleMediaTypeNames
{
    /// <summary>The base name for all example media types.</summary>
    /// <remarks>See <see href="https://www.iana.org/assignments/media-types/media-types.xhtml#example">IANA Media Types</see> for more information.</remarks>
    /// <value>example</value>
    public const string Base = "example";

    /// <summary>Media type for any example.</summary>
    /// <value><inheritdoc cref="Base" />/*</value>
    public const string Any = Base + "/*";

    /// <summary>Example media type.</summary>
    /// <value><inheritdoc cref="Base" />/example</value>
    /// <seealso cref="ExampleMediaTypesEnum"/>
    /// <seealso cref="ExampleMediaTypesEnum.Example"/>
    public const string Example = Base + "/" + "example";
}

[GenerateEnumerationRecordStruct("ExampleMediaType")]
public enum ExampleMediaTypesEnum
{
    /// <inheritdoc cref="ExampleMediaTypeNames.Any"/>
    [Display(Name = ExampleMediaTypeNames.Any, Description = nameof(Any))]
    [EnumMember(Value = ExampleMediaTypeNames.Any)]
    Any,

    /// <inheritdoc cref="ExampleMediaTypeNames.Base"/>
    Base,

    /// <inheritdoc cref="ExampleMediaTypeNames.Example"/>
    Example
}

public partial record struct ExampleMediaType : IMediaType { }
