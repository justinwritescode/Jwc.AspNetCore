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

public class InternalServerErrorProblemDetailsExample : IExamplesProvider<ProblemDetails>
{
    public ProblemDetails GetExamples()
    {
        var pd = new ProblemDetails
        {
            Title = "Internal Server Error",
            Status = Status500InternalServerError,
            Detail = "Now you've REALLY pissed off the fucking server! It's so fucked it can't even provide you with any real details on what the fuckin' problem is!",
            Type = "https://httpstatuses.com/500",
            Instance = "/api/endpoint"
        };
        pd.Extensions.Add("traceId", "0HLQ9V1J3Q0:00000004");
        return pd;
    }
}
