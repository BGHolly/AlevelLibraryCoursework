using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;
using System.Threading;
using System.Configuration;
using System.Xml.Linq;
using MimeKit;
using LibraryProject.Data;
using MailKit.Net.Smtp;

namespace LibraryProject.Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.WriteToFile("Simple Service started {0}");
            this.ScheduleService();
        }

        protected override void OnStop()
        {
            this.WriteToFile("Simple Service stopped {0}");
            this.Schedular.Dispose();
        }

        private Timer Schedular;
        public void ScheduleService()
        {
            try
            {
                Schedular = new Timer(new TimerCallback(SchedularCallback));

                //Set the Default Time.
                DateTime scheduledTime = DateTime.MinValue;
                scheduledTime = DateTime.Parse("10:00");
                if (DateTime.Now > scheduledTime)
                {
                    //If Scheduled Time is passed set Schedule for the next day.
                    scheduledTime = scheduledTime.AddDays(1);
                }
                TimeSpan timeSpan = scheduledTime.Subtract(DateTime.Now);
                string schedule = string.Format("{0} day(s) {1} hour(s) {2} minute(s) {3} seconds(s)", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

                this.WriteToFile("Simple Service scheduled to run after: " + schedule + " {0}");

                //Get the difference in Minutes between the Scheduled and Current Time.
                int dueTime = Convert.ToInt32(timeSpan.TotalMilliseconds);

                //Change the Timer's Due Time.
                Schedular.Change(dueTime, Timeout.Infinite);
            }
            catch (Exception ex)
            {
                WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace);

                //Stop the Windows Service.
                using (System.ServiceProcess.ServiceController serviceController = new System.ServiceProcess.ServiceController("SimpleService"))
                {
                    serviceController.Stop();
                }
            }
        }
        private void SchedularCallback(object e)
        {
            try
            {
                string name = "";
                var mailMessage = new MimeMessage();
                var details = LibraryDataFunctions.GetEmailBookDue();
                while (details.Item1.Count > 0)
                {
                    name = pop(details.Item1);
                    string email = pop(details.Item2);
                    string title = pop(details.Item3);
                    string author = pop(details.Item4);
                    string days = pop(details.Item5);

                    this.WriteToFile("Trying to send email to" + name);
                    mailMessage.From.Add(new MailboxAddress("SWA-Library", "samuelwhitbreadlibrary@gmail.com"));
                    mailMessage.To.Add(new MailboxAddress(name, email));
                    mailMessage.Subject = "Reminder of due books";
                    mailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = string.Format("Dear {0}, \n\r You have borrowed {1} by {2} from the school library and it is due in {3} days, please remember to bring it back before this date.", name, title, author, days) };
                }

                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("smtp.gmail.com", 587, true);
                    smtpClient.Authenticate("samuelwhitbreadlibrary@gmail.com", "tXSVeo5B & A8h412 ^");
                    smtpClient.Send(mailMessage);
                    smtpClient.Disconnect(true);
                    this.WriteToFile("successfully sent email to" + name);
                }

                this.ScheduleService();
            }
            catch (Exception ex)
            {
                WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace);

                //Stop the Windows Service.
                using (System.ServiceProcess.ServiceController serviceController = new System.ServiceProcess.ServiceController("SimpleService"))
                {
                    serviceController.Stop();
                }
            }
            try
            {
                var mailMessage = new MimeMessage();
                List<string> list = LibraryDataFunctions.GetSafeguardingConcern();
                this.WriteToFile("Trying to send email to safeguarding");
                mailMessage.From.Add(new MailboxAddress("SWA-Library", "samuelwhitbreadlibrary@gmail.com"));
                mailMessage.To.Add(new MailboxAddress("safeguarding", "samuelwhitbreadsafeguarding@gmail.com"));
                mailMessage.Subject = "Library safeguarding flagged students";
                mailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = string.Format("Dear safeguarding, \n\r these students have been flagged as safeguarding concern by the library system.\n\r" + list.ToString()) };

                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("smtp.gmail.com", 587, true);
                    smtpClient.Authenticate("samuelwhitbreadlibrary@gmail.com", "tXSVeo5B & A8h412 ^");
                    smtpClient.Send(mailMessage);
                    smtpClient.Disconnect(true);
                    this.WriteToFile("successfully sent email to safeguarding");
                }
            }
            catch { }
        }
            
        private void WriteToFile(string text)
        {
            string path = "C:\\git\\libraryproject\\LibraryProject.Core\\Logs\\ServiceLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(string.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
                writer.Close();
            }
        }
        public string pop(List<string> list)
        {
            string value = list.ElementAt(0);
            list.RemoveAt(0);
            return value;
        }
    }
}
