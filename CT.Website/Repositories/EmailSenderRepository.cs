using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web.Configuration;
using CT.Website.Models;

namespace CT.Website.Repositories
{
    public static class EmailSenderRepository
    {
        /// <summary>
        /// Send notification when an event is created or updated.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        public static bool SendNotification(User userModel)
        {
            List<string> emailAddresses = new List<string>();
            emailAddresses.Add("ancuta.anisiei@gmail.com");

            string emailBody = $@"Sender:{userModel.Email}
                                  Sender name: {userModel.FirstName} {userModel.LastName}
                                  Company: {userModel.Company}
                                  Message:
                                  {userModel.Message}";
            string emailSubject = "A new email was sent via CT website";
            string emailSender = "ancuta.anisiei@gmail.com";

            //For each email, send the notification.
            bool allActionsSuccessfull = true;
            foreach (var email in emailAddresses)
            {
                bool success = SendMail(emailSender, "CT Website email", email.Trim(), email.Trim(), emailSubject, emailBody);
                if (!success)
                {
                    allActionsSuccessfull = false;
                }

                //if (!success)
                //{
                //    Log.Error($"Error sending email to the user: {email}", "EmailRepository");
                //}
            }

            return allActionsSuccessfull;
        }

        /// <summary>
		/// Handles the email sending operation.
		/// </summary>
		/// <param name="from">Send mail from.</param>
		/// <param name="fromTitle">Send mail from title.</param>
		/// <param name="to">Send mail to.</param>
		/// <param name="toTitle">Send mail to title.</param>
		/// <param name="subject">Send mail subject.</param>
		/// <param name="message">Send mail message.</param>
		/// <returns>True or false if email was sent/not sent.</returns>
		private static bool SendMail(string from, string fromTitle, string to, string toTitle, string subject, string message)
        {
            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(from, fromTitle, Encoding.UTF8)
                };
                if (to.Contains(","))
                {
                    var tos = to.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var toss in tos)
                    {
                        mailMessage.To.Add(new MailAddress(toss, toTitle));
                    }
                }
                else
                {
                    mailMessage.To.Add(new MailAddress(to, toTitle));
                }

                mailMessage.Subject = subject;
                mailMessage.Body = message;
                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.Subject = subject;
                mailMessage.Body = message;
                mailMessage.BodyEncoding = Encoding.UTF8;

                var emailServer = WebConfigurationManager.AppSettings["EmailServer"];
                var emailPort = WebConfigurationManager.AppSettings["EmailPort"];
                var emailUsername = WebConfigurationManager.AppSettings["EmailUsername"];
                var emailPassword = WebConfigurationManager.AppSettings["EmailPassword"];

                var client = new SmtpClient(emailServer);
                if (!string.IsNullOrEmpty(emailPort))
                {
                    client.Port = int.Parse(emailPort);
                }

                client.EnableSsl = true;
                if (!string.IsNullOrEmpty(emailUsername) && !string.IsNullOrEmpty(emailPassword))
                {
                    client.Credentials = new NetworkCredential(emailUsername, emailPassword);
                }

                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}