// Services/EmailService.cs
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailServiceController
{
    public async Task SendEmailAsync(string to, string subject, string body)
    {
        try
        {
            var smtpClient = new SmtpClient("smtp.office365.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("ross.rosales@rocrich.com", "Metalic944!@#$"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage("ross.rosales@rocrich.com", to)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            await smtpClient.SendMailAsync(mailMessage);
        }
        catch (Exception ex)
        {
            // Handle exception, log, or throw
            Console.WriteLine($"Error sending email: {ex.Message}");
        }
    }
}
