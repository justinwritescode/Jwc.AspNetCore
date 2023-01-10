﻿/*
 * UnauthorizedProblemDetailsExample copy.cs
 *
 *   Created: 2023-01-04-04:51:23
 *   Modified: 2023-01-04-04:51:23
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

/*
 * UnauthorizedProblemDetailsExample.cs
 *
 *   Created: 2022-12-19-05:26:13
 *   Modified: 2022-12-19-05:26:38
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Http.StatusCodes;

public class ForbiddenProblemDetails : IProblemDetails
{
    /// <summary>A short, human-readable summary of the problem.</summary>
    /// <example>Das ist verboten!</example>
    public string Title { get; set; } = "You're not allowed to fucking do that!";

    /// <example>403</example>
    public int? Status { get; set; } = Status401Unauthorized;

    /// <summary>A human-readable explanation specific to this occurrence of the problem.</summary>
    /// <example>du verdammter dummer Scheißer!  Du darfst das nicht!</example>
    public string Detail { get; set; } =
        "You dumb fuck! You're not allowed to fucking do that!  Stop touching shit you know you're not supposed to fucking touch!";

    /// <summary>A URI reference to the problem.</summary>
    /// <example>https://httpstatuses.com/403</example>
    public string Type { get; set; } = "https://httpstatuses.com/403";

    /// <summary>A URI reference to the problem.</summary>
    /// <example>/api/endpoint</example>
    public string Instance { get; set; } = "/api/endpoint";

    /// <summary>Additional details about the problem.</summary>
    /// <example>{ "traceId", "0HLQ9V1J3Q0:40000003" }</example>
    public IDictionary<string, object?> Extensions { get; set; } =
        new Dictionary<string, object?> { { "traceId", "0HLQ9V1J3Q0:40000003" } };
}
// {
//     public ProblemDetails GetExamples()
//     {
//         var pd = new ProblemDetails
//         {
//             Title = "Unauthorized",
//             Status = Status401Unauthorized,
//             Detail = "You're not allowed to fucking do this!",
//             Type = "https://httpstatuses.com/401",
//             Instance = "/api/endpoint"
//         };
//         pd.Extensions.Add("traceId", "0HLQ9V1J3Q0:00000001");
//         return pd;
//     }
// }
