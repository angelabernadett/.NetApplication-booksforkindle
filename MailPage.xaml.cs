using System;
using System.Collections.Generic;
using System.Linq;
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

namespace seachbookskindle
{
    /// <summary>
    /// Interaction logic for MailPage.xaml
    /// </summary>
    public partial class MailPage : Page
    {
        public MailPage()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            KindlePage kindlePage = new KindlePage(this.mail.Text, this.password.Password);
            NavigationService.Navigate(kindlePage);
        }
    }
}
