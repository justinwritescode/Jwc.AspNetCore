/*
 * HashidsAttribute.cs
 *
 *   Created: 2022-12-20-05:18:39
 *   Modified: 2022-12-20-05:18:39
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Text.Json;

public class HashidsAttribute : System.Text.Json.Serialization.JsonConverterAttribute
{
    public HashidsAttribute() : base(typeof(global::AspNetCore.Hashids.Json.HashidsJsonConverter))
    { }
}
