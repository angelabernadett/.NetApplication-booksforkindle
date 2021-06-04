using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    
    public partial class BookPage : Page
    {

        private SearchPage _page;

        public BookPage(BookData book, SearchPage page)
        {
            InitializeComponent();
            _page = page;

            this.bookImage.Source = book.ImageData;
            this.bookTitle.Text = book.Title;
            this.bookAuthor.Text = book.Author;
            this.bookLink.Text = book.Link;
           


        }

        private void bookLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DownloadPage downloadPage = new DownloadPage(this.bookLink.Text);
            NavigationService.Navigate(downloadPage);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(_page);
        }
    }
}
