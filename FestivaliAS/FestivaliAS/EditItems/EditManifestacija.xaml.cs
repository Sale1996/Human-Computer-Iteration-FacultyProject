using FestivaliAS.Utils;
using FestivaliAS.ViewModels;
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

namespace FestivaliAS.EditItems
{
    /// <summary>
    /// Interaction logic for EditManifestacija.xaml
    /// </summary>
    public partial class EditManifestacija : Window
    {
        public EditManifestacija()
        {
            InitializeComponent();
            DataContext = new ManifestacijaViewModel();

            //ovaj lanac else-if-ova sluzi kako bi osvezili polja comboboxa za KATEGORIJU CENA, jer se desavao bug koji je sa time ispravljen!
            if (KategorijaCena1.Text == Besplatno.Content.ToString())
                Besplatno.IsSelected = true;
            else if (KategorijaCena1.Text == NiskeCene.Content.ToString())
                NiskeCene.IsSelected = true;
            else if (KategorijaCena1.Text == SrednjeCene.Content.ToString())
                SrednjeCene.IsSelected = true;
            else if (KategorijaCena1.Text == VisokeCene.Content.ToString())
                VisokeCene.IsSelected = true;

            //sada isto to samo za mesto odrzavanja
            if (MestoOdrzavanja1.Text == MestoOdrzavanjaNapolju.Content.ToString())
                MestoOdrzavanjaNapolju.IsSelected = true;
            else if (MestoOdrzavanja1.Text == MestoOdrzavanjaUnutra.Content.ToString())
                MestoOdrzavanjaUnutra.IsSelected = true;

            //isto to samo za status sluzenaj alkohola
            if (StatusAlkohola1.Text == StatusNemaAlkohola.Content.ToString())
                StatusNemaAlkohola.IsSelected = true;
            else if (StatusAlkohola1.Text == StatusMozeDoneti.Content.ToString())
                StatusMozeDoneti.IsSelected = true;
            else if (StatusAlkohola1.Text == StatusKupujeNaLicuMesta.Content.ToString())
                StatusKupujeNaLicuMesta.IsSelected = true;
        }

        private void IzmeniDugme_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void Cancel_Click1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("Manifestation", this);
        }

        private void zatvaranje(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //kada kliknemo na odustani ovo ce se izvrsiti , moramo da kastujemo ovo jer datacontext nije svestan da je onog tipa
            ManifestacijaViewModel aa = (ManifestacijaViewModel)DataContext;
            aa.odustaniPravljenjeManifestacije();
        }
    }
}
