/*
 * MediaTypeNames.cs
 *
 *   Created: 2022-11-29-01:56:37
 *   Modified: 2022-11-29-04:39:51
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Net.Mime.MediaTypes;

public static class MediaTypeNames
{
    public const string All = "*/*";
    public const string Text = TextMediaTypeNames.Base + "/*";
    public const string Image = ImageMediaTypeNames.Base + "/*";
    public const string Audio = AudioMediaTypeNames.Base + "/*";
    public const string Video = VideoMediaTypeNames.Base + "/*";
    public const string Application = ApplicationMediaTypeNames.Base + "/*";
    public const string Multipart = MultipartMediaTypeNames.Base + "/*";
    // public const string Message = "message/*";
    // public const string Model = "model/*";
    public const string Example = "example/*";
    // public const string Font = "font/*";
}
