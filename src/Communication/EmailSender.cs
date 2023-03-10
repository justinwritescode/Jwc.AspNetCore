using System.Security.AccessControl;

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

using Azure.Communication.Email;
using Azure.Communication.Email.Models;
using Azure.Identity;

using Azure.Messaging;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

public class EmailSender : IEmailSender
{
    private readonly IOptions<EmailSenderOptions> _options;
    private readonly EmailClient _client;

    public EmailSender(IOptions<EmailSenderOptions> options)
    {
        _options = options;
        _client = new EmailClient(
            new Uri(_options.Value.ConnectionString),
            new DefaultAzureCredential()
        );
    }

    public async Task SendEmailAsync(
        string email,
        string subject,
        string htmlMessage
    )
    {
        await SendEmailAsync(
            new EmailMessage(
                _options.Value.DefaultFrom,
                new EmailContent(subject) { Html = htmlMessage },
                new EmailRecipients(new[] { new EmailAddress(email) })
            )
        );
    }

    public async Task SendEmailAsync(EmailMessage message)
    {
        await _client.SendAsync(message);
    }
}
