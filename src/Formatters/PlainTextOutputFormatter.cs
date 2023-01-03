namespace JustinWritesCode.AspNetCore.Formatters;

using System.Net.Mime.MediaTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;

public class PlainTextOutputFormatter : OutputFormatter
{
    public PlainTextOutputFormatter()
    {
        SupportedMediaTypes.Add(TextMediaTypeNames.Plain);
        SupportedMediaTypes.Add(TextMediaTypeNames.Css);
        SupportedMediaTypes.Add(TextMediaTypeNames.Csv);
        SupportedMediaTypes.Add(TextMediaTypeNames.Any);
    }

    public override bool CanWriteResult(OutputFormatterCanWriteContext context) =>
        context.Object is string
        && context.HttpContext.Request
            .GetTypedHeaders()
            .Accept.Any(a => a.MediaType.Value.ToLower().StartsWith("text/"));

    public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context) =>
        await context?.HttpContext.Response.WriteAsync(context.Object?.ToString() ?? string.Empty);
}
