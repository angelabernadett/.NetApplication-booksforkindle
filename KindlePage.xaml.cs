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
using Microsoft.Win32;

namespace seachbookskindle
{
    /// <summary>
    /// Interaction logic for KindlePage.xaml
    /// </summary>
    public partial class KindlePage : Page
    {
        public KindlePage()
        {
            InitializeComponent();
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
    }
}
