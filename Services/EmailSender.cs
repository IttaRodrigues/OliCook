using System.Net;
using System.Net.Mail;


namespace OliCook.Services;
{
    public class EmailSender : ImailSender
    {
        public async Task SendEmailAsync(string emailAddress, string suject, string htmlMessage)
    
        var mail = "olicook.app@outook.com";
        var pw = "QV3E4khpZBEcL7K";

        var   client = new SmtpClient("smtp-mail.outlook.com", 587) 
      {
        EnableSsl = true,
        Credentials = new NetworkCredential(mail,pw)
      };

      MailMessage sendMail = new(
        from: mail,
        to: emailAddress,
        subject,
        htmlMessage
      );
      sendMail.IsBodyHtml = true;

      await client.SendMailAsync(sendMail);
    }
}