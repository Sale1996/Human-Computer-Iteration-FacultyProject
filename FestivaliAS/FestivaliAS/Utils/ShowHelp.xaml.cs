using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace FestivaliAS.Utils
{
    public partial class ShowHelp : Window
    {
        public ShowHelp(string key, Window originator)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            string putanja = Directory.GetCurrentDirectory();
            putanja = putanja.Remove(putanja.Length - 10, 10); // ovo radimo da bi obrisali //bin//Debug jer tu nam nisu html kodovi

            string path = string.Format("{0}\\Resources\\Documentation\\{1}.html", putanja, key);

            if (!File.Exists(path))
                key = "Error";

            Uri url = new Uri(string.Format("file:///{0}\\Resources\\Documentation\\{1}.html", putanja, key));

            HelpBrowser.Navigate(url);
        }
    }
}
