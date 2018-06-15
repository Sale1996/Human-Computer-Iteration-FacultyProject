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

namespace FestivaliAS.PotvrdeBrisanja
{
    /// <summary>
    /// Interaction logic for ObrisiTip.xaml
    /// </summary>
    public partial class ObrisiTip : Window
    {
        public ObrisiTip()
        {
            InitializeComponent();
           
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RemoveTipClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
