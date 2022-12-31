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

public static class ApplicationMediaTypeNames
{
    public const string Base = "application/";
    public const string Any = Base + "*";
    public const string Octet = Base + "octet-stream";
    public const string Pdf = Base + "pdf";
    public const string Rtf = Base + "rtf";
    public const string Soap = Base + "soap+xml";
    public const string Xml = Base + "xml";
    public const string Zip = Base + "zip";
    public const string Json = Base + "json";
    public const string JsonWithPlainText = Base + "json+plaintext";
    public const string FormUrlEncoded = Base + "x-www-formurlencoded";
    public const string ProblemJson = Base + "json+problem";
    public const string JsonPatch = Base + "json-patch+json";
    public const string Bson = Base + "bson";
    public const string MessagePack = Base + "x-msgpack";
}
