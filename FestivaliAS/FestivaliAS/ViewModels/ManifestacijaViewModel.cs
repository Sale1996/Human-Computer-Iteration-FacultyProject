

namespace FestivaliAS.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Input;
    using FestivaliAS.Commands;
    using FestivaliAS.Commands.Tip;
    using FestivaliAS.EditItems;
    using FestivaliAS.Models;
    using FestivaliAS.NewItems;
    using FestivaliAS.NewItems.ZaManifestaciju;
    using HCI_Manifestations.Models;
    using Microsoft.Win32;

    class ManifestacijaViewModel : INotifyPropertyChanged
    {
        Manifestacija manifestacija;
        ObservableCollection<Manifestacija> manifestacije;
        Manifestacija selektovanaManifestacija;
        Manifestacija selektovanaManifestacijaBackup;
        String stariID;
        ObservableCollection<Manifestacija> manifestacijeKojeSadrzeTip;
      

        //OVI ATRIBUTI SLUZE SAMO FILTRIRANJE
        Manifestacija manifestacijaFilter;
        DateTime datumOd;
        DateTime datumDo;
        String brojPublikeOd;
        String brojPublikeDo;
        ObservableCollection<Tip> tipoviZaFilter;
        ObservableCollection<Etiketa> etiketeZaFilter;
        String izabraniTipZaFilter;
        String izabranaEtiketaZaFilter;

       
        /// <summary>
        /// Gets the UpdateCommand for the ViewModel
        /// </summary>
        public ICommand AddManifestacijaCommand
        {
            get;
            private set;
        }

        public ICommand RemoveManifestacijaCommand
        {
            get;
            private set;
        }

        public ICommand EditManifestacijaCommand
        {
            get;
            private set;
        }

        public ICommand EditManifestacijaClickCommand
        {
            get;
            private set;

        }

        public ICommand AddManifestationIcon
        {
            get;
            private set;
        }

        public ICommand UbaciTipCommand
        {
            get;
            private set;
        }

        public ICommand RefreshCommand
        {
            get;
            private set;
        }

        public ICommand OdustaniPravljenjeManifestacijeCommand
        {
            get;
            private set;
        }

        public ICommand IzbrisiTipKojiSadrziManifestacije
        {
            get;
            private set;
        }

        public ICommand RefreshEditCommand
        {
            get;
            private set;
        }

        public ICommand UbaciEtiketuCommand
        {
            get;
            private set;
        }

        public ICommand RefreshEtiketaCommand
        {
            get;
            private set;
        }

        public ICommand RefreshEditEtiketaCommand
        {
            get;
            private set;
        }

        public ICommand OdustaniOdBrisanjaEtiketeCommand
        {
            get;
            private set;

        }

        public ICommand AddManifestationIconEditCommand
        {
            get;
            private set;
        }


        public ICommand ObrisiTipSaManifestacijamaCommand
        {
            get;
            private set;
        }

        public ICommand PretragaFilterManifestacijeCommand
        {
            get;
            private set;
        }

        public ICommand PonistiPretraguCommand
        {
            get;
            private set;
        }

        public ICommand KreirajNovuManifestacijuUTabeliCommand
        {
            get;
            private set;
        }





        public ManifestacijaViewModel()
        {
            manifestacija = new Manifestacija();
            manifestacijaFilter = new Manifestacija();


            //instanciranje svih komandi
            AddManifestacijaCommand = new AddManifestacijaCommand(this);
            RemoveManifestacijaCommand = new RemoveManifestacijaCommand(this);
            EditManifestacijaCommand = new EditManifestacijaCommand(this);
            EditManifestacijaClickCommand = new EditManifestacijaClickCommand(this);
            AddManifestationIcon = new AddManifestationIcon(this);
            UbaciTipCommand = new UbaciTipCommand(this);
            RefreshCommand = new RefreshCommand(this);
            OdustaniPravljenjeManifestacijeCommand = new OdustaniPravljenjeManifestacijeCommand(this);
            IzbrisiTipKojiSadrziManifestacije = new RemoveTipKojiSadrziManifestaciju(this);
            RefreshEditCommand = new RefreshEditCommand(this);
            UbaciEtiketuCommand = new UbaciEtiketuCommand(this);
            RefreshEtiketaCommand = new RefreshEtiketaCommand(this);
            RefreshEditEtiketaCommand = new RefreshEditEtiketaCommand(this);
            OdustaniOdBrisanjaEtiketeCommand = new OdustaniOdBrisanjaetiketeCommand(this);
            AddManifestationIconEditCommand = new AddIconEditManifestacijaCommand(this);
            ObrisiTipSaManifestacijamaCommand = new ObrisiTipSaManifestacijamaCommand(this);
            PretragaFilterManifestacijeCommand = new PretragaFilterManifestacije(this);
            PonistiPretraguCommand = new PonistiPretraguManifestacijaCommand(this);
            KreirajNovuManifestacijuUTabeliCommand = new KreirajNovuManifestacijuUTabeliCommand(this);



            manifestacije = new ObservableCollection<Manifestacija>() ;
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                manifestacije.Add(item);
            }
            selektovanaManifestacija = Database.getInstance().SelectedManifestation;
            if(Database.getInstance().SelectedManifestation != null)
                    stariID = Database.getInstance().SelectedManifestation.Id;
            if (Database.getInstance().SelectedManifestation != null)
                SelektovanaManifestacijaBackup = new Manifestacija( Database.getInstance().SelectedManifestation);

            //kada kreiramo novu manifestaciju ovo stavljamo na true, da bi mogli da pokupimo tipove i etikete za tu manifestaciju
            Database.getInstance().DaLiDodajemoManifestaciju = true;

            //ovde ubacujemo manifestacije koje sadrze neki tip, sto se radi kod brisanja tog tipa
            manifestacijeKojeSadrzeTip = Database.getInstance().ManifestacijeKojeSadrzeTip;
            //ovde ubacujemo listu tipova i etiketa koji su potrebni za filtriranje tabele manifestacije, i dodajemo jedan tip/odnosno etiketu koja ce imati prazan id radi ponistavanja pretrage
            TipoviZaFilter =new ObservableCollection<Tip>() ;
            foreach (Tip item1 in Database.getInstance().Types)
            {
                TipoviZaFilter.Add(item1);
            }
            Tip item111 = new Tip();
            item111.Id = "";
            TipoviZaFilter.Add(item111);

            EtiketeZaFilter = new ObservableCollection<Etiketa>();
            foreach (Etiketa item2 in Database.getInstance().Tags)
            {

                EtiketeZaFilter.Add(item2);
            }
            Etiketa item222 = new Etiketa();
            item222.Id = "";
            EtiketeZaFilter.Add(item222);
           



            
        }

        public ObservableCollection<Manifestacija> Manifestacije
        {
                get
            {
                return manifestacije;
            }
            
        }

        public ObservableCollection<Manifestacija> ManifestacijeKojeSadrzeTip
        {
            get
            {
                return manifestacijeKojeSadrzeTip;
            }
        }

        /*
         geteri i seteri
             */
        public Manifestacija Manifestacija {
            get {
                return manifestacija;
            }
            set {
                manifestacija = value;
                NotifyPropertyChanged("Manifestacija");
            }
        }

        public Manifestacija ManifestacijaFilter
        {
            get
            {
                return manifestacijaFilter;
            }
            set
            {
                manifestacijaFilter = value;
                NotifyPropertyChanged("ManifestacijaFilter");
            }
        }

        public Manifestacija SelektovanaManifestacija
        {
            get
            {
                return selektovanaManifestacija;
            }
            set
            {
                selektovanaManifestacija = value;
                NotifyPropertyChanged("SelektovanaManifestacija");
            }
        }

        public Manifestacija SelektovanaManifestacijaBackup
        {
            get
            {
                return selektovanaManifestacijaBackup;
            }
            set
            {
                selektovanaManifestacijaBackup = value;
                NotifyPropertyChanged("SelektovanaManifestacijaBackup");
            }
        }

        public ObservableCollection<Tip> TipoviZaFilter
        {
            get
            {
                return tipoviZaFilter;
            }
            set
            {
                tipoviZaFilter = value;
            }

        }

        public ObservableCollection<Etiketa> EtiketeZaFilter
        {
            get
            {
                return etiketeZaFilter;
            }
            set
            {
                etiketeZaFilter = value;

            }

        }

        public String IzabraniTipZaFilter
        {
            get
            {
                return izabraniTipZaFilter;
            }
            set
            {
                izabraniTipZaFilter = value;
            }
        }

        public String IzabranaEtiketaZaFilter
        {
            get
            {
                return izabranaEtiketaZaFilter;
            }
            set
            {
                izabranaEtiketaZaFilter = value;
            }
        }

        public DateTime DatumOd
        {
            get
            {
                return datumOd;
            }
            set
            {
                datumOd = value;
                NotifyPropertyChanged("DatumOd");
            }
        }

        public DateTime DatumDo
        {
            get
            {
                return datumDo;
            }
            set
            {
                datumDo = value;
                NotifyPropertyChanged("DatumDo");
            }
        }

        public string BrojPublikeOd
        {
            get
            {
                return brojPublikeOd;
            }
            set
            {
                brojPublikeOd = value;
                NotifyPropertyChanged("BrojPublikeOd");
            }
        }

        public string BrojPublikeDo
        {
            get
            {
                return brojPublikeDo;
            }
            set
            {
                brojPublikeDo = value;
                NotifyPropertyChanged("BrojPublikeDo");
            }
        }









        /*
         ova funkcija odlucuje da li ce biti aktivirano dugme ADD ili nece
             */
        public bool CanAdd
        {
            get
            {
                if (manifestacija == null)
                {
                    return false;
                }
                else if (String.IsNullOrWhiteSpace(manifestacija.Id))
                    return false;
                else if (String.IsNullOrWhiteSpace(manifestacija.KategorijaCena))
                    return false;
                else if (String.IsNullOrWhiteSpace(manifestacija.MestoOdrzavanja))
                    return false;
                else if (String.IsNullOrWhiteSpace(manifestacija.Name))
                    return false;
                else if (String.IsNullOrWhiteSpace(manifestacija.StatusAlkohola))
                    return false;
                else if (manifestacija.HendikepiraniDozvoljeni == false && manifestacija.HendikepiraniNisuDozvoljeni == false)
                    return false;
                else if (manifestacija.PusenjeDozvoljeno == false && manifestacija.PusenjeNijeDozvoljeno == false)
                    return false;
                else if (String.IsNullOrWhiteSpace(manifestacija.OcekivanaPublika))
                {
                    return false;
                }
                else if (!manifestacija.IsDigitsOnly(manifestacija.OcekivanaPublika))
                    return false;
                else if (manifestacija.Tip == null)
                    return false;

                foreach (Manifestacija item in Database.getInstance().Manifestations)
                {
                    if (item.Id == manifestacija.Id)
                        return false;
                }

                if (manifestacija.Date == null)
                    return false;
                else return true;
            }
        }

        public bool CanEdit
        {
            get
            {
                if (SelektovanaManifestacijaBackup == null)
                {
                    return false;
                }
                else if (String.IsNullOrWhiteSpace(SelektovanaManifestacijaBackup.Id))
                    return false;
                else if (String.IsNullOrWhiteSpace(SelektovanaManifestacijaBackup.KategorijaCena))
                    return false;
                else if (String.IsNullOrWhiteSpace(SelektovanaManifestacijaBackup.MestoOdrzavanja))
                    return false;
                else if (String.IsNullOrWhiteSpace(SelektovanaManifestacijaBackup.Name))
                    return false;
                else if (String.IsNullOrWhiteSpace(SelektovanaManifestacijaBackup.StatusAlkohola))
                    return false;
                else if (SelektovanaManifestacijaBackup.HendikepiraniDozvoljeni == false && SelektovanaManifestacijaBackup.HendikepiraniNisuDozvoljeni == false)
                    return false;
                else if (SelektovanaManifestacijaBackup.PusenjeDozvoljeno == false && SelektovanaManifestacijaBackup.PusenjeNijeDozvoljeno == false)
                    return false;
                else if (String.IsNullOrWhiteSpace(SelektovanaManifestacijaBackup.OcekivanaPublika))
                    return false;
                else if (!SelektovanaManifestacijaBackup.IsDigitsOnly(SelektovanaManifestacijaBackup.OcekivanaPublika))
                    return false;

                else if (SelektovanaManifestacijaBackup.Tip == null)
                    return false;
                else if (SelektovanaManifestacijaBackup.Date == null)
                    return false;

                foreach (Manifestacija item in Database.getInstance().Manifestations)
                {
                    if (item.Id == SelektovanaManifestacijaBackup.Id && SelektovanaManifestacijaBackup.Id!= stariID)
                        return false;
                }

                return true;
            }
        }

      
        public bool canRemove() {
            if (selektovanaManifestacija == null) {
                return false;

            }
            return true;
        }

        public bool canRefresh()
        {
            if (Database.getInstance().TipZaManifestaciju == null)
                return false;
            return true;
        }


        public bool canRemoveTimKojiSadrziManifestacije()
        {
            if (Database.getInstance().ManifestacijeKojeSadrzeTip.Count != 0)
                return false;
            return true;
        }

        public bool canRefreshEtiketa()
        {
            if (Database.getInstance().EtiketeZaManifestaciju.Count == 0)
                return false;
            return true;
        }


       

        public event PropertyChangedEventHandler PropertyChanged;


        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Saves changes made to the MAnifestacija instance
        /// </summary>
        public void AddManifestacija(object parameter)
        {
            //ovaj uslov oznacava ako mi nemamo ikonicu manifestacije, da se postavi ikonica tipa koji je prikacen za nju !
            if (String.IsNullOrWhiteSpace(manifestacija.IconPath))
                Manifestacija.IconPath = Manifestacija.Tip.IconPath;

            Database.AddManifestation(manifestacija);
            //ova 2 su u upotrebi samo kod kreiranja i editovanja manifestacije
            Database.getInstance().DaLiDodajemoManifestaciju = false;
            Database.getInstance().TipZaManifestaciju = null;
            //ovo je za brisanje liste prikaza etikete za neku manifestaciju iz baze podataka koja sluzi za prikaz trenutnog stanja
            Database.getInstance().EtiketeZaManifestaciju.Clear();
        }

        public void RemoveManifestacija(object parameter)
        {
            Database.DeleteManifestation(selektovanaManifestacija);
            Database.getInstance().SelectedManifestation = null;

            manifestacije.Clear();
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                manifestacije.Add(item);


            }
        //    PretragaManifestacija();

        }

        public void EditManifestacija(object parameter)
        {
            Database.UpdateManifestation(stariID, SelektovanaManifestacijaBackup);
            Database.getInstance().SelectedManifestation = null;
            Database.getInstance().DaLiDodajemoManifestaciju = false;

            //ovo moramo prvo da obrisemo celu listu manifestacija koje sadrze tip koji se brise, u slucaju da to radimo
            //da ne bi imali opet upis istih manifestacija u tu listu 
            Database.getInstance().ManifestacijeKojeSadrzeTip.Clear();
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                if (item.Tip == Database.getInstance().TipKojiSeBrise)
                    Database.getInstance().ManifestacijeKojeSadrzeTip.Add(item);
            }

            
            Database.getInstance().EtiketeZaManifestaciju.Clear();


        }

        public void EditClickManifestacija(object parameter)
        {
            //ubacujemo selektovanu manifestaciju kako bi drugi prozor mogao da vidi koja je to manifestacija
            Database.getInstance().SelectedManifestation = selektovanaManifestacija;
            //ubacujemo etikete nase selektovane manifestacije u etikete u bazi podataka, kako bi drugi prozor mogao videti
            Database.getInstance().EtiketeZaManifestaciju.Clear();
            foreach (Etiketa item in SelektovanaManifestacija.Etikete)
            {
                Database.getInstance().EtiketeZaManifestaciju.Add( item) ;
            }
          

            EditManifestacija manifestacija = new EditManifestacija();
            manifestacija.ShowDialog();

            manifestacije.Clear();
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                manifestacije.Add(item);


            }
          //  PretragaManifestacija();
        }

        public void AddIcon()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpg,*.ico)|*.ico;*.png;*.jpg";
            if (dialog.ShowDialog() == true)
            {
               
                Manifestacija.IconPath = dialog.FileName;
            }
        }

        public void UbaciTip()
        {
           
                //ako postoji lista vec postojecih tipova tu onda mu otvaramo tabelu tipova
                AddTip tabelaTipova = new AddTip();
                tabelaTipova.ShowDialog();

            
        }

        public void RefreshManifestacija()
        {
            Manifestacija.Tip = Database.getInstance().TipZaManifestaciju;
        }

        public void RefreshEditManifestacija()
        {
            SelektovanaManifestacijaBackup.Tip = Database.getInstance().TipZaManifestaciju;
        }

        public void odustaniPravljenjeManifestacije()
        {
            //ova 2 su u upotrebi samo kod kreiranja i editovanja manifestacije

            Database.getInstance().TipZaManifestaciju = null;
            Database.getInstance().DaLiDodajemoManifestaciju = false;
            Database.getInstance().EtiketeZaManifestaciju.Clear();
        }

        public void removeTipKojiSadrziManifestaciju()
        {
            Database.DeleteType(Database.getInstance().TipKojiSeBrise);
        }

        /*
         metoda izbacuje prozor za unos nove etikete, ako u listi svih etiketa nema nijedne, ali ako ima nesto u tabeli izbacuje novi prozor za izbor iz tabele 
             */
        public void UbaciEtiketu()
        {
            
                AddEtiketa tabelaEtiketa = new AddEtiketa();
                tabelaEtiketa.ShowDialog();

            
        }

        public void RefreshEtiketaManifestacija()
        {
            Manifestacija.Etikete.Clear();
            foreach (Etiketa item in Database.getInstance().EtiketeZaManifestaciju)
            {
                Manifestacija.Etikete.Add(item);
            }
    
        }

        public void RefreshEditEtiketaManifestacija()
        {
            //zbog greske Collection was modified; enumeration operation may not execute koristimo metodu ToList kako se ovo ne bi pojavljivalo
            SelektovanaManifestacijaBackup.Etikete.Clear();
            foreach (Etiketa item in Database.getInstance().EtiketeZaManifestaciju.ToList())
            {
                SelektovanaManifestacijaBackup.Etikete.Add(item);
            }
        }

        public void OdustaniOdBrisanjaEtikete()
        {
            Database.getInstance().ManifestacijeKojeSadrzeTip.Clear();
        }


        //metoda koja ubacuje ikonicu kod izmene manifestacije
        public void AddIconEdit()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpg,*.ico)|*.ico;*.png;*.jpg";
            if (dialog.ShowDialog() == true)
            {

                SelektovanaManifestacijaBackup.IconPath = dialog.FileName;
            }
        }


        //brisanje svih tipa i manifestacija koje njega sadrze
        public void ObrisiTipSaManifestacijama()
        {
            foreach (Manifestacija item in Database.getInstance().ManifestacijeKojeSadrzeTip)
            {
                Database.DeleteManifestation(item);
            }
            Database.DeleteType(Database.getInstance().TipKojiSeBrise);
        }


        //FILTRIRANJE TABELE MANIFESTACIJA!!
        public void PretragaManifestacija()
        {
            ObservableCollection<Manifestacija> filterManifestacije = new ObservableCollection<Manifestacija>();
            DrvoZaPretragu<string> drvo = new DrvoZaPretragu<string>(ManifestacijaFilter.Id);
            foreach (Manifestacija item in manifestacije)
            {
                if (drvo.PretragaManifestacija1(item))
                    filterManifestacije.Add(item);
            }
            prebaciFilterManifestacije(filterManifestacije);
            filterManifestacije.Clear();
        

        }

        public void prebaciFilterManifestacije(ObservableCollection<Manifestacija> filterManifestacije)
        {
            manifestacije.Clear();
            foreach (Manifestacija item in filterManifestacije)
            {
                manifestacije.Add(item);
            }

        }

        //PONISTAVANJE PRETRAGE
        public void PonistiPretragu()
        {
            manifestacije.Clear();
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                manifestacije.Add(item);

            }
            ManifestacijaFilter.Id = "";
            ManifestacijaFilter.Name = "";
            ManifestacijaFilter.PusenjeDozvoljeno = false;
            ManifestacijaFilter.PusenjeNijeDozvoljeno = false;
            ManifestacijaFilter.HendikepiraniDozvoljeni = false;
            ManifestacijaFilter.HendikepiraniNisuDozvoljeni = false;
            ManifestacijaFilter.KategorijaCena = "";
            ManifestacijaFilter.MestoOdrzavanja = "";
            ManifestacijaFilter.StatusAlkohola = "";
            BrojPublikeDo = "";
            BrojPublikeOd = "";
            IzabranaEtiketaZaFilter = "";
            IzabraniTipZaFilter = "";


        }
        //metoda koja se koristi prilikom kreiranaj nove manifestaciju u tabelarnom rezimu
        public void KreirajNovuManifestacijuUTabeli()
        {
            NovaManifestacija manifestacija = new NovaManifestacija();
            manifestacija.ShowDialog();

            manifestacije.Clear();
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                manifestacije.Add(item);


            }
         //   PretragaManifestacija();
        }

        
    }
}
