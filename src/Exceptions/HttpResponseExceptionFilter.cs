// /*
//  * HttpResponseExceptionFilter.cs
//  *
//  *   Created: 2022-12-05-08:15:56
//  *   Modified: 2022-12-05-08:15:56
//  *
//  *   Author: Justin Chase <justin@justinwritescode.com>
//  *
//  *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
//  *      License: MIT (https://opensource.org/licenses/MIT)
//  */

// namespace Microsoft.AspNetCore;

// public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
// {
//     public int Order => int.MaxValue - 10;

//     public void OnActionExecuting(ActionExecutingContext context) { }

//     public void OnActionExecuted(ActionExecutedContext context)
//     {
//         if (context.Exception is HttpExceptionBase httpException)
//         {
//             context.Result = new ObjectResult(httpException.Value)
//             {
//                 StatusCode = httpResponseException.StatusCode
//             };

//             context.ExceptionHandled = true;
//         }
//     }
// }
