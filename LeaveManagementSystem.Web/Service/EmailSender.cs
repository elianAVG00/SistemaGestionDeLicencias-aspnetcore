using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagementSystem.Web.Service
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromAdress = _configuration["EmailSettings:DefaultEmailAdress"];
            var stmpServer = _configuration["EmailSettings:Server"];
            var stmpPort = Convert.ToInt32(_configuration["EmailSettings:Port"]);

            var message = new MailMessage()
            {
                From = new MailAddress(fromAdress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(stmpServer, stmpPort);

            await client.SendMailAsync(message);
        }
    }
}
