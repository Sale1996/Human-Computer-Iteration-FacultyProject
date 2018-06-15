using FestivaliAS.Utils;
using FestivaliAS.ViewModels;
using Microsoft.Win32;
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

namespace FestivaliAS.NewItems
{
    /// <summary>
    /// Interaction logic for NovaManifestacija.xaml
    /// </summary>
    public partial class NovaManifestacija : Window
    {
        public NovaManifestacija()
        {
            InitializeComponent();
            DataContext = new ManifestacijaViewModel();
        }

        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("Manifestation", this);
        }

        //ova metoda sluzi kako bi se osvezila validacija koja je nametnuda na dugme "DA" u radiobuttunu hendikepirani_DA kada se klikne na "NE" dugme
        private void Hendikepriani_No_Click(object sender, RoutedEventArgs e)
        {
            Hendikepirani.IsChecked = false;

        }
        //ova metoda sluzi kako bi se osvezila validacija koja je nametnuda na dugme "DA" u radiobuttunu pusenje_DA kada se klikne na "NE" dugme
        private void Pusenje_No_Click(object sender, RoutedEventArgs e)
        {
            Pusenje.IsChecked = false;

        }


        private void zatvaranje(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ManifestacijaViewModel model = (ManifestacijaViewModel)DataContext;
            model.odustaniPravljenjeManifestacije();
        }

    }
}
