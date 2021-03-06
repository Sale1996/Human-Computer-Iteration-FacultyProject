﻿using FestivaliAS.Utils;
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

namespace FestivaliAS.NewItems.ZaManifestaciju
{
    /// <summary>
    /// Interaction logic for AddTip.xaml
    /// </summary>
    public partial class AddTip : Window
    {
        public AddTip()
        {
            InitializeComponent();
            DataContext = new TipViewModel();
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
            Window1 noviTip = new Window1();
            noviTip.ShowDialog();

        }

        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("Manifestation", this);
        }

        private void zatvaranje(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TipViewModel model = (TipViewModel)DataContext;
            model.OdustaniOdUbacivanja();
        }


     }
}
