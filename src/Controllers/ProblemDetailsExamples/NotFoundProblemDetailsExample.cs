/*
 * NotFoundProblemDetailsExample.cs
 *
 *   Created: 2022-12-19-05:27:44
 *   Modified: 2022-12-19-05:27:45
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace JustinWritesCode.AspNetCore.ProblemDetailsExamples;

public class NotFoundProblemDetailsExample : IExamplesProvider<ProblemDetails>
{
    public ProblemDetails GetExamples()
    {
        var pd = new ProblemDetails
        {
            Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
            Title = "Not Found",
            Status = Status404NotFound,
            Detail =
                "The thing you were looking for ain't here, you dumb fuck!  You should probably go back to the home page and try again.",
            Instance = "/api/endpoint"
        };
        pd.Extensions.Add("traceId", "0HLQ9V1J3Q0:00000003");
        return pd;
    }
}
