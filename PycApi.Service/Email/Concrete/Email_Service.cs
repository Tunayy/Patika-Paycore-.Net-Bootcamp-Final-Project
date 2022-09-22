using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using MimeKit;
using MimeKit.Text;
using MailKit.Security;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;

namespace PycApi.Service
{
    public class Email_Service : IEmail_Service
    {
        private readonly IConfiguration _config;

        public Email_Service(IConfiguration config)
        {
            _config = config;

        }

        public void SendEmail(EmailDto request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
            smtp.Send(email);
            smtp.Disconnect(true);
            
        }
    }
}