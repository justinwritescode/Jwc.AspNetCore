using System.Security.AccessControl;

/*
 * SmsSender.cs
 *
 *   Created: 2023-01-05-07:30:05
 *   Modified: 2023-01-05-07:30:05
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Communication;

using System;
using System.Threading.Tasks;
using Azure.Communication.Sms;
using Azure.Identity;

public interface ISmsSender
{
    Task SendSmsAsync(string number, string message);
}

public class SmsSender
{
    Task SendSmsAsync(string number, string message);
}
