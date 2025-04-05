

using System.Net.Mail;

public class SMTPSender
{
    private readonly SmtpClient _smtpClient;
    private readonly string _fromAddress;

    public SMTPSender(string smtpServer, int port, string fromAddress)
    {
        _smtpClient = new SmtpClient(smtpServer, port);
        _fromAddress = fromAddress;
    }

    public void SendEmail(string toAddress, string subject, string body)
    {
        var mailMessage = new MailMessage(_fromAddress, toAddress, subject, body);
        _smtpClient.Send(mailMessage);
    }
}