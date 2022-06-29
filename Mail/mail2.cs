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

        // 添付するファイルのパス
        private readonly static string filePath = "test.txt";
        private static void Main()
        {
            // 添付するファイルのメディアタイプを登録。*.txtなので「text/plain」となる
            var attachment = new MimeKit.MimePart("text/plain");

            // 添付ファイルをロード
            attachment.Content = new MimeKit.MimeContent(File.OpenRead(filePath));

            // 添付してダウンロードできるファイルであることを知らせるためにContent-Dispositionヘッダを付ける
            attachment.ContentDisposition = new MimeKit.ContentDisposition();

            // 添付ファイルをBase64形式でエンコードすることを登録
            attachment.ContentTransferEncoding = MimeKit.ContentEncoding.Base64;

            // 添付ファイルのファイル名を取得
            attachment.FileName = Path.GetFileName(filePath);

            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse(fromAddress));

            email.To.Add(MailboxAddress.Parse(toAddress));

            email.Subject = "Mail Transfer Test with an Attachment Test";

            // メールで送信する本文をTextPartとして作成
            var textPart = new MimeKit.TextPart(MimeKit.Text.TextFormat.Plain);

            textPart.Text = "テキストファイル添付テスト";

            // 本文だけでなく添付ファイルもあるため、マルチパートメールで作成する
            var multiPart = new MimeKit.Multipart("mixed");

            // コンテンツ(本文、添付ファイル)を追加していく
            multiPart.Add(textPart);

            multiPart.Add(attachment);

            // emailのボディとしてマルチパートをセット
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