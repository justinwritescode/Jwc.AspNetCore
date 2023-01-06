/*
 * MimeMediaType.cs
 *
 *   Created: 2023-01-06-06:35:11
 *   Modified: 2023-01-06-06:35:11
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Net.Mime.MediaTypes;

using System.Linq;

[System.Text.Json.Serialization.JsonConverter(typeof(IMediaTypeJsonConverter))]
public interface IMediaType
{
    int Id { get; }
    string Name { get; }
    string Description { get; }
    string DisplayName { get; }
    string ShortName { get; }
    string GroupName { get; }
    int Order { get; }
    string Uri { get; }
    string Prompt { get; }
    string ToString();
    // string Extension { get; set; }
    // string[] Extensions { get; set; }
}

public static class IMediaTypeExtensions
{
    public static bool IsWildcard(this IMediaType @this) => @this.Name.Contains("*");

    public static bool Matches(this IMediaType @this, IMediaType other)
        => @this.IsWildcard() && other.Name.StartsWith(@this.Name.Split('/').First()) ||
            other.IsWildcard() && @this.Name.StartsWith(other.Name.Split('/').First()) ||
            @this.Name.Equals(other.Name);

    public static bool Matches(this IMediaType @this, string other)
        => @this.Matches(new ExampleMediaType(ExampleMediaTypesEnum.Any, (int)ExampleMediaTypesEnum.Any, other, other));
}



public class IMediaTypeJsonConverter : JsonConverter<IMediaType>
{
    public override IMediaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var mediaType = reader.GetString();
        if (mediaType is null)
            throw new JsonException("Media type cannot be null");

        return new TempMediaType { Name = mediaType };
    }

    public override void Write(Utf8JsonWriter writer, IMediaType value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}


public class TempMediaType : IMediaType
{
    public int Id => 0;
    public string Uri => "urn:example:media-type";
    public string Description => Name;
    public string GroupName => Name;
    public string ShortName => Name;
    public string DisplayName => Name;
    public string Name { get; set; } = default!;
    public int Order => 0;
    public string Prompt => "";
}
