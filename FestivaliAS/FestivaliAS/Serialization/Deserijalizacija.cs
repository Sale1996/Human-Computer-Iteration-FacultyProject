using FestivaliAS.Models;
using HCI_Manifestations.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace FestivaliAS.Serialization
{
    class Deserijalizacija
    {
       

        public static void deserializeTypes()
        {
            String _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tipovi.podaci");

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(_datoteka))
            {
                try
                {
                    stream = File.Open(_datoteka, FileMode.Open);
                    Database.getInstance().Types = (ObservableCollection<Tip>)formatter.Deserialize(stream);
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
        }

        public static void deserializeTags()
        {
            String _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "etikete.podaci");

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(_datoteka))
            {
                try
                {
                    stream = File.Open(_datoteka, FileMode.Open);
                    Database.getInstance().Tags = (ObservableCollection<Etiketa>)formatter.Deserialize(stream);
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
        }
    }
}
