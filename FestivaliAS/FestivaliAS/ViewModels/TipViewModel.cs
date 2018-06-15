

namespace FestivaliAS.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Input;
    using FestivaliAS.Commands;
    using FestivaliAS.Commands.Tip;
    using FestivaliAS.EditItems;
    using FestivaliAS.Models;
    using FestivaliAS.NewItems;
    using FestivaliAS.PotvrdeBrisanja;
    using HCI_Manifestations.Models;
    using Microsoft.Win32;

    class TipViewModel
    {
        Tip tip;
        ObservableCollection<Tip> tipovi;
        Tip selektovaniTip;
        Tip selektovaniTipBackup; // koristi se kod editovanja, u slucaju da korisnik izmeni stosta i klikne odustani da vratimo staru vrednost nazad!
        String stariIDTipa;
        Tip tipFilter; //ova promenljiva ce se koristiti za filtriranje tabele tipova

        public ICommand AddTipCommand
        {
            get;
            private set;
        }

        public ICommand RemoveTipCommand
        {
            get;
            private set;
        }

        public ICommand EditTipCommand
        {
            get;
            private set;
        }

        public ICommand EditTipClickCommand
        {
            get;
            private set;

        }

        public ICommand AddTipIcon
        {
            get;
            private set;
        }

        public ICommand UbaciPostojeciTipCommand
        {
            get;
            private set;
        }
        public ICommand OdustaniOdUbacivanjaCommand
        {
            get;
            private set;
        }
        //ovu komandu sam pokusao da resim bug ali nije uspelo
        public ICommand OdustaniOdEditaCommand
        {
            get;
            private set;
        }

        public ICommand AddTipEditIcon
        {
            get;
            private set;
        }

        public ICommand PretragaFilterCommand
        {
            get;
            private set;
        }

        public ICommand PonistiPretraguCommand
        {
            get;
            private set;
        }

        public ICommand KreirajNoviTipUTabeliCommand
        {
            get;
            private set;
        }


     

       




        public TipViewModel()
        {
            tip = new Tip();
            tipFilter = new Tip();
            AddTipCommand = new AddTipCommand(this);
            RemoveTipCommand = new RemoveTipCommand(this);
            EditTipCommand = new EditTipCommand(this);
            EditTipClickCommand = new EditTipClickCommand(this);
            AddTipIcon = new AddTipIcon(this);
            UbaciPostojeciTipCommand = new UbaciPostojeciTipCommand(this);
            OdustaniOdUbacivanjaCommand = new OdustaniOdUbacivanjaCommand(this);
            OdustaniOdEditaCommand = new OdustaniEditTipCommand(this);
            AddTipEditIcon = new AddTipIconEditCommand(this);
            PretragaFilterCommand = new PretragaFilterCommand(this);
            PonistiPretraguCommand = new PonistiPretragu(this);
            KreirajNoviTipUTabeliCommand = new KreirajTipUTabeliCommand(this);


            tipovi =new ObservableCollection<Tip>() ;
            foreach (Tip item in Database.getInstance().Types)
            {
                tipovi.Add(item);
            }
            selektovaniTip = Database.getInstance().SelectedTip;
            if((Database.getInstance().SelectedTip !=null))
                SelektovaniTipBackup = new Tip(Database.getInstance().SelectedTip);
            if (Database.getInstance().SelectedTip != null)
                stariIDTipa = Database.getInstance().SelectedTip.Id;

        }

        //ovo su kao geteri seteri kako ime ide zab sam
        public ObservableCollection<Tip> Tipovi
        {
            get
            {
                return tipovi;
            }
        }

        public Tip Tip
        {
            get
            {
                return tip;
            }
            set
            {
                tip = value;
                NotifyPropertyChanged("Tip");

            }
        }

        public Tip TipFilter
        {
            get
            {
                return tipFilter;
            }
            set
            {
                tipFilter = value;
                NotifyPropertyChanged("TipFilter");

            }
        }

        public Tip SelektovaniTip
        {
            get
            {
                return selektovaniTip;
            }
            set
            {
                selektovaniTip = value;
                NotifyPropertyChanged("SelektovaniTip");

            }
        }

        public Tip SelektovaniTipBackup
        {
            get
            {
                return selektovaniTipBackup;
            }
            set
            {
                selektovaniTipBackup = value;
                NotifyPropertyChanged("SelektovaniTipBackup");

            }
        }

        /*
       ova funkcija odlucuje da li ce biti aktivirano dugme ADD ili nece
           */

        public bool CanAdd
        {
            get
            {
                if (tip == null)
                    return false;
                
                else if (String.IsNullOrWhiteSpace(tip.Id))
                    return false;

                else if (String.IsNullOrWhiteSpace(tip.Name))
                    return false;
                else if (String.IsNullOrWhiteSpace(tip.IconPath))
                    return false;

                foreach (Tip item in Database.getInstance().Types)
                {
                    if (item.Id == tip.Id)
                        return false;
                }

                 return true;
            }
        }

        //da li smemo da editujemo postojeci tip
        public bool CanEdit
        {
            get
            {
                if (SelektovaniTipBackup == null)
                {
                    return false;
                }
                else if (String.IsNullOrWhiteSpace(SelektovaniTipBackup.Id))
                    return false;
                
                else if (String.IsNullOrWhiteSpace(SelektovaniTipBackup.Name))
                    return false;

                foreach (Tip item in Database.getInstance().Types)
                {
                   if (item.Id == SelektovaniTipBackup.Id && SelektovaniTipBackup.Id != stariIDTipa)
                        return false;
                }
               
                 return true;
            }
        }

        // mozemo li ga obrisati ?
        public bool canRemove()
        {
            if (selektovaniTip == null)
            {
                return false;

            }
            return true;
        }

        //ovo samo sluzi da evidentira ako se nesto promeni!!
        public event PropertyChangedEventHandler PropertyChanged;


        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // SADA IDU KONKRETNE AKCIJE SPROVODJENJA SVEGA TOGA

        public void AddTip(object parameter)
        {
            Database.AddTip(Tip);
        }

        public void RemoveTip(object parameter)
        {
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                if (item.Tip == selektovaniTip)
                    Database.getInstance().ManifestacijeKojeSadrzeTip.Add(item);
            }
            if (Database.getInstance().ManifestacijeKojeSadrzeTip.Count == 0)
            {
                Database.DeleteType(selektovaniTip);
                Database.getInstance().SelectedTip = null;


            }
            else
            {
                Database.getInstance().TipKojiSeBrise = selektovaniTip;
                ObrisiTip prozorManifestacija = new ObrisiTip();
                prozorManifestacija.ShowDialog();
            }

            tipovi.Clear();
            foreach (Tip item in Database.getInstance().Types)
            {
                tipovi.Add(item);

            }
          //  Pretraga();
        }

        public void EditTip(object parameter)
        {
            Database.UpdateType(stariIDTipa, SelektovaniTipBackup);
            Database.getInstance().SelectedTip = null;

        }

        public void EditClickTip(object parameter)
        {
            Database.getInstance().SelectedTip = selektovaniTip;
            EditTip tip = new EditTip();
            tip.ShowDialog();

            tipovi.Clear();
            foreach (Tip item in Database.getInstance().Types)
            {
                tipovi.Add(item);

            }
          //  Pretraga();
        }

        public void AddIcon()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpg,*.ico)|*.ico;*.png;*.jpg";
            if (dialog.ShowDialog() == true)
            {
                Tip.IconPath = dialog.FileName;
            }
        }

        public void UbaciPostojeciTip()
        {
            Database.getInstance().TipZaManifestaciju = SelektovaniTip;

        }
        public void OdustaniOdUbacivanja()
        {

            Database.getInstance().TipZaManifestaciju = null;
        }

        public void OdustaniEditTipa()
        {
           // SelektovaniTip = SelektovaniTipBackup;
           // Database.getInstance().SelectedTip = SelektovaniTipBackup;
        }


        public void AddIconEdit()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpg,*.ico)|*.ico;*.png;*.jpg";
            if (dialog.ShowDialog() == true)
            {
                SelektovaniTipBackup.IconPath = dialog.FileName;
            }
        }

    //PRETRAGA
        public void Pretraga() //vrsimo pretragu po poljima! Vrsimo tako sto pravimo novu lsitu i isfiltriranu listu ubacimo u nju pa onda opet samo sto se ta lista
            //onda filtrira! tipovi su pokupili samo etikete a ne celu listu iz baze te kako izadjemo iz prozora tabele ili kliknemo ponisti vratice se pocetno stanje!
        {
            //fora ovde brojimo otvorene zagrade i zatvorene da znamo koliko u nizu zatvorenih treba kako bi smo dosli do jedne celine
          
            ObservableCollection<Tip> filterTipovi = new ObservableCollection<Tip>();
            DrvoZaPretragu<string> drvo = new DrvoZaPretragu<string>(TipFilter.Id);

            foreach (Tip item in tipovi)
            {
                if (drvo.PretragaTip(item))
                    filterTipovi.Add(item);
            }
            prebaciFilterTipove(filterTipovi);
            filterTipovi.Clear();

            //SADA IMAMO CEO TRAZENI FILTER PARSIRAN U OVOM STABLU I SVE STO TREBAMO DA RADIMO DA IDEMO KROZ TIPOVE U BAZI I UBACUJEMO U METODU DA LI ZADOVOLJAVA STABLO AKO ZADOVOLJAVA VRATICE SE TRUE
            //I ONDA CEMO NJEGA UBACITI  !!

            /* ObservableCollection<Tip> filterTipovi = new ObservableCollection<Tip>();
             if (!String.IsNullOrWhiteSpace(TipFilter.Id))
             {
                 foreach (Tip item in tipovi)90
                 {
                     if (item.Id == tipFilter.Id)
                         filterTipovi.Add(item);
                 }
                 prebaciFilterTipove(filterTipovi);
                 filterTipovi.Clear();
             }
             if (!String.IsNullOrWhiteSpace(TipFilter.Name))
             {
                 foreach (Tip item in tipovi)
                 {
                     if (item.Name == tipFilter.Name)
                         filterTipovi.Add(item);
                 }
                 prebaciFilterTipove(filterTipovi);
                 filterTipovi.Clear();
             }

     */
        }
        public void prebaciFilterTipove(ObservableCollection<Tip> filterTipovi)
        {
            tipovi.Clear();
            foreach (Tip item in filterTipovi)
            {
                tipovi.Add(item);
            }
           
        }
    //PONISTAVANJE PRETRAGE
        public void PonistiPretragu()
        {
            tipovi.Clear();
            foreach (Tip item in Database.getInstance().Types)
            {
                tipovi.Add(item);

            }
            TipFilter.Id = "";
            TipFilter.Name = "";
        }

        public void kreirajTipUTabeli()
        {
            Window1 tip = new Window1();
            tip.ShowDialog();

            tipovi.Clear();
            foreach (Tip item in Database.getInstance().Types)
            {
                tipovi.Add(item);

            }
          //  Pretraga();
        }

        


    }
}
