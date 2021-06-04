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
        }

        private  void SearchClick(object sender, RoutedEventArgs e)
        {
            SearchPage searchPage = new SearchPage();
            Main.Content = searchPage;
        }


        private void KindleClick(object sender, RoutedEventArgs e)
        {
            KindlePage kindlePage = new KindlePage();
            Main.Content = kindlePage;
        }

        
    }
}
