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

namespace FestivaliAS.NewItems.ZaManifestaciju
{
    /// <summary>
    /// Interaction logic for AddEtiketa.xaml
    /// </summary>
    public partial class AddEtiketa : Window
    {
        public AddEtiketa()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Ubaci_Dugme_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Ubaci_Novi_tip_clicl(object sender, RoutedEventArgs e)
        {
            NovaEtiketa novaEtiketa = new NovaEtiketa();
            novaEtiketa.ShowDialog();

        }

        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("Manifestation", this);
        }
    }
}
