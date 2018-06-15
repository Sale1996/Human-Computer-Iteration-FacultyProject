using FestivaliAS.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace HCI_Manifestations.Models
{
    [Serializable]
    public class Database : INotifyPropertyChanged
    {
        #region Attributes
        private static Database instance = null;

        private ObservableCollection<Manifestacija> manifestations;
        public Manifestacija selectedManifestation;

        public Manifestacija SelectedManifestation
        {
            get { return selectedManifestation;  }
            set
            {
                if(value!=selectedManifestation)
                {
                    selectedManifestation = value;
                    OnPropertyChanged("SelectedManifestation");
                }
            }
        }


        public ObservableCollection<Manifestacija> Manifestations
        {
            get { return manifestations; }
            set
            {
                if (value != manifestations)
                {
                    manifestations = value;
                    OnPropertyChanged("Manifestations");
                }
            }
        }

        private ObservableCollection<Tip> types;
        private Tip selectedTip;

        public Tip SelectedTip
        {
            get { return selectedTip; }
            set
            {
                if (value != selectedTip)
                {
                    selectedTip = value;
                    OnPropertyChanged("SelectedTip");
                }
            }
        }


        public ObservableCollection<Tip> Types
        {
            get { return types; }
            set
            {
                if (value != types)
                {
                    types = value;
                    OnPropertyChanged("Types");
                }
            }
        }
        
        private ObservableCollection<Etiketa> tags;
        private Etiketa selectedEtiketa;


        public ObservableCollection<Etiketa> Tags
        {
            get { return tags; }
            set
            {
                if (value != tags)
                {
                    tags = value;
                    OnPropertyChanged("Tags");
                }
            }
        }


        public Etiketa SelectedEtiketa
        {
            get { return selectedEtiketa; }
            set
            {
                if (value != selectedEtiketa)
                {
                    selectedEtiketa = value;
                    OnPropertyChanged("SelectedEtiketa");
                }
            }
        }

        /*
         * ovi atributi sluze za dodavanje tipova i etiketa u novu manifestaciju (ili izmenu manifestacije)
         */
        private bool daLiDodajemoManifestaciju;
        private Tip tipZaManifestaciju;
        private ObservableCollection<Etiketa> etiketeZaManifestaciju;

        public bool DaLiDodajemoManifestaciju
        {
            get { return daLiDodajemoManifestaciju; }
            set
            {
                if (value != daLiDodajemoManifestaciju)
                {
                    daLiDodajemoManifestaciju = value;
                    OnPropertyChanged("DaLiDodajemoManifestaciju");
                }
            }
        }

        public Tip TipZaManifestaciju
        {
            get { return tipZaManifestaciju; }
            set
            {
                if (value != tipZaManifestaciju)
                {
                    tipZaManifestaciju = value;
                    OnPropertyChanged("TipZaManifestaciju");
                }
            }
        }

     

        public ObservableCollection<Etiketa> EtiketeZaManifestaciju
        {
            get { return etiketeZaManifestaciju; }
            set
            {
                if (value != etiketeZaManifestaciju)
                {
                    etiketeZaManifestaciju = value;
                    OnPropertyChanged("EtiketeZaManifestaciju");
                }
            }
        }


        /*
         OVE PROMENLJIVE SLUZE KOD BRISANAJ TIPA I ETIKETE DA NAM NAZNACI KOJE MANIFESTACIJE GA SADRZE
             */
        private ObservableCollection<Manifestacija> manifestacijeKojeSadrzeTip;
        private ObservableCollection<Manifestacija> manifestacijeKojeSadrzeEtiketu;
        private Etiketa etiketaKojaSeBrise;
        private Tip tipKojiSeBrise;

        public ObservableCollection<Manifestacija> ManifestacijeKojeSadrzeTip
        {
            get { return manifestacijeKojeSadrzeTip; }
            set
            {
                if (value != manifestacijeKojeSadrzeTip)
                {
                    manifestacijeKojeSadrzeTip = value;
                    OnPropertyChanged("ManifestacijeKojeSadrzeTip");
                }
            }
        }

        public Tip TipKojiSeBrise
        {
            get { return tipKojiSeBrise; }
            set
            {
                if (value != tipKojiSeBrise)
                {
                    tipKojiSeBrise = value;
                    OnPropertyChanged("TipKojiSeBrise");
                }
            }
        }

        public ObservableCollection<Manifestacija> ManifestacijeKojeSadrzeEtiketu
        {
            get { return manifestacijeKojeSadrzeEtiketu; }
            set
            {
                if (value != manifestacijeKojeSadrzeEtiketu)
                {
                    manifestacijeKojeSadrzeEtiketu = value;
                    OnPropertyChanged("ManifestacijeKojeSadrzeEtiketu");
                }
            }
        }

        public Etiketa EtiketaKojaSeBrise
        {
            get { return etiketaKojaSeBrise; }
            set
            {
                if (value != etiketaKojaSeBrise)
                {
                    etiketaKojaSeBrise = value;
                    OnPropertyChanged("EtiketaKojaSeBrise");
                }
            }
        }

        #endregion

        #region Singleton
        private Database()
        {
            manifestations = new ObservableCollection<Manifestacija>();
            types = new ObservableCollection<Tip>();
            tags = new ObservableCollection<Etiketa>();
            DaLiDodajemoManifestaciju = false;
            etiketeZaManifestaciju = new ObservableCollection<Etiketa>();
            manifestacijeKojeSadrzeTip = new ObservableCollection<Manifestacija>();
            manifestacijeKojeSadrzeEtiketu = new ObservableCollection<Manifestacija>();
        }

       

        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }
        #endregion

        #region Working with database content
      /*  public static void SaveManifestations()
        {
            SerializationService.serializeManifestations(getInstance().manifestations);
        }

        public static void SaveTypes()
        {
            SerializationService.serializeTypes(getInstance().types);
        }

        public static void SaveTags()
        {
            SerializationService.serializeTags(getInstance().tags);
        }*/

        public static void AddManifestation(Manifestacija manifestation)
        {
            getInstance().manifestations.Add(manifestation);
       
          //  SaveManifestations();
        }

        public static void AddTip(Tip type)
        {
            getInstance().types.Add(type);
         //   SaveTypes();
        }

        public static void AddEtiketa(Etiketa tag)
        {
            getInstance().tags.Add(tag);
          //  SaveTags();
        }
        

        public static Manifestacija GetManifestation(string id)
        {
            for (int i = 0; i < getInstance().Manifestations.Count; i++)
            {
                if (getInstance().Manifestations[i].Id.Equals(id))
                {
                    return getInstance().Manifestations[i];
                }
            }
            return null;
        }

        public static Tip GetType(string id)
        {
            for (int i = 0; i < getInstance().Types.Count; i++)
            {
                if (getInstance().Types[i].Id.Equals(id))
                {
                    return getInstance().Types[i];
                }
            }
            return null;
        }

        public static Etiketa GetTag(string id)
        {
            for (int i = 0; i < getInstance().Tags.Count; i++)
            {
                if (getInstance().Tags[i].Id.Equals(id))
                {
                    return getInstance().Tags[i];
                }
            }
            return null;
        }
        

        public static void UpdateManifestation(string oldId, Manifestacija manifestation)
        {
            for (int i = 0; i < getInstance().Manifestations.Count; i++)
            {
                if (oldId.Equals(getInstance().Manifestations[i].Id))
                {
                    getInstance().Manifestations[i] = manifestation;
                 //   SaveManifestations();
                    break;
                }
            }
        }

        public static void UpdateType(string oldId, Tip type)
        {
            for (int i = 0; i < getInstance().Types.Count; i++)
            {
                if (oldId.Equals(getInstance().Types[i].Id))
                {
                    getInstance().Types[i] = type;
                  //  SaveTypes();
                    break;
                }
            }
        }

        public static void UpdateTag(string oldId, Etiketa tag)
        {
            for (int i = 0; i < getInstance().Tags.Count; i++)
            {
                if (oldId.Equals(getInstance().Tags[i].Id))
                {
                    getInstance().Tags[i] = tag;
                 //   SaveTags();
                    break;
                }
            }
        }

        public static void DeleteManifestation(Manifestacija manifestation)
        {
            for (int i = 0; i < getInstance().Manifestations.Count; i++)
            {
                if (manifestation.Id.Equals(getInstance().Manifestations[i].Id))
                {
                    getInstance().Manifestations.RemoveAt(i);
                 //   SaveManifestations();
                    break;
                }
            }
        }

        public static void DeleteType(Tip type)
        {
            for (int i = 0; i < getInstance().Types.Count; i++)
            {
                if (type.Id.Equals(getInstance().Types[i].Id))
                {
                    getInstance().Types.RemoveAt(i);
              //      SaveTypes();
                    break;
                }
            }
        }

        public static void DeleteTag(Etiketa tag)
        {
            for (int i = 0; i < getInstance().Tags.Count; i++)
            {
                if (tag.Id.Equals(getInstance().Tags[i].Id))
                {
                    getInstance().Tags.RemoveAt(i);
                  //  SaveTags();
                    break;
                }
            }
        }

        //ova metoda ce nam sluziti da obrisemo etiketu iz manifestacije iz koje se nalazi!
        public static void DeleteEtiketaIzManifestacije(Etiketa tag) 
        {
            for (int i = 0; i < getInstance().EtiketeZaManifestaciju.Count; i++)
            {
                if (tag.Id.Equals(getInstance().EtiketeZaManifestaciju[i].Id))
                {
                    getInstance().EtiketeZaManifestaciju.RemoveAt(i);
                    //  SaveTags();
                    break;
                }
            }
        }
        #endregion
/*
        #region Loading database
        public static void loadData()
        {
            DeserializationService.deserializeTags();
            DeserializationService.deserializeTypes();
            DeserializationService.deserializeManifestations();
        }
        #endregion */

        #region PropertyChangedNotifier
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}