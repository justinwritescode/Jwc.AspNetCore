/*
 * Operations copy.cs
 *
 *   Created: 2023-01-03-03:13:58
 *   Modified: 2023-01-03-03:13:59
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Authentication.Enums;

[GenerateEnumerationClass(nameof(Operations), "JustinWritesCode.AspNetCore.Authentication")]
public enum OperationsEnum
{
    Create,
    Read,
    Update,
    Delete
}
