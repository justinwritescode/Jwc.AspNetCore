/*
 * BindHashids.cs
 *
 *   Created: 2022-12-20-01:47:37
 *   Modified: 2022-12-20-01:47:38
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.AspNetCore.Mvc;
using global::AspNetCore.Hashids;

public class HashidsAttribute : ModelBinderAttribute
{
    public HashidsAttribute() : base(typeof(global::AspNetCore.Hashids.Mvc.HashidsModelBinder)) { }
}
