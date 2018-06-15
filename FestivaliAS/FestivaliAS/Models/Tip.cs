using HCI_Manifestations.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FestivaliAS.Models
{
    [Serializable]
    public class Tip : IDataErrorInfo, INotifyPropertyChanged
    {
        String id;
        String name;
        String opis;
        String iconPath;

        public Tip()
        {

        }

        public Tip(Tip tip1)
        {
            Id = tip1.Id;
            Name = tip1.Name;
            Opis = tip1.Opis;
            IconPath = tip1.IconPath;
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
            "IconPath"
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
                case "IconPath":
                    error = ValidateIcon();
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

            if (Database.getInstance().SelectedTip == null) //ovo je ubaceno da se ne bi prikazivala ova validacija u izmeni manifestacije
                foreach (Tip item in Database.getInstance().Types)
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

        private string ValidateIcon()
        {
            if (String.IsNullOrWhiteSpace(IconPath))
            {
                return "Unesi ikonicu tipa!";

            }
            return null;
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
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(v));
            }
        }
    }
}
