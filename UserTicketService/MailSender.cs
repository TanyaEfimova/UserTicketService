using System;
using System.Net.Mail;

namespace UserTicketService
{
    public class MailSender : IMailSender
    {
        public bool Send()
        {
            string to = "mail5x5@mail.ru";
            string from = "mail5x5@mail.ru";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using new SMTP-client";
            message.Body = @"Using this new feature, you can send an email message.";
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
