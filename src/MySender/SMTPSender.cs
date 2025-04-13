using System.Net.Mail;

/// <summary>
/// handle sending emails via SMTP
/// </summary>
public class SMTPSender
{
    private readonly SmtpClient _smtpClient;
    private readonly string _fromAddress;

    /// <summary>
    /// Base constructor for SMTPSender
    /// </summary>
    /// <param name="smtpServer"></param>
    /// <param name="port"></param>
    /// <param name="fromAddress"></param>
    public SMTPSender(string smtpServer, int port, string fromAddress)
    {
        _smtpClient = new SmtpClient(smtpServer, port);
        _fromAddress = fromAddress;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="toAddress"></param>
    /// <param name="subject"></param>
    /// <param name="body"></param>
    public void SendEmail(string toAddress, string subject, string body)
    {
        var mailMessage = new MailMessage(_fromAddress, toAddress, subject, body);
        _smtpClient.Send(mailMessage);
    }
}