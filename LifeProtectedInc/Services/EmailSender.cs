﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace LifeProtectedInc.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        //public Task SendEmailAsync(string email, string subject, string message)
        //{
        //    return Task.CompletedTask;
        //}

        public async Task SendEmailAsync(string email, string subject, string message)
        {

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("LifeProtectedInc", "goldenking963@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("Patrick Martin", email));
            emailMessage.Subject = subject;
            //emailMessage.Body = new TextPart("plain") { Text = message };
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = message;

            emailMessage.Body = bodyBuilder.ToMessageBody();


            using (var client = new SmtpClient())
            {
                //client.LocalDomain = "some.domain.com";
                //await client.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);
                await client.ConnectAsync("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect).ConfigureAwait(false);
                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                await client.AuthenticateAsync("goldenking963@gmail.com", "18golden63king").ConfigureAwait(false);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }

        }
    }
}
