using System;
using System.Net;
using System.Net.Mail;

namespace BoostNetwork.Utilities
{
    public static class CommunicationUtilities
    {
        #region EMAIL SETTINGS
        static string fromAddress = "no-reply@domain.com";
        static string emailPassword = "P@ssw0rd";
        static string smtpAddress = "domain.com";
        #endregion

        public static object SendEmail(string toAddress, string subject, string message)
        {
            return SendEmail(fromAddress, emailPassword, toAddress, subject, message);
        }

        public static object SendEmail(string fromAddress, string emailPassword, string toAddress, string subject, string message)
        {
            #region SEND EMAIL CODE
            // Create and Configure the Mail Message
            MailMessage msg = new MailMessage(
                fromAddress, // From
                toAddress, // To
                subject, // Subject
                message);

            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.High;

            // Create and Configure the SMTP client
            SmtpClient client = new SmtpClient(smtpAddress, 25);
            client.Credentials = new NetworkCredential(fromAddress, emailPassword);

            using (client)
            {
                try
                {
                    client.Send(msg);
                }
                catch (Exception e)
                {
                    return e;
                }

                return "Success";
            }
            #endregion
        }
    }
}
