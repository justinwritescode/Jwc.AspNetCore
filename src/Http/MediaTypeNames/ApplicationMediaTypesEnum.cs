/*
 * MediaTypeNames.cs
 *
 *   Created: 2022-11-29-01:56:37
 *   Modified: 2022-11-29-04:39:51
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Net.Mime.MediaTypes;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

[GenerateEnumerationRecordStruct("ApplicationMediaType", "System.Net.Mime.MediaTypes")]
public enum ApplicationMediaTypesEnum
{
    [Display(Name = ApplicationMediaTypeNames.Any, Description = nameof(Any))]
    [EnumMember(Value = ApplicationMediaTypeNames.Any)]
    Any,

    [Display(Name = ApplicationMediaTypeNames.Base, Description = nameof(Base))]
    [EnumMember(Value = ApplicationMediaTypeNames.Base)]
    Base,

    [Display(Name = ApplicationMediaTypeNames.Octet, Description = nameof(Octet))]
    [EnumMember(Value = ApplicationMediaTypeNames.Octet)]
    Octet,

    [Display(Name = ApplicationMediaTypeNames.Pdf, Description = nameof(Pdf))]
    [EnumMember(Value = ApplicationMediaTypeNames.Pdf)]
    Pdf,

    [Display(Name = ApplicationMediaTypeNames.Rtf, Description = nameof(Rtf))]
    [EnumMember(Value = ApplicationMediaTypeNames.Rtf)]
    Rtf,

    [Display(Name = ApplicationMediaTypeNames.Soap, Description = nameof(Soap))]
    [EnumMember(Value = ApplicationMediaTypeNames.Soap)]
    Soap,

    [Display(Name = ApplicationMediaTypeNames.Xml, Description = nameof(Xml))]
    [EnumMember(Value = ApplicationMediaTypeNames.Xml)]
    Xml,

    [Display(Name = ApplicationMediaTypeNames.Zip, Description = nameof(Zip))]
    [EnumMember(Value = ApplicationMediaTypeNames.Zip)]
    Zip,

    [Display(Name = ApplicationMediaTypeNames.Json, Description = nameof(Json))]
    [EnumMember(Value = ApplicationMediaTypeNames.Json)]
    Json,

    [Display(Name = ApplicationMediaTypeNames.FormUrlEncoded, Description = nameof(FormUrlEncoded))]
    [EnumMember(Value = ApplicationMediaTypeNames.FormUrlEncoded)]
    FormUrlEncoded,

    [Display(Name = ApplicationMediaTypeNames.Bson, Description = nameof(Bson))]
    [EnumMember(Value = ApplicationMediaTypeNames.Bson)]
    Bson,

    [Display(Name = ApplicationMediaTypeNames.MessagePack, Description = nameof(MessagePack))]
    [EnumMember(Value = ApplicationMediaTypeNames.MessagePack)]
    MessagePack
}
