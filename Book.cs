using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace seachbookskindle
{
    
        /*public class IndustryIdentifier
        {
            public string type { get; set; }
            public string identifier { get; set; }
        }*/

        /*public class ReadingModes
        {
            public bool text { get; set; }
            public bool image { get; set; }
        }

        public class PanelizationSummary
        {
            public bool containsEpubBubbles { get; set; }
            public bool containsImageBubbles { get; set; }
        }*/

        public class ImageLinks
        {
            public string smallThumbnail { get; set; }
            public string thumbnail { get; set; }
        }

        public class VolumeInfo
        {
            public string title { get; set; }
            public List<string> authors { get; set; }
            /*public string publisher { get; set; }
            public string publishedDate { get; set; }
            public string description { get; set; }
            public List<IndustryIdentifier> industryIdentifiers { get; set; }
            public ReadingModes readingModes { get; set; }
            public int pageCount { get; set; }
            public string printType { get; set; }
            public List<string> categories { get; set; }
            public int averageRating { get; set; }
            public int ratingsCount { get; set; }
            public string maturityRating { get; set; }
            public bool allowAnonLogging { get; set; }
            public string contentVersion { get; set; }
            public PanelizationSummary panelizationSummary { get; set; }*/
            public ImageLinks imageLinks { get; set; }
            /*public string language { get; set; }
            public string previewLink { get; set; }
            public string infoLink { get; set; }
            public string canonicalVolumeLink { get; set; }
            public string subtitle { get; set; }
            public bool? comicsContent { get; set; }*/
        }

        /*public class ListPrice
        {
            public double amount { get; set; }
            public string currencyCode { get; set; }
            public int amountInMicros { get; set; }
        }*/

        /*public class RetailPrice
        {
            public double amount { get; set; }
            public string currencyCode { get; set; }
            public int amountInMicros { get; set; }
        }*/

        /*public class Offer
        {
            public int finskyOfferType { get; set; }
            public ListPrice listPrice { get; set; }
            public RetailPrice retailPrice { get; set; }
        }*/

        /*public class SaleInfo
        {
            public string country { get; set; }
            public string saleability { get; set; }
            public bool isEbook { get; set; }
            public ListPrice listPrice { get; set; }
            public RetailPrice retailPrice { get; set; }
            public string buyLink { get; set; }
            public List<Offer> offers { get; set; }
        }*/

        public class Epub
        {
            public bool isAvailable { get; set; }
            public string downloadLink { get; set; }
        }

        public class Pdf
        {
            public bool isAvailable { get; set; }
            public string downloadLink { get; set; }
        }

        public class AccessInfo
        {
            //public string country { get; set; }
            //public string viewability { get; set; }
            //public bool embeddable { get; set; }
            //public bool publicDomain { get; set; }
            //public string textToSpeechPermission { get; set; }
            public Epub epub { get; set; }
            public Pdf pdf { get; set; }
            //public string webReaderLink { get; set; }
           // public string accessViewStatus { get; set; }
            //public bool quoteSharingAllowed { get; set; }
        }

        /*public class SearchInfo
        {
            public string textSnippet { get; set; }
        }*/

        public class Item
        {
            //public string kind { get; set; }
            //public string id { get; set; }
            //public string etag { get; set; }
            //public string selfLink { get; set; }
            public VolumeInfo volumeInfo { get; set; }
            //public SaleInfo saleInfo { get; set; }
            public AccessInfo accessInfo { get; set; }
            //public SearchInfo searchInfo { get; set; }
        }

        public class Root
        {
            //public string kind { get; set; }
            //public int totalItems { get; set; }
            public List<Item> items { get; set; }
        }

        public class BookData
        {
            private string _Title;
            public string Title
            {
                get { return this._Title; }
                set { this._Title = value; }
            }

            private string _Author;
            public string Author
            {
                get { return this._Author; }
                set { this._Author = value; }
            }

            private string _Link;
            public string Link
            {
                get { return this._Link; }
                set { this._Link = value; }
            }

        private BitmapImage _ImageData;
            public BitmapImage ImageData
            {
                get { return this._ImageData; }
                set { this._ImageData = value; }
            }

        }


}

