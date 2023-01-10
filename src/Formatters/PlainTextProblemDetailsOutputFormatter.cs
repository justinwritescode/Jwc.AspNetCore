﻿/*
 * PlainTextProblemDetailsOutputFormatter.cs
 *
 *   Created: 2022-12-13-04:05:17
 *   Modified: 2022-12-13-04:05:18
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Formatters;

using System.Net.Mime.MediaTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using static System.Net.Http.Headers.HttpResponseHeaderNames;

public class PlainTextProblemDetailsOutputFormatter : OutputFormatter
{
    public PlainTextProblemDetailsOutputFormatter() =>
        SupportedMediaTypes.Add(TextMediaTypeNames.Plain);

    public override bool CanWriteResult(OutputFormatterCanWriteContext context) =>
        context?.Object is ProblemDetails;

    public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
    {
        var response = context?.HttpContext.Response;
        response.ContentType = TextMediaTypeNames.PlainWithProblem;
        var problemDetails = (ProblemDetails)context.Object!;
        response.StatusCode = problemDetails.Status ?? StatusCodes.Status500InternalServerError;
        response.Headers.Add(XFailed, problemDetails.Title ?? "Unknown Error");
        response.Headers.Add(XProblemDetail, problemDetails.Detail ?? "Unknown Error");
        response.Headers.Add(XProblemInstance, problemDetails.Instance ?? "Unknown Error");
        response.Headers.Add(XProblemType, problemDetails.Type ?? "Unknown Error");
        await response.WriteAsync(problemDetails.Detail);
    }
}
