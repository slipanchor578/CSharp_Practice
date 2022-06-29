using System.IO;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;


namespace MailTransferTest
{
    class Program
    {
        private readonly static string fromAddress = "your_mail_address@xxx.com";

        private readonly static string toAddress = "other_mail_address@xxx.com";

        private readonly static string filePath = "test.png";
        private static void Main()
        {
            // 毎回手動でメディアタイプを登録するのも面倒なので、ファイルから動的にメディアタイプを取得してもらう
            var mimeType = MimeKit.MimeTypes.GetMimeType(filePath);

            // メディアタイプから添付インスタンスを作成。この場合自動でmimeは「image/png」として解決される
            var attachment = new MimeKit.MimePart(mimeType);

            attachment.Content = new MimeKit.MimeContent(File.OpenRead(filePath));

            attachment.ContentDisposition = new MimeKit.ContentDisposition();

            attachment.ContentTransferEncoding = MimeKit.ContentEncoding.Base64;

            attachment.FileName = Path.GetFileName(filePath);

            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse(fromAddress));

            email.To.Add(MailboxAddress.Parse(toAddress));

            email.Subject = "Mail Transfer Test with a Dynamic MimeType Get Test";

            var textPart = new MimeKit.TextPart(MimeKit.Text.TextFormat.Plain);

            textPart.Text = "動的なMimeTypeの取得";

            var multiPart = new MimeKit.Multipart("mixed");

            multiPart.Add(textPart);

            multiPart.Add(attachment);

            email.Body = multiPart;
            
            using var smtp = new SmtpClient();

            smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);

            smtp.Authenticate(fromAddress, "yourAccountPassword");

            // 送信
            smtp.Send(email);

            smtp.Disconnect(true);

            System.Console.Write("Mail Sended");
        }
    }
}