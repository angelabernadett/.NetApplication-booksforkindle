using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchPage()
        {
            InitializeComponent();

        }
        private void DisplayBooks(string search)
        {
            List<Item> book_list = ApiHelper.GetBooks(search);
            List<BookData> bookData = new List<BookData> { };

            foreach (var item in book_list)
            {
                if (item.volumeInfo.imageLinks != null && item.volumeInfo.authors!=null)
                {
                    bookData.Add(new BookData { Title = item.volumeInfo.title, Author = "by "+item.volumeInfo.authors.First(), ImageData = LoadImage(item.volumeInfo.imageLinks.thumbnail) });
                }
                else
                {
                    if(item.volumeInfo.imageLinks != null && item.volumeInfo.authors == null)
                    {
                        bookData.Add(new BookData { Title = item.volumeInfo.title, Author = "by unknown", ImageData = LoadImage(item.volumeInfo.imageLinks.thumbnail) });
                    }
                    if(item.volumeInfo.authors != null && item.volumeInfo.imageLinks == null)
                    {
                        bookData.Add(new BookData { Title = item.volumeInfo.title, Author = "by " + item.volumeInfo.authors.First(), ImageData = LoadImage("https://www.foisor.ro/images/jpg/Foto-Medici/Image-not-available_1.jpg") });
                    }
                    if (item.volumeInfo.imageLinks == null && item.volumeInfo.authors == null)
                    {
                        bookData.Add(new BookData { Title = item.volumeInfo.title, Author = "by unknown", ImageData = LoadImage("https://www.foisor.ro/images/jpg/Foto-Medici/Image-not-available_1.jpg") });
                    }

                }

            }

            this.BookBox.ItemsSource = bookData;
        }
        private BitmapImage LoadImage(string filename)
        {
  
                return new BitmapImage(new Uri(filename));
           
            
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string search = this.searchBar.Text;
            //Console.WriteLine(search);

            DisplayBooks(search);
        }

        private void BookBox_ItemActivate(object sender, EventArgs e)
        {
            var firstSelectedItem = BookBox.SelectedItems[0];
            BookPage bookPage = new BookPage();
            NavigationService.Navigate(bookPage);
            Console.WriteLine("i was here");
        }
    }
}
