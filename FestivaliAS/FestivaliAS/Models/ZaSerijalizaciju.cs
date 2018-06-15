using HCI_Manifestations.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FestivaliAS.Models
{
    [Serializable()]

    class ZaSerijalizaciju : ISerializable
    {
         
        private ArrayList manifestations;
        private ArrayList types;
        private ArrayList tags;
        private readonly string _datoteka;


        public ZaSerijalizaciju()
        {
            manifestations = new ArrayList();
            foreach (Manifestacija item in Database.getInstance().Manifestations)
            {
                manifestations.Add(item);
            }
           
            types = new ArrayList();
            foreach (Tip item in Database.getInstance().Types)
            {
                types.Add(item);
            }

            tags = new ArrayList();
            foreach (Etiketa item in Database.getInstance().Tags)
            {
                Color boja1 = new Color();
               
               //OVDE SAMO BOJA NECE DA RADI TJ DA SE SERIJALIZUJE LADNO
                tags.Add(item);
            }

            _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "manifestacije.podaci");


        }

        public ArrayList Manifestations
        {
            get { return manifestations; }
            set
            {
                if (value != manifestations)
                {
                    manifestations = value;
                }
            }
        }

        public ArrayList Types
        {
            get { return types; }
            set
            {
                if (value != types)
                {
                    types = value;
                }
            }
        }
        public ArrayList Tags
        {
            get { return tags; }
            set
            {
                if (value != tags)
                {
                    tags = value;
                }
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Manifestations", Manifestations);
            info.AddValue("Types", Types);
            info.AddValue("Tags", Tags);
        }

        public ZaSerijalizaciju(SerializationInfo info, StreamingContext context)
        {
            Manifestations = (ArrayList)info.GetValue("Manifestations", typeof(ArrayList));
            Types = (ArrayList)info.GetValue("Types", typeof(ArrayList));
           Tags = (ArrayList)info.GetValue("Tags", typeof(ArrayList));
        }

        public void serializeManifestations()
        {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;
            ZaSerijalizaciju memorisi = new ZaSerijalizaciju();
            try
            {
                stream = File.Open(_datoteka, FileMode.Create);
                formatter.Serialize(stream, memorisi);
            }
            catch
            {
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        public void deserializeManifestations()
        {
            String _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "manifestacije.podaci");


            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = null;

            if (File.Exists(_datoteka))
            {
                try
                {
                    stream = File.Open(_datoteka, FileMode.Open);
                    var data = (ZaSerijalizaciju)formatter.Deserialize(stream);
                    foreach (Manifestacija item in data.Manifestations)
                    {
                        item.FixIconPath();
                        Database.AddManifestation(item);
                    }

                   foreach (Tip item in data.Types)
                    {
                        item.FixIconPath();
                        Database.AddTip(item);
                    }

                    foreach (Etiketa item in data.Tags)
                    {
                        

                        Database.AddEtiketa(item);
                    }
                    
            

                }
                catch
                {
                }
                finally
                {
                    if (stream != null)
                        stream.Close();
                }

            }
        }
    }
   /* [Serializable] //ovo oznacava da se klasa moze serijalizovati, nista drugo ne treba, posto joj se atributi mogu serijalizovati
    class Osoba
    {
        public Guid ID
        {
            get;
            set;
        }
        public string Ime
        {
            get;
            set;
        }

        public string Prezime
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }

    class ZaSerijalizaciju
    {
        private Dictionary<Guid, Osoba> _r = new Dictionary<Guid, Osoba>();
        private readonly string _datoteka;

        public ZaSerijalizaciju()
        {
            _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "repozitorijum.podaci");
            UcitajDatoteku();
        }

        public void Dodaj(Osoba o)
        {
            if (o.ID == Guid.Empty)
                o.ID = Guid.NewGuid();
            if (!_r.ContainsKey(o.ID))
                _r.Add(o.ID, o);
            MemorisiDatoteku();
        }

        public void Obrisi(Osoba o)
        {
            _r.Remove(o.ID);
            MemorisiDatoteku();
        }

        public Osoba this[Guid g]
        {
            get
            {
                return _r[g];
            }
            set
            {
                _r[g] = value;
            }
        }

        public void MemorisiDatoteku()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;
            string ime = "OVO ZA CUVANJE";

            try
            {
                stream = File.Open(_datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, ime);
            }
            catch
            {
                // 
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }

        }

        public void UcitajDatoteku()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;
            string ime = null ;

            if (File.Exists(_datoteka))
            {
                try
                {
                    stream = File.Open(_datoteka, FileMode.Open);
                    ime = (string)formatter.Deserialize(stream);
                }
                catch
                {
                    // 
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n NASAO JE :" + ime + "\n\n\n\n\n\n\n\n\n\n\n");
            }
            else
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\nNIJE NISTA NASAO\n\n\n\n\n\n\n");
            }

        public Dictionary<Guid, Osoba> getAll()
        {
            return _r;
        }
    }*/
}
