using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace FestivaliAS.Utils
{
    /// <summary>
    /// Interaction logic for demoMod.xaml
    /// </summary>
    public partial class demoMod : Window, INotifyPropertyChanged
    {
        String id;
        String opis;
        String color1;
        [field: NonSerialized]
        Color boja;
        bool zavrsi = false;

        public demoMod()
        {
            InitializeComponent();
        }

        
   

        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Boja_Click(object sender, RoutedEventArgs e)
        {
        }


        public String Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public bool Zavrsi
        {
            get
            {
                return zavrsi;
            }
            set
            {
                zavrsi = value;
                OnPropertyChanged("Zavrsi");
            }
        }

        public String Opis
        {
            get
            {
                return opis;
            }
            set
            {
                opis = value;
                OnPropertyChanged("Opis");
            }
        }

        public String Color1
        {
            get { return color1; }
            set
            {
                if (value != color1)
                {
                    color1 = value;
                    OnPropertyChanged("Color1");
                }
            }
        }

        public Color Boja
        {
            get { return boja; }
            set
            {
                if (value != boja)
                {
                    boja = value;
                    color1 = boja.ToString();
                    OnPropertyChanged("Color");
                    OnPropertyChanged("Boja");
                }
            }
        }


        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string v)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(v));
            }
        }
        //
        protected override void OnKeyDown(KeyEventArgs e)
        {
            Zavrsi = true;
            this.Close();
        }


        //ovo se uvek ucitava sa otvaranjem prozorom
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();

        }
        private int i = 0;
        private bool popunioId = false;
        private bool popunioOpis = false;
        private bool popunioBoju = false;
        private bool selektovanoDodajDugme = false;

        //ovde implementiramo sta ce se raditi svaki sekund kada otkuca!
        private void dtTicker(object sender, EventArgs e)
        {
            if (!popunioId)
            {
                IdTextBox.Focus();
                i++;
                IdTextBox.Text += i.ToString();
                if (i == 7)
                {
                    popunioId = true;
                    i = 0;
                }
            }
            else if (!popunioBoju)
            {
                ColorPicker.Focus();
                i++;
                if (i == 1)
                {
                    Boja_Click(this, null);
                }
                else
                {
                    Color c = new Color();
                    c = Color.FromRgb(0, 255, 0);
                    ColorPicker.SelectedColor = c;

                    popunioBoju = true;
                    i = 0;
                }
            }
            else if (!popunioOpis)
            {
                OpisPolje.Focus();
                i++;
                OpisPolje.Text += i.ToString();
                if (i == 7)
                {
                    popunioOpis = true;
                    i = 0;
                }

            }
            else if(!selektovanoDodajDugme)
            {
                i++;
                DodajDugme.Focus();
                if (i == 3)
                {
                    selektovanoDodajDugme = true;
                }
            }
            else
            {
                DodajDugme_Click(this, null);//na kraju zatvaramo prozor
            }
            

        }

       
    }
}
