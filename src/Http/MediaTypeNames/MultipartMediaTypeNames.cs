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
    [Display(Name = MultipartMediaTypeNames.Any, Description = nameof(Any))]
    [EnumMember(Value = MultipartMediaTypeNames.Any)]
    Any,

    [Display(Name = MultipartMediaTypeNames.Alternative, Description = nameof(Alternative))]
    [EnumMember(Value = MultipartMediaTypeNames.Alternative)]
    Alternative,

    [Display(Name = MultipartMediaTypeNames.Appledouble, Description = nameof(Appledouble))]
    [EnumMember(Value = MultipartMediaTypeNames.Appledouble)]
    Appledouble,

    [Display(Name = MultipartMediaTypeNames.Digest, Description = nameof(Digest))]
    [EnumMember(Value = MultipartMediaTypeNames.Digest)]
    Digest,

    [Display(Name = MultipartMediaTypeNames.Encrypted, Description = nameof(Encrypted))]
    [EnumMember(Value = MultipartMediaTypeNames.Encrypted)]
    Encrypted,

    [Display(Name = MultipartMediaTypeNames.FormData, Description = nameof(FormData))]
    [EnumMember(Value = MultipartMediaTypeNames.FormData)]
    FormData,

    [Display(Name = MultipartMediaTypeNames.HeaderSet, Description = nameof(HeaderSet))]
    [EnumMember(Value = MultipartMediaTypeNames.HeaderSet)]
    HeaderSet,

    [Display(Name = MultipartMediaTypeNames.Mixed, Description = nameof(Mixed))]
    [EnumMember(Value = MultipartMediaTypeNames.Mixed)]
    Mixed,

    [Display(Name = MultipartMediaTypeNames.Parallel, Description = nameof(Parallel))]
    [EnumMember(Value = MultipartMediaTypeNames.Parallel)]
    Parallel,

    [Display(Name = MultipartMediaTypeNames.Related, Description = nameof(Related))]
    [EnumMember(Value = MultipartMediaTypeNames.Related)]
    Related,

    [Display(Name = MultipartMediaTypeNames.Report, Description = nameof(Report))]
    [EnumMember(Value = MultipartMediaTypeNames.Report)]
    Report,

    [Display(Name = MultipartMediaTypeNames.Signed, Description = nameof(Signed))]
    [EnumMember(Value = MultipartMediaTypeNames.Signed)]
    Signed,

    [Display(Name = MultipartMediaTypeNames.VoiceMessage, Description = nameof(VoiceMessage))]
    [EnumMember(Value = MultipartMediaTypeNames.VoiceMessage)]
    VoiceMessage,

    [Display(Name = MultipartMediaTypeNames.XMixedReplace, Description = nameof(XMixedReplace))]
    [EnumMember(Value = MultipartMediaTypeNames.XMixedReplace)]
    XMixedReplace
}

public static class MultipartMediaTypeNames
{
    public const string Base = "multipart/";
    public const string Any = Base + "*";
    public const string Alternative = Base + "alternative";
    public const string Appledouble = Base + "appledouble";
    public const string Digest = Base + "digest";
    public const string Encrypted = Base + "encrypted";
    public const string FormData = Base + "form-data";
    public const string HeaderSet = Base + "header-set";
    public const string Mixed = Base + "mixed";
    public const string Parallel = Base + "parallel";
    public const string Related = Base + "related";
    public const string Report = Base + "report";
    public const string Signed = Base + "signed";
    public const string VoiceMessage = Base + "voice-message";
    public const string XMixedReplace = Base + "x-mixed-replace";
}
