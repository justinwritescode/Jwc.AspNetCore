/* 
 * BadRequestProblemDetailsExample.cs
 * 
 *   Created: 2022-12-19-05:26:17
 *   Modified: 2022-12-19-05:26:19
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

public class BadRequestProblemDetailsExample : IExamplesProvider<ProblemDetails>
{
    public ProblemDetails GetExamples()
    {
        var pd = new ProblemDetails
        {
            Title = "Bad Request",
            Status = Status400BadRequest,
            Detail = "You dumb fuck! You submitted bad data to the server and now it's fucking PISSED and refusing to service your request!!!",
            Type = "https://httpstatuses.com/400",
            Instance = "/api/endpoint"
        };
        pd.Extensions.Add("traceId", "0HLQ9V1J3Q0:00000002");
        return pd;
    }
}
