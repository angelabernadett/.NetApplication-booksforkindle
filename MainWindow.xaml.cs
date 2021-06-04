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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.intro.Text = "Hello!\n This is an application meant to search for free books using the GoogleBooks API and download them as PDF.\n After that you have the option to send that file via mail right to your kindle by using the Kindle Personal Document Service. For that you need to make sure that you know your kindle's mail address and also that the email that you are using is authorized. Read more here: http://www.amazon.com/kindlepersonaldocuments/ \n \n Also be sure to use a gmail address and you may need to allow less secure application on your Google account (USUALLY NOT RECOMENDED TO DO!!) but otherwise it won't send an email. It's just a school project tho, I'm not gonna hack you.\n \n Keep on reading! :) ";
        }

        private  void SearchClick(object sender, RoutedEventArgs e)
        {
            intro.Visibility = Visibility.Hidden;
            SearchPage searchPage = new SearchPage();
            Main.Content = searchPage;
        }


        private void KindleClick(object sender, RoutedEventArgs e)
        {
            intro.Visibility = Visibility.Hidden;
            MailPage mailPage = new MailPage();
            Main.Content = mailPage;
        }

        
    }
}
