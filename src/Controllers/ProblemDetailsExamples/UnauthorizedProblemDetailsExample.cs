/* 
 * UnauthorizedProblemDetailsExample.cs
 * 
 *   Created: 2022-12-19-05:26:13
 *   Modified: 2022-12-19-05:26:38
 * 
 *   Author: Justin Chase <justin@justinwritescode.com>
 *   
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.ProblemDetailsExamples;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using static Microsoft.AspNetCore.Http.StatusCodes;

public class UnauthorizedProblemDetailsExample : IExamplesProvider<ProblemDetails>
{
    public ProblemDetails GetExamples()
    {
        var pd = new ProblemDetails
        {
            Title = "Unauthorized",
            Status = Status401Unauthorized,
            Detail = "You are not authorized to access this resource.",
            Type = "https://httpstatuses.com/401",
            Instance = "/api/endpoint"
        };
        pd.Extensions.Add("traceId", "0HLQ9V1J3Q0:00000001");
        return pd;
    }
}
