using FestivaliAS.Models;
using FestivaliAS.Serialization;
using HCI_Manifestations.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FestivaliAS.ViewModels
{
    class GlavniProzorViewModel
    {

        ObservableCollection<Manifestacija> manifestacije;

        public GlavniProzorViewModel()
        {
            manifestacije = Database.getInstance().Manifestations;
        }

        public static void sacuvaj()
        {
            ZaSerijalizaciju cuvaj = new ZaSerijalizaciju();

            cuvaj.serializeManifestations();
          //  Serijalizacija.serializeTags(Database.getInstance().Tags);
          //  Serijalizacija.serializeTypes(Database.getInstance().Types);

        }

        public static void ucitajFajlove()
        {
            ZaSerijalizaciju cuvaj = new ZaSerijalizaciju();

            // Deserijalizacija.deserializeTags();
            //  Deserijalizacija.deserializeTypes();
            cuvaj.deserializeManifestations();
        }



        public ObservableCollection<Manifestacija> Manifestacije
        {
            get
            {
                return manifestacije;
            }

        }

    }
}
