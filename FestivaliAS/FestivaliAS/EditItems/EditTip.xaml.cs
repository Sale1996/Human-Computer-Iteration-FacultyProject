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
    /// Interaction logic for EditTip.xaml
    /// </summary>
    public partial class EditTip : Window
    {
        public EditTip()
        {
            InitializeComponent();
            DataContext = new TipViewModel();

        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("Type", this);
        }

        private void zatvaranje(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //kada kliknemo na odustani ovo ce se izvrsiti
            TipViewModel aa = (TipViewModel)DataContext;
            aa.OdustaniEditTipa();
        }
    }
}
