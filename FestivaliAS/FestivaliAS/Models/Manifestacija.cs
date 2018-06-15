
namespace FestivaliAS.Models
{
    using HCI_Manifestations.Models;
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    [Serializable]
    public class Manifestacija : IDataErrorInfo, INotifyPropertyChanged
    {
        String id;
        String name;
        String kategorijaCena;
        String mestoOdrzavanja;
        String opis;
        String statusAlkohola;
        Boolean hendikepiraniDozvoljeni;
        Boolean hendikepiraniNijeDozvoljeni;
        Boolean pusenjeDozvoljeno;
        Boolean pusenjeNijeDozvoljeno;
        String ocekivanaPublika;
        DateTime date;
        String datum;
        String iconPath;
        Tip tip;
        ObservableCollection<Etiketa> etikete;
        private int x;
        private int y;

 



        public Manifestacija()
        {
            date = DateTime.Today;
            etikete = new ObservableCollection<Etiketa>();
        
            this.x = -1;
            this.y = -1;
        }
        //ovaj konstruktor ce se koristiti kod editovanja
        public Manifestacija(Manifestacija manifestacija1)
        {
            Id = manifestacija1.Id;
            Name = manifestacija1.Name;
            KategorijaCena = manifestacija1.KategorijaCena;
            MestoOdrzavanja = manifestacija1.MestoOdrzavanja;
            Opis = manifestacija1.Opis;
            StatusAlkohola = manifestacija1.StatusAlkohola;
            HendikepiraniDozvoljeni = manifestacija1.HendikepiraniDozvoljeni;
            HendikepiraniNisuDozvoljeni = manifestacija1.HendikepiraniNisuDozvoljeni;
            PusenjeDozvoljeno = manifestacija1.PusenjeDozvoljeno;
            PusenjeNijeDozvoljeno = manifestacija1.PusenjeNijeDozvoljeno;
            OcekivanaPublika = manifestacija1.OcekivanaPublika;
            Date = manifestacija1.Date;
            IconPath = manifestacija1.IconPath;
            Tip = manifestacija1.Tip;
            Etikete = manifestacija1.Etikete;
            this.x = manifestacija1.X;
            this.y = manifestacija1.Y;
        }

        public ObservableCollection<Etiketa> Etikete
        {
            get { return etikete; }
            set
            {
                if (value != etikete)
                {
                    etikete = value;
                    OnPropertyChanged("Etikete");
                }
            }
        }




        public String IconPath
        {
            get { return iconPath; }
            set
            {
                if (value != iconPath)
                {
                    iconPath = value;
                    string newPath = Directory.GetCurrentDirectory() + "\\" + @iconPath.Split('\\').Last();
                    if (!File.Exists(newPath) && newPath != null && !string.IsNullOrEmpty(newPath) && !string.IsNullOrWhiteSpace(newPath))
                    {
                        File.Copy(@iconPath, @newPath, true);
                    }
                    iconPath = newPath;
                    OnPropertyChanged("IconPath");
                    
                }
            }
        }


        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value != date)
                {
                    date = value;
                    Datum = "namesteno";
                    OnPropertyChanged("Datum");
                    OnPropertyChanged("Date");
                }
            }
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

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
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
                OnPropertyChanged("Tip");
            }
        }

        public String KategorijaCena
        {
            get
            {
                return kategorijaCena;
            }
            set
            {
                kategorijaCena = value;
                OnPropertyChanged("KategorijaCena");
            }
        }

        public String MestoOdrzavanja
        {
            get
            {
                return mestoOdrzavanja;
            }
            set
            {
                mestoOdrzavanja = value;
                OnPropertyChanged("MestoOdrzavanja");
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

        public String Datum
        {
            get
            {
                return datum;
            }
            set
            {
                datum = value;
                OnPropertyChanged("Datum");
            }
        }

        public String StatusAlkohola
        {
            get
            {
                return statusAlkohola;
            }
            set
            {
                statusAlkohola = value;
                OnPropertyChanged("StatusAlkohola");
            }
        }

        public Boolean HendikepiraniDozvoljeni
        {
            get
            {
                return hendikepiraniDozvoljeni;
            }
            set
            {
                hendikepiraniDozvoljeni = value;
                OnPropertyChanged("HendikepiraniDozvoljeni");
            }
        }

        public Boolean HendikepiraniNisuDozvoljeni
        {
            get
            {
                return hendikepiraniNijeDozvoljeni;
            }
            set
            {
                hendikepiraniNijeDozvoljeni = value;
                OnPropertyChanged("HendikepiraniNisuDozvoljeni");
            }
        }

        public Boolean PusenjeDozvoljeno
        {
            get
            {
                return pusenjeDozvoljeno;
            }
            set
            {
                pusenjeDozvoljeno = value;
                OnPropertyChanged("PusenjeDozvoljeno");
            }
        }

        public Boolean PusenjeNijeDozvoljeno
        {
            get
            {
                return pusenjeNijeDozvoljeno;
            }
            set
            {
                pusenjeNijeDozvoljeno = value;
                OnPropertyChanged("PusenjeNijeDozvoljeno");
            }
        }

        public String OcekivanaPublika
        {
            get
            {
                return ocekivanaPublika;
            }
            set
            {
                ocekivanaPublika = value;
                OnPropertyChanged("OcekivanaPublika");
            }
        }

        public int X
        {
            get { return x; }
            set
            {
                if (value != x)
                {
                    x = value;
                    OnPropertyChanged("X");
                    Console.WriteLine("\n\n\n\n\n\n\n VREDNOST SE PROMENILA!! \n\n\n\n\n\n\n\n");
                }
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value != y)
                {
                    y = value;
                    OnPropertyChanged("Y");
                }
            }
        }


        //VALIDACIJA DRUZE
        string IDataErrorInfo.Error
        {
            get
            {
                return null;
            }
        }

        string IDataErrorInfo.this[string property]
        {
            get
            {
                return GetValidationError(property);
            }
        }

        static readonly string[] ValidatedProperties =
        {
            "Id",
            "Name",
            "KategorijaCena",
            "MestoOdrzavanja",
            "StatusAlkohola",
            "Pusenje",
            "HendikepiraniDozvoljeni",
            "OcekivanaPublika",
            "Tip",
            "Datum",
            "PusenjeDozvoljeno"
        };

        public bool IsValid
        {
            get
            {
                foreach (string property in ValidatedProperties)
                    if (GetValidationError(property) != null)
                        return false;
                return true;
            }
        }


        string GetValidationError(String propertyName)
        {
            string error = null; 

            switch (propertyName)
            {
                case "Id":
                    error = ValidateId();
                    break;
                case "Name":
                    error = ValidateName();
                    break;
                case "KategorijaCena":
                    error = ValidateKategorijaCena();
                    break;
                case "MestoOdrzavanja":
                    error = ValidateMestoOdrzavanja();
                    break;
                
                case "StatusAlkohola":
                    error = ValidateStatusAlkohola();
                    break;
                case "Pusenje":
                    error = ValidatePusenje();
                    break;
                case "HendikepiraniDozvoljeni":
                    error = ValidateHendikepirani();
                    break;
                case "PusenjeDozvoljeno":
                    error = ValidatePusenje();
                    break;
                case "OcekivanaPublika":
                    error = ValidateOcekivanaPublika();
                    break;
                case "Tip":
                    error = ValidateTipManifestacije();
                    break;
                case "Datum":
                    error = ValidateDateManifestacije();
                    break;

            }

            return error;
        }

        //konkretna provera da li su polja dobra

        private string ValidateId()
        {
            if (String.IsNullOrWhiteSpace(Id))
            {
                return "Id polje ne može biti prazno!";
            }
            else if (Id.Length > 15)
            {
                return "Maksimalna duzina ID je 15!";
            }
            if(Database.getInstance().SelectedManifestation ==null) //ovo je ubaceno da se ne bi prikazivala ova validacija u izmeni manifestacije
                foreach (Manifestacija item in Database.getInstance().Manifestations)
                {
                    if (item.Id == Id)
                        return "Unesena identifikaciona oznaka već postoji!";
                }

            // \w oznacava sve brojeve i slova , kao i donju crtu i ispitujemo da li odgovara ovom regularnom izrazu!
            string pattern = @"^[a-zA-Z0-9_]+$";
            Regex rgx = new Regex(pattern);
            if (!rgx.IsMatch(Id))
                return "Id oznaka mora biti ljudski čitljiva!";

            return null;
        }

        private string ValidateName()
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                return "Polje imena ne može biti prazno!";
            }
            else if (Name.Length > 15)
            {
                return "Maksimalna duzina imena je 15!";
            }
            return null;
        }

        private string ValidateKategorijaCena()
        {
            if (String.IsNullOrWhiteSpace(KategorijaCena))
            {
                return "Polje Kategorije cene ne može biti prazno!";
            }
           
            return null;
        }

        private string ValidateMestoOdrzavanja()
        {
            if (String.IsNullOrWhiteSpace(MestoOdrzavanja))
            {
                return "Polje mesta održavanja ne može biti prazno!";
            }

            return null;
        }

        private string ValidateStatusAlkohola()
        {
            if (String.IsNullOrWhiteSpace(StatusAlkohola))
            {
                return "Polje status alkohola ne može biti prazno!";
            }

            return null;
        }


        private string ValidatePusenje()
        {
            if (PusenjeDozvoljeno == false && PusenjeNijeDozvoljeno==false)
            {
                return "Selektuj da li je pušenje dozvoljeno!";
            }

            return null;
        }

        private string ValidateHendikepirani()
        {
            if (HendikepiraniDozvoljeni == false && HendikepiraniNisuDozvoljeni == false)
            {
                return "Selektuj da li je dostupno za hendikepirane!";
            }

            return null;
        }

        private string ValidateTipManifestacije()
        {
            if(Database.getInstance().TipZaManifestaciju == null)
            {
                return "Ubaci tip manifestacije, zatim osveži!";
            }
            
            return null;
        }

        private string ValidateDateManifestacije()
        {
            if (String.IsNullOrWhiteSpace(Datum))
            {
                return "Ubaci vreme početka manifestacije!";
            }
            return null;
        }

        private string ValidateOcekivanaPublika()
        {
            if (String.IsNullOrWhiteSpace(OcekivanaPublika))
            {
                return "Polje očekivane publike ne sme biti prazno!";
            }
            else if (!IsDigitsOnly(OcekivanaPublika))
            {
                return "Samo celobrojni decimalni brojevi su dozvoljeni!";

            }
            return null;
        }


       public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }



        public void FixIconPath()
        {
            var ip = IconPath;
            string newPath = Directory.GetCurrentDirectory() + "\\" + @ip.Split('\\').Last();
            if (!File.Exists(newPath) && newPath != null && !string.IsNullOrEmpty(newPath) && !string.IsNullOrWhiteSpace(newPath))
            {
                File.Copy(@iconPath, @newPath, true);
            }
            iconPath = newPath;
            OnPropertyChanged("IconPath");
        }



        //ovo je klasika kada moras property changed da postavis 
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string v)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(v));
            }
        }
    }
}
