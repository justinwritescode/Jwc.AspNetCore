/*
 * HttpMethod.cs
 *
 *   Created: 2022-11-19-09:29:46
 *   Modified: 2022-11-19-09:29:47
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
using System.ComponentModel.DataAnnotations;

namespace System.Net.Http;

[GenerateEnumerationRecordStruct("HttpRequestMethod")]
public enum HttpRequestMethodEnum
{
    [Display(Name = HttpRequestMethodNames.Get)]
    Get,

    [Display(Name = HttpRequestMethodNames.Post)]
    Post,

    [Display(Name = HttpRequestMethodNames.Put)]
    Put,

    [Display(Name = HttpRequestMethodNames.Delete)]
    Delete,

    [Display(Name = HttpRequestMethodNames.Patch)]
    Patch,

    [Display(Name = HttpRequestMethodNames.Head)]
    Head,

    [Display(Name = HttpRequestMethodNames.Options)]
    Options,

    [Display(Name = HttpRequestMethodNames.Trace)]
    Trace
}
