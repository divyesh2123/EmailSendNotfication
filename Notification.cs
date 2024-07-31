using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;

namespace PolyExample
{
    public class Notification
    {
        public void SendEmailNotification(string to,string body,string title)
        {
           
            
           
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("divyesh.weltec@gmail.com", "ndsi yvds bwup jfwm")

            };

            var d = new MailMessage("divyesh.weltec@gmail.com", to);

            d.Subject = title;
            d.Body = body;

            smtp.Send(d);   



        }

        public void SendEmailNotification(List<string> to, string body, string title)
        {

            string d = "";

            foreach(string t in to)
            {
                d = d + ";";
            }


            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("divyesh.weltec@gmail.com", "")

            };

            var d1 = new MailMessage("divyesh.weltec@gmail.com",d  );

            d1.Subject = title;
            d1.Body = body;

            smtp.Send(d1);

        }




    }
}
