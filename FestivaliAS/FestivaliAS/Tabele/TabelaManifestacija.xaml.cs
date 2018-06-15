
using FestivaliAS.EditItems;
using FestivaliAS.NewItems;
using FestivaliAS.Utils;
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
using System.Windows.Shapes;

namespace FestivaliAS.Tabele
{
    /// <summary>
    /// Interaction logic for TabelaManifestacija.xaml
    /// </summary>
    public partial class TabelaManifestacija : Window
    {
        public TabelaManifestacija()
        {
            InitializeComponent();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewManifestacijaClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void EditManifestacijaClick(object sender, RoutedEventArgs e)
        {
         
        }

        

        private void RemoveManifestacijaClick(object sender, RoutedEventArgs e)
        {
        }

        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("ShowManifestations", this);
        }
    }
}
