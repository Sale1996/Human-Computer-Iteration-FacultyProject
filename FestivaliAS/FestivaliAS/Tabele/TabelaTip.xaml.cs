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
using FestivaliAS.NewItems;
using FestivaliAS.Utils;

namespace FestivaliAS.Tabele
{
    /// <summary>
    /// Interaction logic for TabelaTip.xaml
    /// </summary>
    public partial class TabelaTip : Window
    {
        public TabelaTip()
        {
            InitializeComponent();
        }

      

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("ShowTypes", this);
        }
    }
}
