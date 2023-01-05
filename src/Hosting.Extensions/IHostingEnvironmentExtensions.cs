/*
 * IHostingEnvironmentExtensions.cs
 *
 *   Created: 2022-12-05-07:21:20
 *   Modified: 2022-12-05-07:21:20
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace Microsoft.Extensions.Hosting;

public static class IHostingEnvironmentExtensions
{
    public static bool IsLocal(this IHostEnvironment environment) =>
        environment.IsEnvironment(EnvironmentNames.Local);
}
