using FestivaliAS.EditItems;
using FestivaliAS.Models;
using FestivaliAS.NewItems;
using FestivaliAS.Tabele;
using FestivaliAS.Utils;
using FestivaliAS.ViewModels;
using HCI_Manifestations.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FestivaliAS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Manifestacija ClickedManifestation;
        private GlavniProzorViewModel model;
        private Point startPoint = new Point();
        private demoMod etiketaZaDemo = new demoMod();
        private bool izadjiIzDema = false;




        public MainWindow()
        {
            InitializeComponent();
            //kreirane precice preko  tastature
            model = new GlavniProzorViewModel();
            GlavniProzorViewModel.ucitajFajlove();
            ManifestationPins_Draw(); // ovde ponovo crtamo na mapu manifestacije koje su bile na mapi 

            KeyboardAccelerators();

        }

        //METHOD WITH IS ACTIVATED ON CLICK
        private void NewManifestacijaClick(object sender, RoutedEventArgs e)
        {
            NovaManifestacija manifestacija = new NovaManifestacija();
            manifestacija.ShowDialog();
        }

        private void NewTipClick(object sender, RoutedEventArgs e)
        {
            Window1 tip = new Window1();
            tip.ShowDialog();
        }

        private void NewEtiketaClick(object sender, RoutedEventArgs e)
        {
            NovaEtiketa etiketa = new NovaEtiketa();
            etiketa.ShowDialog();
        }

        private void NewTableManifestacijaClick(object sender, RoutedEventArgs e)
        {
            TabelaManifestacija tabela = new TabelaManifestacija();
            tabela.ShowDialog();
        }

        private void NewTableTip(object sender, RoutedEventArgs e)
        {
            TabelaTip tabela = new TabelaTip();
            tabela.ShowDialog();
        }

        private void NewTableEtiketa(object sender, RoutedEventArgs e)
        {
            TabelaEtiketa tabela = new TabelaEtiketa();
            tabela.ShowDialog();
        }

        private void Exit_Application(object sender, RoutedEventArgs e)
        {
                Application.Current.Shutdown(0);
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            GlavniProzorViewModel.sacuvaj();
            MessageBox.Show("Uspešno sačuvano!");


        }

        private void pritisnutDemoMod(object sender, RoutedEventArgs e)
        {
            //ovako ovde cemo otvarati dijalog etikete za demo sve dok u njoj ne kliknemo neku tipku na tastaturi
            //kada kliknemo neku tipku na tastaturi bool vrednost Zavrsi ide na TRUE i tada cemo izaci iz while petlje
            //sve dok je to false onda pravimo novi demoMod i pisemo sve iznova!
            izadjiIzDema = false;
            while (!izadjiIzDema)
            {
                etiketaZaDemo = new demoMod();
                etiketaZaDemo.ShowDialog();
                izadjiIzDema = etiketaZaDemo.Zavrsi;
                
                etiketaZaDemo = null;
                
            }

        }
        public void KeyboardAccelerators()
        {

            /* UBACENE PRECICE ZA OTVARANJE NOVOG ELEMENTA I TABELA*/
            RoutedCommand newCmd = new RoutedCommand();
            newCmd.InputGestures.Add(new KeyGesture(Key.M, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(newCmd, NewManifestacijaClick));

            newCmd = new RoutedCommand();
            newCmd.InputGestures.Add(new KeyGesture(Key.T, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(newCmd, NewTipClick));


            newCmd = new RoutedCommand();
            newCmd.InputGestures.Add(new KeyGesture(Key.E, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(newCmd, NewEtiketaClick));

            newCmd = new RoutedCommand();
            newCmd.InputGestures.Add(new KeyGesture(Key.M, ModifierKeys.Control | ModifierKeys.Shift));
            CommandBindings.Add(new CommandBinding(newCmd, NewTableManifestacijaClick));

            newCmd = new RoutedCommand();
            newCmd.InputGestures.Add(new KeyGesture(Key.T, ModifierKeys.Control | ModifierKeys.Shift));
            CommandBindings.Add(new CommandBinding(newCmd, NewTableTip));

            newCmd = new RoutedCommand();
            newCmd.InputGestures.Add(new KeyGesture(Key.E, ModifierKeys.Control | ModifierKeys.Shift));
            CommandBindings.Add(new CommandBinding(newCmd, NewTableEtiketa));

            newCmd = new RoutedCommand();
            newCmd.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Alt));
            CommandBindings.Add(new CommandBinding(newCmd, Exit_Application));

        }

        //ZA DOKUMENTACIJU

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            ShowHelp help = new ShowHelp("MainWindow", this);
            help.Show();
        }
        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(this);
            if (focusedControl is DependencyObject)
            {
                string str = HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                HelpProvider.ShowHelp(str, this);
            }
            else
            {
                HelpProvider.ShowHelp(GetType().Name, this);
            }
        }


        //DRAG AND DROP

        private void Map_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(Map);
            ClickedManifestation = Manifestation_Click((int)mousePosition.X, (int)mousePosition.Y);
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                if (ClickedManifestation != null)
                {
                    Database.getInstance().SelectedManifestation = ClickedManifestation;
                    EditManifestacija edit = new EditManifestacija();
                    edit.Show();
                }
            }
        }

        private void Map_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(Map);
            ClickedManifestation = Manifestation_Click((int)mousePosition.X, (int)mousePosition.Y);

            if (ClickedManifestation != null)
            {
                var Map = sender as Canvas;
                Map.ContextMenu.IsOpen = true;
            }
        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.GetPosition(Map);
            Vector diff = startPoint - mousePosition;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                Manifestacija manifestation = Manifestation_Click((int)mousePosition.X, (int)mousePosition.Y);

                if (manifestation != null)
                {
                    DataObject dragData = new DataObject("manifestation", manifestation);
                    DragDrop.DoDragDrop(Map, dragData, DragDropEffects.Move);
                }
            }
        }

        private void Map_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("manifestation") || sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }


        private void Map_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("manifestation"))
            {
                Point dropPosition = e.GetPosition(Map);
                Manifestacija manifestationPin = e.Data.GetData("manifestation") as Manifestacija;

                Manifestacija manifestationOnThatPosition = Manifestation_Click((int)dropPosition.X, (int)dropPosition.Y);

                if (manifestationOnThatPosition != null && !manifestationPin.Id.Equals(manifestationOnThatPosition.Id))
                {
                    manifestationPin.X = (int)dropPosition.X + 35;
                    manifestationPin.Y = (int)dropPosition.Y + 35;
                }
                // if it is close to the edge, move it a little bit
                else if ((int)dropPosition.Y > -30 && (int)dropPosition.Y < 10)
                {
                    manifestationPin.X = (int)dropPosition.X - 35;
                    manifestationPin.Y = (int)dropPosition.Y + 17;
                }
                else if ((int)dropPosition.X > -30 && (int)dropPosition.X < 10)
                {
                    manifestationPin.X = (int)dropPosition.X + 17;
                    manifestationPin.Y = (int)dropPosition.Y - 35;
                }
                else
                {
                    manifestationPin.X = (int)dropPosition.X - 35;
                    manifestationPin.Y = (int)dropPosition.Y - 35;
                }
                Database.UpdateManifestation(manifestationPin.Id, manifestationPin);
                ManifestationPins_Draw();
            }
        }

        private void ManifestationPins_Draw()
        {
            Map.Children.Clear();
            foreach (Manifestacija manifestation in model.Manifestacije)
            {
                if (manifestation.X != -1 && manifestation.Y != -1 && manifestation.X !=0 && manifestation.Y !=0)
                {
                    Image ManifestationIcon = new Image();
                    ManifestationIcon.Width = 70;
                    ManifestationIcon.Height = 70;
                    ManifestationIcon.ToolTip = manifestation.Id + " " + manifestation.Name;

                    if (File.Exists(manifestation.IconPath))
                    {
                        ManifestationIcon.Source = new BitmapImage(new Uri(manifestation.IconPath, UriKind.Absolute));
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške pri učitavanju ikonice manifestacije, molimo dodajte novu ikonicu!", "Došlo je do greške!");
                        Database.getInstance().SelectedManifestation = ClickedManifestation;
                        EditManifestacija edit = new EditManifestacija();
                        edit.Show();
                        break;
                    }

                    Map.Children.Add(ManifestationIcon);

                    Canvas.SetLeft(ManifestationIcon, manifestation.X);
                    Canvas.SetTop(ManifestationIcon, manifestation.Y);

                }
            }

            // To scroll down in list, for easier drag and dropping recent item
            if (listView != null && listView.Items.Count != 0)
            {
                listView.ScrollIntoView(listView.Items.GetItemAt(listView.Items.Count - 1));
            }
        }


        private void ListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.GetPosition(null);
            Vector diff = startPoint - mousePosition;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                ListView listView = sender as ListView;
                ListViewItem listViewItem = FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

                if (listViewItem != null)
                {
                    Manifestacija manifestation = (Manifestacija)listView.ItemContainerGenerator.ItemFromContainer(listViewItem);
                    DataObject dragData = new DataObject("manifestation", manifestation);
                    DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
                }
            }
        }

        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }


        private Manifestacija Manifestation_Click(int x, int y)
        {
            foreach (Manifestacija manifestation in model.Manifestacije)
            {
                if (manifestation.X != -1 && manifestation.Y != -1)
                {
                    if (Math.Sqrt(Math.Pow((x - manifestation.X - 35), 2) + Math.Pow((y - manifestation.Y - 35), 2)) < 20)
                    {
                        return manifestation;
                    }
                }
            }
            return null;
        }


        private void RemoveManifestationIcon_Click(object sender, RoutedEventArgs e)
        {
            ClickedManifestation.X = -1;
            ClickedManifestation.Y = -1;
            ManifestationPins_Draw();
        }

        private void DeleteManifestation_Click(object sender, RoutedEventArgs e)
        {
            Database.DeleteManifestation(ClickedManifestation);
            ManifestationPins_Draw();
        }

        private void UpdateManifestation_Click(object sender, RoutedEventArgs e)
        {
             Database.getInstance().SelectedManifestation = ClickedManifestation;
                    EditManifestacija edit = new EditManifestacija();
                    edit.Show();
        }

        private void zatvaranje(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult odgovor=MessageBox.Show("Možda je ostalo nesačuvanih fajlova. Da li hoćete da dodatno sacuvate sve fajlove i izađete iz aplikacije?", "Upozorenje!", MessageBoxButton.YesNoCancel);
            //onda poredimo ako je odgovor == YES onda pokreni serijalizaciju
            //ako je == NO samo ugasi aplikaciju
            //
            //u slucaju da klikne na cancel onda ovo uradi :  e.Cancel = true;
            if(odgovor == MessageBoxResult.Yes)
            {
                GlavniProzorViewModel.sacuvaj();
                //Serijalizacija ovde
            }
            if(odgovor == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Current.Shutdown(0);
            }
        }
    }
}
