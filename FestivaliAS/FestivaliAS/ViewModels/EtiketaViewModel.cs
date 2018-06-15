

namespace FestivaliAS.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Input;
    using FestivaliAS.Commands;
    using FestivaliAS.Commands.Etiketa;
    using FestivaliAS.Commands.Tip;
    using FestivaliAS.EditItems;
    using FestivaliAS.Models;
    using FestivaliAS.NewItems;
    using FestivaliAS.PotvrdeBrisanja;
    using HCI_Manifestations.Models;
    using Microsoft.Win32;


    class EtiketaViewModel
    {
        Etiketa etiketa;
        ObservableCollection<Etiketa> etikete;
        Etiketa selektovanaEtiketa;
        Etiketa selektovanaEtiketaBackup; // koristi se kod editovanja
        String stariIDEtikete;
        ObservableCollection<Etiketa> etiketeManifestacije; //ovo nam sluzi samo da bi videli etikete u manifestaciji kojoj ocemo ubaciti etikete
        Etiketa etiketaZaBrisanjeUManifestaciji;
        ObservableCollection<Manifestacija> manifestacijeKojeSadrzeEtiketu;
        Etiketa etiketaFilter; //ova promenljiva sluzi za filtriranje tabele etikete

        public ICommand AddEtiketaCommand
        {
            get;
            private set;
        }

        public ICommand RemoveEtiketaCommand
        {
            get;
            private set;
        }

        public ICommand EditEtiketaCommand
        {
            get;
            private set;
        }

        public ICommand EditEtiketaClickCommand
        {
            get;
            private set;

        }

        public ICommand UbaciPostojecuEtiketuCommand
        {
            get;
            private set;
        }

        public ICommand ObrisiEtiketuIzManifestacijeCommand
        {
            get;
            private set;

        }

        public ICommand OdustaniOdBrisanjaEtiketeCommand
        {
            get;
            private set;
        }

        public ICommand ObrisiEtiketuSadrzanuUManifestaciji
        {
            get;
            private set;
        }

        public ICommand PretragaFilterEtiketeCommand
        {
            get;
            private set;
        }
        public ICommand PonistavanjePretrageCommand
        {
            get;
            private set;
        }

        public ICommand KreirajNovuEtiktuUTabeliCommand
        {
            get;
            private set;
        }

     

        public EtiketaViewModel()
        {
            etiketa = new Etiketa();
            etiketaFilter = new Etiketa();
            AddEtiketaCommand = new AddEtiketaCommand(this);
            RemoveEtiketaCommand = new RemoveEtiketaCommand(this);
            EditEtiketaCommand = new EditEtiketaCommand(this);
            EditEtiketaClickCommand = new EditEtiketaClickCommand(this);
            UbaciPostojecuEtiketuCommand = new UbaciPostojecuEtiketuCommand(this);
            ObrisiEtiketuIzManifestacijeCommand = new removeEtiketaIzManifestacije(this);
            OdustaniOdBrisanjaEtiketeCommand = new OdustaniOdBrisanjaEtikete(this);
            ObrisiEtiketuSadrzanuUManifestaciji = new ObrisiEtiketuSadrzanuUManifestacijiCommand(this);
            PretragaFilterEtiketeCommand = new FilterPretragaEtiketaCommand(this);
            PonistavanjePretrageCommand = new PonistiFilterEtiketeCommand(this);
            KreirajNovuEtiktuUTabeliCommand = new KreirajNovuEtiketuUTabeliCommand(this);

            etikete = new ObservableCollection<Etiketa>() ; //ovo je uradjeno ako se promeni nesto u lokalnoj promenljivoj da se ne desi u bazi podataka!
            foreach (Etiketa item in Database.getInstance().Tags)
            {
                etikete.Add(item);
            }
            selektovanaEtiketa = Database.getInstance().SelectedEtiketa;
            if (Database.getInstance().SelectedEtiketa != null)
                stariIDEtikete = Database.getInstance().SelectedEtiketa.Id;
            if (Database.getInstance().SelectedEtiketa != null)
                selektovanaEtiketaBackup = new Etiketa(Database.getInstance().SelectedEtiketa);
            etiketeManifestacije = Database.getInstance().EtiketeZaManifestaciju;
            manifestacijeKojeSadrzeEtiketu = Database.getInstance().ManifestacijeKojeSadrzeEtiketu;

        }


        //geteri i seteri tj ovo se drugacije zove ovde


        public ObservableCollection<Manifestacija> ManifestacijeKojeSadrzeEtiketu
        {
            get
            {
                return manifestacijeKojeSadrzeEtiketu;
            }
        }


        public ObservableCollection<Etiketa> Etikete
        {
            get
            {
                return etikete;
            }
        }

        public ObservableCollection<Etiketa> EtiketeManifestacije
        {
            get
            {
                return etiketeManifestacije;
            }
            set
            {
                etiketeManifestacije = value;
                NotifyPropertyChanged("EtiketeManifestacije");

            }
        }

        public Etiketa Etiketa
        {
            get
            {
                return etiketa;
            }
            set
            {
                etiketa = value;
                NotifyPropertyChanged("Etiketa");

            }
        }

        public Etiketa EtiketaFilter
        {
            get
            {
                return etiketaFilter;
            }
            set
            {
                etiketaFilter = value;
                NotifyPropertyChanged("EtiketaFilter");

            }
        }


        public Etiketa EtiketaZaBrisanjeUManifestaciji
        {
            get
            {
                return etiketaZaBrisanjeUManifestaciji;
            }
            set
            {
                etiketaZaBrisanjeUManifestaciji = value;
                NotifyPropertyChanged("EtiketaZaBrisanjeUManifestaciji");

            }
        }

        public Etiketa SelektovanaEtiketa
        {
            get
            {
                return selektovanaEtiketa;
            }
            set
            {
                selektovanaEtiketa = value;
                NotifyPropertyChanged("SelektovanaEtiketa");

            }
        }

        public Etiketa SelektovanaEtiketaBackup
        {
            get
            {
                return selektovanaEtiketaBackup;
            }
            set
            {
                selektovanaEtiketaBackup = value;
                NotifyPropertyChanged("SelektovanaEtiketaBackup");

            }
        }



        /*
     ova funkcija odlucuje da li ce biti aktivirano dugme ADD ili nece
         */

        public bool CanAdd
        {
            get
            {
                if (etiketa == null)
                {
                    return false;
                }
                else if (String.IsNullOrWhiteSpace(etiketa.Id))
                    return false;

                else if (Etiketa.Boja == null)
                    return false;

                foreach (Etiketa item in Database.getInstance().Tags)
                {
                    if (item.Id == Etiketa.Id)
                        return false;
                }

               

                return true;
            }
        }

        //da li smemo da editujemo postojecu etiketu
        public bool CanEdit
        {
            get
            {
                if (selektovanaEtiketaBackup == null)
                {
                    return false;
                }
                else if (String.IsNullOrWhiteSpace(selektovanaEtiketaBackup.Id))
                    return false;

                else if (String.IsNullOrWhiteSpace(selektovanaEtiketaBackup.Color))
                    return false;

                foreach (Etiketa item in Database.getInstance().Tags)
                {
                    if (item.Id == SelektovanaEtiketaBackup.Id && SelektovanaEtiketaBackup.Id != stariIDEtikete)
                        return false;
                }
                return true;
            }
        }

        // mozemo li je obrisati ?
        public bool canRemove()
        {
            if (selektovanaEtiketa == null)
            {
                return false;

            }
            return true;
        }

        public bool canObrisatiEtiketuIzManifestacije()
        {
            if(EtiketaZaBrisanjeUManifestaciji == null)
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


        ////////////////////////////////////////////////
        // SADA IDU KONKRETNE AKCIJE SPROVODJENJA SVEGA TOGA

        public void AddEtiketa(object parameter)
        {
            Database.AddEtiketa(Etiketa);
         
        }

        public void RemoveEtiketa(object parameter)
        {
            Database.getInstance().ManifestacijeKojeSadrzeEtiketu.Clear();
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                foreach(Etiketa item1 in item.Etikete)
                {
                    if (item1 == selektovanaEtiketa)
                        Database.getInstance().ManifestacijeKojeSadrzeEtiketu.Add(item);
                }
            }


            if(Database.getInstance().ManifestacijeKojeSadrzeEtiketu.Count == 0)
            {
                Database.DeleteTag(selektovanaEtiketa);
                Database.getInstance().SelectedEtiketa = null;
            }
            else
            {
                Database.getInstance().EtiketaKojaSeBrise = selektovanaEtiketa;
                ObrisiEtiketu obrisi = new ObrisiEtiketu();
                obrisi.ShowDialog();
            }

            etikete.Clear();
            foreach (Etiketa item in Database.getInstance().Tags)
            {
                etikete.Add(item);

            }
         //   Pretraga();

        }

        public void EditEtiketa(object parameter)
        {
            Database.UpdateTag(stariIDEtikete, selektovanaEtiketaBackup);
            Database.getInstance().SelectedEtiketa = null;

        }

        public void EditClickEtiketa(object parameter)
        {
            Database.getInstance().SelectedEtiketa = selektovanaEtiketa;
            EditEtiketa etiketa = new EditEtiketa();
            etiketa.ShowDialog();

            etikete.Clear();
            foreach (Etiketa item in Database.getInstance().Tags)
            {
                etikete.Add(item);

            }
          //  Pretraga();
        }

        public void UbaciPostojecuEtiketu()
        {
            foreach (Etiketa item in Database.getInstance().EtiketeZaManifestaciju)
            {
                if (item == SelektovanaEtiketa)
                    return;
            }
            Database.getInstance().EtiketeZaManifestaciju.Add(SelektovanaEtiketa);
        }

        public void RemoveEtiketaIzManifestacije()
        {
            Database.DeleteEtiketaIzManifestacije(EtiketaZaBrisanjeUManifestaciji);
            
        }

        //samo ce obrisati listu manifestacija koje sadrze tu etiketu u slucaju odustajanja od brisanja etikete
        public void OdustaniOdBrisanjaEtikete()
        {
            Database.getInstance().ManifestacijeKojeSadrzeEtiketu.Clear();
        }

        //brise etiketu iz liste etiketa + brise etiketu iz svih manifestacija

        public void ObrisiEtiketuSadrzanuUManifestacijama()
        {
            selektovanaEtiketa = Database.getInstance().EtiketaKojaSeBrise;
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {

                for (int i = 0; i < item.Etikete.Count; i++)
                {
                    if (item.Etikete[i] == selektovanaEtiketa)
                    {
                        item.Etikete.RemoveAt(i);
                        break;
                    }
                }         
            }

            Database.DeleteTag(selektovanaEtiketa);
            Database.getInstance().SelectedEtiketa = null;
            Database.getInstance().EtiketaKojaSeBrise = null;
            Database.getInstance().ManifestacijeKojeSadrzeEtiketu.Clear();

            etikete.Clear();
            foreach (Etiketa item in Database.getInstance().Tags)
            {
                etikete.Add(item);

            }
       //     Pretraga();


        }


        public void Pretraga() //vrsimo pretragu po poljima! Vrsimo tako sto pravimo novu lsitu i isfiltriranu listu ubacimo u nju pa onda opet samo sto se ta lista
                               //onda filtrira! tipovi su pokupili samo etikete a ne celu listu iz baze te kako izadjemo iz prozora tabele ili kliknemo ponisti vratice se pocetno stanje!
        {
            ObservableCollection<Etiketa> filterEtikete = new ObservableCollection<Etiketa>();
            DrvoZaPretragu<string> drvo = new DrvoZaPretragu<string>(EtiketaFilter.Id);
            foreach (Etiketa item in etikete)
            {
                if (drvo.PretragaEtiketa(item))
                    filterEtikete.Add(item);
            }
            prebaciFilterEtikete(filterEtikete);
            filterEtikete.Clear();

            /*
            if (!String.IsNullOrWhiteSpace(EtiketaFilter.Id))
            {
                foreach (Etiketa item in etikete)
                {
                    if (item.Id == etiketaFilter.Id)
                        filterEtikete.Add(item);
                }
                prebaciFilterEtikete(filterEtikete);
                filterEtikete.Clear();
            }
            if (!String.IsNullOrWhiteSpace(EtiketaFilter.Color))
            {
                foreach (Etiketa item in etikete)
                {
                    if (item.Color == EtiketaFilter.Color)
                        filterEtikete.Add(item);
                }
                prebaciFilterEtikete(filterEtikete);
                filterEtikete.Clear();
            }
            */

        }
        public void prebaciFilterEtikete(ObservableCollection<Etiketa> filterEtikete)
        {
            etikete.Clear();
            foreach (Etiketa item in filterEtikete)
            {
                etikete.Add(item);
            }

        }
        //PONISTAVANJE PRETRAGE
        public void PonistiPretragu()
        {
            etikete.Clear();
            foreach (Etiketa item in Database.getInstance().Tags)
            {
                etikete.Add(item);

            }
            EtiketaFilter.Id = "";
            EtiketaFilter.Color = "";
            //za boju ne znam kako da smenim

        }

        //metoda za osvezavanje tabele etiketa
        public void OsveziTabeluEtiketa()
        {
            etikete.Clear();
            foreach (Etiketa item in Database.getInstance().Tags)
            {
                etikete.Add(item);

            }
        //    Pretraga();
        }

        //poziva se kada hocemo da kreiramo novu etiketu u rezimu prikaza svih etiketa
        public void kreirajNovuEtiketu()
        {
            NovaEtiketa tip = new NovaEtiketa();
            tip.ShowDialog();

            etikete.Clear();
            foreach (Etiketa item in Database.getInstance().Tags)
            {
                etikete.Add(item);

            }
          //  Pretraga();
        }
    }
}
