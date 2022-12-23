/*
 * AutoMapper.cs
 *
 *   Created: 2022-12-10-08:55:12
 *   Modified: 2022-12-10-08:55:13
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;

public static class AddAutoMapperExtensions
{
    public static IServiceCollection AddAutoMapper<T>(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(T));
        return services;
    }
}
