using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce.Services
{
    // Class for SendGrid to send emails
    public class SendGridService : BaseService
    {
        // Contact us email
        public async Task ContactUsEmail()
        {
            await SendContactUsEmail();
        }

        public async Task SendContactUsEmail()
        {
            var ToEmail = "austinoverholt@gmail.com";
            var FromEmail = "austinjoeloverholt@mailinator.com";
            var ToName = "Austin";
            var FromName = "Joel";
            var apiKey = SgApiKey;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(FromEmail, FromName);
            var subject = "Contact Us Input";
            var plainTextContent = "Hello here is the message";
            var to = new EmailAddress(ToEmail, ToName);
            var htmlContent = "<h3>(From Contact Us Page On Social Media Grader)</h3>" + plainTextContent;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

    }
}
