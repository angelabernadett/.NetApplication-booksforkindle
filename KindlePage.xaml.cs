using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace seachbookskindle
{
    /// <summary>
    /// Interaction logic for KindlePage.xaml
    /// </summary>
    public partial class KindlePage : Page
    {
        string _mail, _password;
        public KindlePage(string mail, string password)
        {
            InitializeComponent();
            _mail = mail;
            _password = password;

        }

        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Multiselect = true;
            fileDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
            fileDialog.DefaultExt = ".pdf";
            Nullable<bool> dialogOk = fileDialog.ShowDialog();

            if(dialogOk == true)
            {
                string fileName = fileDialog.FileName;
                filePath.Text = fileName;
            }

        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(this.sender.Text);
                mail.To.Add(this.receiver.Text);
                mail.Subject = this.subject.Text;
                mail.Body = this.body.Text;
                mail.IsBodyHtml = true;
                
                mail.Attachments.Add(new Attachment(filePath.Text));
                
                

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(_mail, _password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }

            this.sender.Text = "";
            this.receiver.Text = "";
            this.subject.Text = "";
            this.body.Text = "";
            this.filePath.Text = "";
        }
    }
}
