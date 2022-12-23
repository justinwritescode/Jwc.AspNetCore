namespace JustinWritesCode.AspNetCore.Formatters;

using System.Net.Mime.MediaTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;

public class PlainTextOutputFormatter : IOutputFormatter
{
    public bool CanWriteResult(OutputFormatterCanWriteContext context)
        => context.Object is string &&
              context.HttpContext.Request.GetTypedHeaders().Accept.Any(a => a.MediaType.Value.ToLower().StartsWith("text/"));

    public Task WriteAsync(OutputFormatterWriteContext context)
        => context.HttpContext.Response.WriteAsync((string)context.Object!);
}
