using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Contracts;
using ThriveAPP.Models;

namespace ThriveAPP.Services
{
    public class EmailService : IEmailServices
    {
        private readonly string apiKey = Api_Keys.Sendgrid_Api_Key;
        public EmailService()
        {

        }

        public async Task<bool> EmailAsync(IEmail sender, IEmail Receiver)
        {
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(sender.Email, sender.Name);

            //TODO pass in content
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress(Receiver.Email, Receiver.Name);
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

            return response.StatusCode == System.Net.HttpStatusCode.Accepted ? true : false;
        }

        public async Task EmailAlertAsync(IEnumerable<IEmail> recipients)
        {
            List<Task<Response>> tasks = new List<Task<Response>>();
            var client = new SendGridClient(apiKey);

            foreach (IEmail recipient in recipients)
            {
                var from = new EmailAddress(Api_Keys.SystemEmail, "Thrive Web App");
                var subject = "Student recent performance alert";
                var to = new EmailAddress(recipient.Email, recipient.Name);
                var plainTextContent = "and easy to do anywhere, even with C#";
                var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                tasks.Add(client.SendEmailAsync(msg));
            }

            var results = await Task.WhenAll(tasks);
            

            foreach(var result in results)
            {
                if(result.StatusCode != System.Net.HttpStatusCode.Accepted)
                {
                    //Failed emails
                }
            }
        }
                 
    }
}
