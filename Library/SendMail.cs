using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Library
{
    
    internal class SendMail
    {
        string senderMail = "qbeetechz@gmail.com";
        string senderPassword = "gcicneehtpqqgasf";
        string smtpHost = " smtp.gmail.com";
        int smtpPort = 587;
        string recieverMail, subject, bady;

        public SendMail(string recieverMail, string subject,string bady)
        {
            this.recieverMail = recieverMail;
            this.subject = subject;
            this.bady = bady;
        }

        public Boolean Mail()
        {
            SmtpClient smtpClient = new SmtpClient(smtpHost,smtpPort);
            smtpClient.EnableSsl=true;
            smtpClient.Credentials=new NetworkCredential(senderMail, senderPassword);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(senderMail);
            mailMessage.To.Add(recieverMail);
            mailMessage.Subject = subject;
            mailMessage.Body = bady;
            mailMessage.IsBodyHtml = true;
            
            try
            {
                smtpClient.Send(mailMessage);
                
                return true;
            }catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
