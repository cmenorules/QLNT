using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
using System.Windows.Forms;

namespace MailTest
{
    class SendMail
    {
        MailMessage _mail = new MailMessage();
        SmtpClient _smtpServer = new SmtpClient("smtp.gmail.com",587);
        String _fromMail;

        public SendMail(String fromMail, String password)
        {
            _smtpServer.Credentials = new System.Net.NetworkCredential(fromMail, password);
            _smtpServer.EnableSsl = true;
            _smtpServer.Timeout = 30000;
            _smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            _fromMail = fromMail;
        }
        public void Send( String toMail, String subject, String body)
        {
            _mail.From = new MailAddress(_fromMail);
            _mail.To.Add(new MailAddress(toMail));
            _mail.Subject = subject;
            _mail.Body = body;
            
            try{
                _smtpServer.Send(_mail);
                MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
               // MessageBox.Show(ex.ToString());
            }
        }
        public void Send(String[] toMany, String subject, String body)
        {
            _mail.From = new MailAddress(_fromMail);
            foreach (String to in toMany)
            {
                _mail.To.Add(new MailAddress(to));
            }
            _mail.Subject = subject;
            _mail.Body = body;

            try{
                _smtpServer.Send(_mail);
                MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
                //MessageBox.Show(ex.ToString());
            }
        }
        public void Send( String toMail, String subject, String body, String pathArchive)
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
                MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
