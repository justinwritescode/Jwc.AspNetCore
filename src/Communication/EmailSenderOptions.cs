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

namespace JustinWritesCode.AspNetCore.Mail;

using System.Diagnostics.CodeAnalysis;

public record class EmailSenderOptions
{
    public required string ConnectionString { get; init; }
    public required string DefaultSender { get; init; }

    public EmailSenderOptions(string connectionString)
    {
        ConnectionString = connectionString;
    }

    [SetsRequiredMembers]
    public EmailSenderOptions() : this(string.Empty) { }
}
