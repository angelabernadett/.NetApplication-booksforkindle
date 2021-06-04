using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace seachbookskindle
{
    public static class ApiHelper
    {
        static string api_key = "AIzaSyAW_ubKWQYmEPVarGCOKxasG8L79l6HBU8"; //i know it's not good practice but e mai la indemana
        public static HttpClient ApiClient { get; set; } 

        public static List<Item> GetBooks(string searchWord)
        {
            ApiClient = new HttpClient();
            var response = ApiClient.GetAsync("https://www.googleapis.com/books/v1/volumes?q="+searchWord+"&filter=free-ebooks&key="+api_key).Result;
            string responseMessage = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(responseMessage);
            
            var books = JsonConvert.DeserializeObject<Root>(responseMessage);
            

            List<Item> book_list = books.items;

            /*foreach (var item in book_list)
            {
                if (item.volumeInfo.imageLinks != null)
                {
                    Console.WriteLine(item.volumeInfo.title + " " + item.volumeInfo.imageLinks.thumbnail);
                }
            }*/

            return book_list;

        }
    }
}
