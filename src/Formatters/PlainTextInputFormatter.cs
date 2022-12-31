/*
 * PlainTextInputFormatter.cs
 *
 *   Created: 2022-12-30-11:38:40
 *   Modified: 2022-12-30-11:38:41
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Formatters;

using System.Net.Mime.MediaTypes;
using Microsoft.AspNetCore.Mvc.Formatters;

public class PlainTextInputFormatter : InputFormatter
{
    private const string ContentType = TextMediaTypeNames.Plain;

    public PlainTextInputFormatter()
    {
        SupportedMediaTypes.Add(ContentType);
    }

    public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
    {
        var request = context.HttpContext.Request;
        using (var reader = new StreamReader(request.Body))
        {
            var content = await reader.ReadToEndAsync();
            return await InputFormatterResult.SuccessAsync(Convert.ChangeType(content, context.ModelType));
        }
    }

    public override bool CanRead(InputFormatterContext context)
    {
        return (context.ModelType.IsPrimitive || context.ModelType == typeof(string)) //& || context.ModelType.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition == typeof(IPayload<>) && i.GetGenericArguments()[0].IsPrimitive)
            && context.HttpContext.Request.ContentType.Contains(ContentType, StringComparison.OrdinalIgnoreCase);
    }
}
