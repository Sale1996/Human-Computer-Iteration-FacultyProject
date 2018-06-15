

namespace FestivaliAS.Models
{
    using HCI_Manifestations.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Media;
    using Xceed.Wpf.Toolkit;

    [Serializable]
    public class Etiketa : IDataErrorInfo, INotifyPropertyChanged
    {
        String id;
        String opis;
        String color;
        [field: NonSerialized]
        Color boja;


      

        public Etiketa()
        {

        }

        public Etiketa(Etiketa etiketa1)
        {
            Id = etiketa1.Id;
            Opis = etiketa1.Opis;
            Color = etiketa1.Color;
            Boja = etiketa1.Boja;
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

        public String Color
        {
            get { return color; }
            set
            {
                if (value != color)
                {
                    color = value;
                    OnPropertyChanged("Color");
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
                    color = boja.ToString();
                    OnPropertyChanged("Color");
                    OnPropertyChanged("Boja");
                }
            }
        }

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
            "Color"
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
                case "Color":
                    error = ValidateColor();
                    break;

            }

            return error;
        }

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

            if (Database.getInstance().SelectedEtiketa == null) //ovo je ubaceno da se ne bi prikazivala ova validacija u izmeni manifestacije
                foreach (Etiketa item in Database.getInstance().Tags)
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

        private string ValidateColor()
        {
            if (String.IsNullOrWhiteSpace(Color))
            {
                return "Polje boje ne može biti prazno!";
            }
            return null;

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
    }
}
