using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using PycApi.Service;
using MailKit.Net.Smtp;
using PycApi.Dto;

namespace PycApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMail_Controller : ControllerBase
    {
        private readonly IEmail_Service _emailService;
        public EMail_Controller(IEmail_Service emailService)
        {
            _emailService = emailService;
        }

        //[HttpPost]
        //public IActionResult SendEmail(string body)
        //{
        //    var email = new MimeMessage();
        //    email.From.Add(MailboxAddress.Parse("adolph.herzog@ethereal.email"));
        //    email.To.Add(MailboxAddress.Parse("tunayturer@gmail.com"));
        //    email.Subject = "Test Email Subject";
        //    email.Body = new TextPart(TextFormat.Html) { Text = body };



        //    using var smtp = new SmtpClient();
        //    smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
        //    smtp.Authenticate("adolph.herzog@ethereal.email", "d5TaZyhTeg4kQgNbqu");
        //    smtp.Send(email);
        //    smtp.Disconnect(true);



        //    return Ok();


        //}

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            _emailService.SendEmail(request);
            return Ok();
        }
    }

}
