using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace MailTransferTest
{
    class Program
    {
        // 自分のアドレス
        private readonly static string fromAddress = "your_mail_address@xxx.com";

        // 送り先のアドレス
        private readonly static string toAddress = "other_mail_address@xxx.com";
        private static void Main()
        {
            // インスタンス生成
            var email = new MimeMessage();

            // 送り主、送り先を登録
            email.From.Add(MailboxAddress.Parse(fromAddress));

            email.To.Add(MailboxAddress.Parse(toAddress));

            // メールの件名
            email.Subject = "Mail Transfer Test";

            // 本文
            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain){Text = "Test Test Test"};

            // smtpサーバーにアクセスするためのインスタンス生成
            using var smtp = new SmtpClient();

            // サーバー名やポート番号、接続方法を登録。サーバーによってここは異なる
            smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);

            // 本人確認してもらうためのアカウント名やパスワードを登録
            smtp.Authenticate(fromAddress, "yourAccountPassword");

            // 送信
            smtp.Send(email);

            // smtpサーバーとの接続を切る
            smtp.Disconnect(true);

            System.Console.Write("Mail Sended");
        }
    }
}