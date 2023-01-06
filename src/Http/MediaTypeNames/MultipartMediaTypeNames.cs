/*
 * MultipartMediaTypeNames.cs
 *
 *   Created: 2022-12-31-01:37:38
 *   Modified: 2022-12-31-01:37:38
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Net.Mime.MediaTypes;

using System.Runtime.Serialization;

[GenerateEnumerationRecordStruct("MultipartMediaType", "System.Net.Mime.MediaTypes")]
public enum MultipartMediaTypeEnum
{
    /// <inheritdoc cref="MultipartMediaTypeNames.Base"/>
    [Display(Name = MultipartMediaTypeNames.Base, Description = nameof(Base))]
    Base,

    /// <inheritdoc cref="MultipartMediaTypeNames.Any"/>
    [Display(Name = MultipartMediaTypeNames.Any, Description = nameof(Any))]
    [EnumMember(Value = MultipartMediaTypeNames.Any)]
    Any,

    /// <inheritdoc cref="MultipartMediaTypeNames.Alternative"/>
    [Display(Name = MultipartMediaTypeNames.Alternative, Description = nameof(Alternative))]
    [EnumMember(Value = MultipartMediaTypeNames.Alternative)]
    Alternative,

    /// <inheritdoc cref="MultipartMediaTypeNames.Appledouble"/>
    [Display(Name = MultipartMediaTypeNames.Appledouble, Description = nameof(Appledouble))]
    [EnumMember(Value = MultipartMediaTypeNames.Appledouble)]
    Appledouble,

    /// <inheritdoc cref="MultipartMediaTypeNames.Digest"/>
    [Display(Name = MultipartMediaTypeNames.Digest, Description = nameof(Digest))]
    [EnumMember(Value = MultipartMediaTypeNames.Digest)]
    Digest,

    /// <inheritdoc cref="MultipartMediaTypeNames.Encrypted"/>
    [Display(Name = MultipartMediaTypeNames.Encrypted, Description = nameof(Encrypted))]
    [EnumMember(Value = MultipartMediaTypeNames.Encrypted)]
    Encrypted,

    /// <inheritdoc cref="MultipartMediaTypeNames.FormData"/>
    [Display(Name = MultipartMediaTypeNames.FormData, Description = nameof(FormData))]
    [EnumMember(Value = MultipartMediaTypeNames.FormData)]
    FormData,

    /// <inheritdoc cref="MultipartMediaTypeNames.HeaderSet"/>
    [Display(Name = MultipartMediaTypeNames.HeaderSet, Description = nameof(HeaderSet))]
    [EnumMember(Value = MultipartMediaTypeNames.HeaderSet)]
    HeaderSet,

    /// <inheritdoc cref="MultipartMediaTypeNames.Mixed"/>
    [Display(Name = MultipartMediaTypeNames.Mixed, Description = nameof(Mixed))]
    [EnumMember(Value = MultipartMediaTypeNames.Mixed)]
    Mixed,

    /// <inheritdoc cref="MultipartMediaTypeNames.Parallel"/>
    [Display(Name = MultipartMediaTypeNames.Parallel, Description = nameof(Parallel))]
    [EnumMember(Value = MultipartMediaTypeNames.Parallel)]
    Parallel,

    /// <inheritdoc cref="MultipartMediaTypeNames.Related"/>
    [Display(Name = MultipartMediaTypeNames.Related, Description = nameof(Related))]
    [EnumMember(Value = MultipartMediaTypeNames.Related)]
    Related,

    /// <inheritdoc cref="MultipartMediaTypeNames.Report"/>
    [Display(Name = MultipartMediaTypeNames.Report, Description = nameof(Report))]
    [EnumMember(Value = MultipartMediaTypeNames.Report)]
    Report,

    /// <inheritdoc cref="MultipartMediaTypeNames.Signed"/>
    [Display(Name = MultipartMediaTypeNames.Signed, Description = nameof(Signed))]
    [EnumMember(Value = MultipartMediaTypeNames.Signed)]
    Signed,

    /// <inheritdoc cref="MultipartMediaTypeNames.VoiceMessage"/>
    [Display(Name = MultipartMediaTypeNames.VoiceMessage, Description = nameof(VoiceMessage))]
    [EnumMember(Value = MultipartMediaTypeNames.VoiceMessage)]
    VoiceMessage,

    /// <inheritdoc cref="MultipartMediaTypeNames.XMixedReplace"/>
    [Display(Name = MultipartMediaTypeNames.XMixedReplace, Description = nameof(XMixedReplace))]
    [EnumMember(Value = MultipartMediaTypeNames.XMixedReplace)]
    XMixedReplace
}

public static class MultipartMediaTypeNames
{
    /// <summary>The base media type for multipart media types.</summary>
    /// <value>multipart</value>
    public const string Base = "multipart";
    /// <summary>The media type for any multipart media type.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/*</value>
    public const string Any = Base + "*";
    /// <summary>The media type for <inheritdoc cref="Alternative" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/alternative</value>
    public const string Alternative = Base + "alternative";
    /// <summary>The media type for <inheritdoc cref="Appledouble" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/appledouble</value>
    public const string Appledouble = Base + "appledouble";
    /// <summary>The media type for <inheritdoc cref="Digest" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/digest</value>
    public const string Digest = Base + "digest";
    /// <summary>The media type for <inheritdoc cref="Encrypted" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/encrypted</value>
    public const string Encrypted = Base + "encrypted";
    /// <summary>The media type for <inheritdoc cref="FormData" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/form-data</value>
    public const string FormData = Base + "form-data";
    /// <summary>The media type for <inheritdoc cref="HeaderSet" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/header-set</value>
    public const string HeaderSet = Base + "header-set";
    /// <summary>The media type for <inheritdoc cref="Mixed" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/mixed</value>
    public const string Mixed = Base + "mixed";
    /// <summary>The media type for <inheritdoc cref="Parallel" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/parallel</value>
    public const string Parallel = Base + "parallel";
    /// <summary>The media type for <inheritdoc cref="Related" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/related</value>
    public const string Related = Base + "related";
    /// <summary>The media type for <inheritdoc cref="Report" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/report</value>
    public const string Report = Base + "report";
    /// <summary>The media type for <inheritdoc cref="Signed" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/signed</value>
    public const string Signed = Base + "signed";
    /// <summary>The media type for <inheritdoc cref="VoiceMessage" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/voice-message</value>
    public const string VoiceMessage = Base + "voice-message";
    /// <summary>The media type for <inheritdoc cref="XMixedReplace" path="/value" />.</summary>
    /// <value><inheritdoc cref="Base" path="/value" />/x-mixed-replace</value>
    public const string XMixedReplace = Base + "x-mixed-replace";
}

public partial record struct MultipartMediaType : IMediaType { }
