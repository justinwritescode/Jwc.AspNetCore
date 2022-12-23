/*
 * ResponsePayloadOutputFormatterSelector.cs
 *
 *   Created: 2022-12-19-02:31:16
 *   Modified: 2022-12-19-02:31:19
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MvcJsonOptions = Microsoft.AspNetCore.Mvc.JsonOptions;
namespace JustinWritesCode.Payloads.Infrastructure;

public class ResponsePayloadOutputFormatterSelector : OutputFormatterSelector
{
    public override IOutputFormatter SelectFormatter(OutputFormatterCanWriteContext context, IList<IOutputFormatter> formatters, MediaTypeCollection mediaTypes)
    {
        var payload = context.Object as IResponsePayload;
        if (payload is not null)
        {
            var contentType = payload.ContentTypes.Count > 0 ? payload.ContentTypes[0] : default;
            if (contentType is not null)
            {
                var formatter = formatters.FirstOrDefault(f => f.CanWriteResult(context));
                if (formatter is not null)
                {
                    context.ContentType = contentType;
                    return formatter;
                }
            }
        }

        return new SystemTextJsonOutputFormatter(context.HttpContext.RequestServices.GetRequiredService<IOptions<MvcJsonOptions>>().Value.JsonSerializerOptions);
    }
}
