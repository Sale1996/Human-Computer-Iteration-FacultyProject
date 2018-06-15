using FestivaliAS.Models;
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
    class Serijalizacija
    {
     

      /*  public static void serializeTypes(ObservableCollection<Tip> types)
        {
            String _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tipovi.podaci");

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(_datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, types);
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

        public static void serializeTags(ObservableCollection<Etiketa> tag)
        {
            String _datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "etikete.podaci");

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(_datoteka, FileMode.OpenOrCreate);
                formatter.Serialize(stream, tag);
            }
            catch
            {
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }*/
    }
}