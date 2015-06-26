using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
using System.Windows.Forms;

namespace MailTest
{
	// chú ý: mail muốn gửi phải "turn on less security App" của fromMail, đăng nhập vào mail của mình và theo đường dẫn theo dể setting
	// https://www.google.com/settings/security/lesssecureapps?pli=1
    //lớp này chỉ sử dụng cho mail người gởi, người nhận là gmail
    class SendMail
    {

        MailMessage _mail = new MailMessage();
        SmtpClient _smtpServer = new SmtpClient("smtp.gmail.com", 587);
        String _fromMail;
        //hàm khởi tạo
        //Khởi tạo cần fromMail là mail của người gởi, password là mật khẩu mail.
        public SendMail(String fromMail, String password)
        {
            _smtpServer.Credentials = new System.Net.NetworkCredential(fromMail, password);
            _smtpServer.EnableSsl = true;
            _smtpServer.Timeout = 30000;
            _smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            _fromMail = fromMail;
            _mail.IsBodyHtml = true;
        }
        // Hàm gửi 1 mail tới 1 mail, không đính kèm
        // + toMail là mail mình muốn gửi vd thaoho21294@gmail.com
        // + subject là chủ đề của mail
        // + body là nội dung mail
        public void Send(String toMail, String subject, String body)
        {
            _mail.From = new MailAddress(_fromMail);
            _mail.To.Add(new MailAddress(toMail));
            _mail.Subject = subject;
            _mail.Body = body;

            try
            {
                _smtpServer.Send(_mail);
                //MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
                throw new Exception();
                // MessageBox.Show(ex.ToString());
            }
        }
        // Hàm gửi 1 mail tới nhiều mail
        // toMany : danh sách các địa chỉ mail nhận
        // subject : chủ đề của mail
        // body: nội dung mail
        public void Send(String[] toMany, String subject, String body)
        {
            _mail.From = new MailAddress(_fromMail);
            _mail.Subject = subject;
            _mail.Body = body;
            foreach (String to in toMany)
            {
                _mail.To.Add(new MailAddress(to));
            }
            try
            {
                _smtpServer.Send(_mail);
               // MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
                throw new Exception();
                //MessageBox.Show(ex.ToString());
            }
        }
        //Hàm gửi 1 mail tới 1 mail
        // toMail: mail sẽ nhận vd thaoho21294@gmail.com
        // subject : chủ đề của mail
        // body: nội dung mail
        // pathArchive: Đường dẫn file cần đính kèm, ví dụ: @"E:\MY DOCUMENT\IDEA\Mygame.docx". Phải có dấu @ để khỏi phải viết \\

        public void Send(String toMail, String subject, String body, String pathArchive)
        {

            _mail.From = new MailAddress(_fromMail);
            _mail.To.Add(new MailAddress(toMail));
            _mail.Subject = subject;
            _mail.Body = body;
            System.Net.Mail.Attachment attachment = new Attachment(pathArchive);
            _mail.Attachments.Add(attachment);
            try
            {
                _smtpServer.Send(_mail);
              //  MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
                throw new Exception();
                //MessageBox.Show(ex.ToString());
            }
        }
        // Hàm gửi 1 mail tới 1 mail, có file đính kèm 
        // toMail: mail sẽ nhận
        // subject: chủ đề mail
        // body: nội dung mail
        // listPathArchive: danh sách các đường dẫn file sẽ gửi
        public void Send(String toMail, String subject, String body, String[] listPathArchive)
        {
            _mail.From = new MailAddress(_fromMail);
            _mail.To.Add(new MailAddress(toMail));
            _mail.Subject = subject;
            _mail.Body = body;

            foreach (String pathArchive in listPathArchive)
            {
                System.Net.Mail.Attachment attachment = new Attachment(pathArchive);
                _mail.Attachments.Add(attachment);

            }
            try
            {
                _smtpServer.Send(_mail);
             //   MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
                throw new Exception();
                //MessageBox.Show(ex.ToString());
            }
        }
        // Hàm gửi 1 mail tới nhiều mail, có file đính kèm 
        // toMany: danh sách mail sẽ nhận
        // subject: chủ đề mail
        // body: nội dung mail
        // listPathArchive: danh sách các đường dẫn file sẽ gửi
        public void Send(String[] toMany, String subject, String body, String[] listPathArchive)
        {

            _mail.From = new MailAddress(_fromMail);
            _mail.Subject = subject;
            _mail.Body = body;
            foreach (String to in toMany)
            {
                _mail.To.Add(new MailAddress(to));
                
            }
            foreach (String pathArchive in listPathArchive)
            {
                System.Net.Mail.Attachment attachment = new Attachment(pathArchive);
                _mail.Attachments.Add(attachment);
            }
            try
            {
                _smtpServer.Send(_mail);
              //  MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
                throw new Exception();
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
