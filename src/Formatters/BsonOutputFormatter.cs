using System;

namespace JustinWritesCode.AspNetCore.Formatters;

using System.Collections;
using System.Net.Mime.MediaTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

public class BsonMediaTypeFormatter : IInputFormatter, IOutputFormatter
{
    public BsonMediaTypeFormatter()
    {
    }

    private JsonSerializerSettings __jsonSerializerSettings = CreateDefaultSerializerSettings();

    public static JsonSerializerSettings CreateDefaultSerializerSettings()
    {
        return new JsonSerializerSettings()
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            TypeNameHandling = TypeNameHandling.None
        };
    }

    public JsonSerializerSettings SerializerSettings => __jsonSerializerSettings ??= CreateDefaultSerializerSettings();

    public bool CanRead(InputFormatterContext context)
        => context.HttpContext.Request.GetTypedHeaders().ContentType.MediaType.ToString().Contains(ApplicationMediaTypeNames.Bson);


    public bool CanWriteResult(OutputFormatterCanWriteContext context)
        => //context.Object is string &&
              context.HttpContext.Request.GetTypedHeaders().Accept.Any(a => a.MediaType.Value.ToLower().StartsWith("application/bson"));

    public Task<InputFormatterResult> ReadAsync(InputFormatterContext context)
    {
        var request = context.HttpContext.Request;
        var contentHeaders = request.GetTypedHeaders().ContentType;
        var contentLength = request.GetTypedHeaders().ContentLength;
        var stream = request.Body;
        var type = context.ModelType;
        var formatterLogger = context.HttpContext.RequestServices.GetService<ILogger<BsonMediaTypeFormatter>>();
        var tcs = new TaskCompletionSource<InputFormatterResult>();
        if (contentHeaders != null && contentLength == 0) return Task.FromResult(InputFormatterResult.NoValue());

        try
        {
            var reader = new BsonDataReader(stream);
            if (typeof(IEnumerable).IsAssignableFrom(type)) reader.ReadRootValueAsArray = true;

            using (reader)
            {
                var jsonSerializer = JsonSerializer.Create(SerializerSettings);
                var output = jsonSerializer.Deserialize(reader, type);
                if (formatterLogger != null)
                {
                    jsonSerializer.Error += (sender, e) =>
                    {
                        var exception = e.ErrorContext.Error;
                        formatterLogger.LogError(e.ErrorContext.Path, exception.Message);
                        e.ErrorContext.Handled = true;
                    };
                }
                tcs.SetResult(InputFormatterResult.Success(output));
            }
        }
        catch (Exception e)
        {
            tcs.SetException(e);
        }

        return tcs.Task;
    }

    public async Task WriteAsync(OutputFormatterWriteContext context)
    {
        if (context.ObjectType == null) throw new ArgumentNullException("type is null");
        if (context.WriterFactory == null) throw new ArgumentNullException("Write stream is null");

        using var ms = new MemoryStream();
        using var bsonWriter = new BsonDataWriter(ms) { CloseOutput = false };
        var jsonSerializer = JsonSerializer.Create(SerializerSettings);
        jsonSerializer.Serialize(bsonWriter, context.Object);
        bsonWriter.Flush();
        await context.HttpContext.Response.Body.WriteAsync(ms.ToArray().AsMemory(0, (int)ms.Length));
    }
}
