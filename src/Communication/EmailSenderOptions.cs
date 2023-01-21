/*
 * EmailSender.cs
 *
 *   Created: 2022-12-24-05:29:40
 *   Modified: 2022-12-24-05:29:41
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Communication.Mail;

using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;
using JustinWritesCode.AspNetCore.Communication;

public record class EmailSenderOptions : AzureCommunicationServicesOptions<EmailAddress>
{
    public override required EmailAddress DefaultFrom { get; set; }

    public EmailSenderOptions(string connectionString)
    {
        ConnectionString = connectionString;
    }

    [SetsRequiredMembers]
    public EmailSenderOptions() : this(string.Empty) { }
}
