using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FestivaliAS.Utils
{
    class HelpProvider
    {
        public static readonly DependencyProperty HelpKeyProperty = DependencyProperty.RegisterAttached("HelpKey", typeof(string), typeof(HelpProvider), new PropertyMetadata("MainWindow", HelpKey));

        public static string GetHelpKey(DependencyObject obj)
        {
            return obj.GetValue(HelpKeyProperty) as string;
        }

        public static void SetHelpKey(DependencyObject obj, string value)
        {
            obj.SetValue(HelpKeyProperty, value);
        }

        private static void HelpKey(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public static void ShowHelp(string key, Window originator)
        {
            ShowHelp help = new ShowHelp(key, originator);
            help.Show();
        }
    }
}
