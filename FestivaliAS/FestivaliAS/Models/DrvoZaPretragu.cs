using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivaliAS.Models
{
    public class DrvoZaPretragu<T> : IEnumerable<DrvoZaPretragu<string>>
    {

        public string Data { get; set; }
        public List<string> Cvorovi { get; set; }
        public List<string> zaDecu { get; set; }
        public Object Parent { get; set; } //ovo koristimo za cvorove 1 nivoa

        public ICollection<DrvoZaPretragu<string>> Children { get; set; }
        int kolikoOtvorenihZagrada = 0;
        int pocniUbacivanjeOd = 0;
        bool daLiJeNaKraju = false;

        public DrvoZaPretragu(string data)
        {
            this.Data = data;
            this.Children = new LinkedList<DrvoZaPretragu<string>>();
            this.Cvorovi = new List<string>();
            this.zaDecu = new List<string>();



            //formiramo stablo
            for (int i = 0; i < Data.ToString().Length; i++)
            {
                if (Data.ToString()[i] == '(')
                {   //ako je otvorena zagrada povecaj broj
                    //ispitujemo i ako je prva zagrada u nizu onda stavi da pocne ubacivanje zan ovi cvor od te vrednosti
                    kolikoOtvorenihZagrada++;
                    if (kolikoOtvorenihZagrada == 1)
                        pocniUbacivanjeOd = i;
                }
                else if (Data.ToString()[i] == ')')
                {
                    kolikoOtvorenihZagrada--;
                    //kada zatvorio jednu zagradu ok je
                    if (kolikoOtvorenihZagrada < 0)
                        return; //ako je nacinjena greska u ulazu samo izadjemo i prekinemo pretragu!
                    if (kolikoOtvorenihZagrada == 0)
                    {
                        //ako je ovo nula onda smo dosli do neke celine i mozemo da ispitamo da li posle toga se nalazi ili nista ili AND ili OR 

                        //prvo cemo da izvucemo string koi predstavlja ono sto je ispred zatvorene zagrade i skinemo sve razmake
                        string ostatakStringa = Data.ToString().Substring(i + 1);
                        ostatakStringa = ostatakStringa.Replace(" ", string.Empty);
                        if (ostatakStringa.StartsWith("AND") || ostatakStringa.StartsWith("OR") || ostatakStringa == "")
                        {
                            //ako je sve uredu i pocinje tako onda samo ubacimo taj string u listu deca drveta
                            string noviZaDecu = Data.ToString().Substring(pocniUbacivanjeOd, i - pocniUbacivanjeOd);
                            noviZaDecu = noviZaDecu.Substring(1);
                            this.zaDecu.Add(noviZaDecu);
                        }//sada kada  znamo da je AND i OR tu negde mi cemo to da ubacimo ! jer necemo da dozvolimo da se ubacuje AND i OR koji nisu na najvisem nivou!
                        //for petlja je ubacena jer smo dozvolili koliko god razmaka da bude izmedju OR AND i tako toga!
                        for (int i1 = i; i1 < Data.ToString().Length; i1++)
                        {
                            if (Data.ToString()[i1] == 'A')
                            {
                                //ovo je zastita ako pokusamo u najnizem nivou bez zagrada da ubacimo i AND i OR sto nije validno
                                if (!this.Cvorovi.Contains("AND") && this.Cvorovi.Count > 0)
                                    return;
                                else
                                {
                                    this.Cvorovi.Add("AND"); //ovde smo ubacili logicki izraz i povecali iterator za 2 kao da smo ga pokupili i nastavljamo dalje!
                                    i = i1 + 2;
                                    i1 = Data.ToString().Length; //ovo postavljamio kako bi smo izasli iz unutrasnje petlje umesto break!
                                }
                            }
                            else if (Data.ToString()[i1] == 'O')
                            {
                                //ovo je zastita ako pokusamo u najnizem nivou bez zagrada da ubacimo i AND i OR sto nije validno
                                if (!this.Cvorovi.Contains("OR") && this.Cvorovi.Count > 0)
                                    return;
                                else
                                {
                                    this.Cvorovi.Add("OR"); //ovde smo ubacili logicki izraz i povecali iterator za 2 kao da smo ga pokupili i nastavljamo dalje!
                                    i = i1 + 2;
                                    i1 = Data.ToString().Length; //ovo postavljamio kako bi smo izasli iz unutrasnje petlje umesto break!
                                }
                            }
                        }
                    }
                }//sada cemo da proverimo situaciju ako je dosao do AND ili OR i DA NIJE BILO ZAGRADA IZMEDJU, znaci DA SMO NA NAJNIZEM NIVOU !!

                else if (Data.ToString()[i] == 'A')
                {
                    if (kolikoOtvorenihZagrada == 0)
                    {
                        //prvo moramo da proverimo da li se bas radi o promenljivoj AND
                        string ispitivanje = Data.ToString().Substring(i, 4);
                        //ako je string == sa "AND " onda je super to je to
                        if (ispitivanje != "AND ")
                        {
                            //al ako nije samo izadji
                            return;
                        }
                        else if (!this.Cvorovi.Contains("AND") && this.Cvorovi.Count > 0) //da ne moze ici AND nesto OR nesto ne moze tako
                            return;
                        else
                        {
                            string noviZaDecu = Data.ToString().Substring(pocniUbacivanjeOd, (i - 1) - pocniUbacivanjeOd);
                            this.zaDecu.Add(noviZaDecu);
                            //dodajemo izraz levo od njega u cvorove !
                            //sada dodajemo ADD i pomeramo pokazivac da moze dalje da trazi ko covek
                            this.Cvorovi.Add("AND");
                            i += 3;
                            pocniUbacivanjeOd = i; //ako postoji jos nesto posle da ubaci tamo posle i-tog stepena

                            daLiJeNaKraju = true; // ovo radimo iz razloga ako smo dosli do kraja i da sa desne strane ima stringa samo i ako smo dosli do kraja da znamo da je to sve validno i da prikupimo string
                        }
                    }
                }//SADA SVE ISTO SAMO ZA OR LOGICKI IZRAZ!

                else if (Data.ToString()[i] == 'O')
                {
                    if (kolikoOtvorenihZagrada == 0)
                    {
                        //prvo moramo da proverimo da li se bas radi o promenljivoj OR
                        string ispitivanje = Data.ToString().Substring(i, 3);
                        //ako je string == sa "AND " onda je super to je to
                        if (ispitivanje != "OR ")
                        {
                            //al ako nije samo izadji
                            return;
                        }
                        else if (!this.Cvorovi.Contains("OR") && this.Cvorovi.Count > 0) //da ne moze ici AND nesto OR nesto ne moze tako
                            return;
                        else
                        {
                            string noviZaDecu = Data.ToString().Substring(pocniUbacivanjeOd, (i - 1) - pocniUbacivanjeOd);
                            this.zaDecu.Add(noviZaDecu);
                            //dodajemo izraz levo od njega u cvorove !
                            //sada dodajemo ADD i pomeramo pokazivac da moze dalje da trazi ko covek
                            this.Cvorovi.Add("OR");
                            i += 2;
                            pocniUbacivanjeOd = i; //ako postoji jos nesto posle da ubaci tamo posle i-tog stepena
                            daLiJeNaKraju = true; // ovo radimo iz razloga ako smo dosli do kraja i da sa desne strane ima stringa samo i ako smo dosli do kraja da znamo da je to sve validno i da prikupimo string
                            //jer nismo nigde naveli sta ako posle OR-a nema jos jedan or tipa hee juju haha omg 
                        }
                    }
                }
                else if (i == Data.ToString().Length - 1) {
                    if (daLiJeNaKraju) {
                        string noviZaDecu = Data.ToString().Substring(pocniUbacivanjeOd);
                        this.zaDecu.Add(noviZaDecu);

                    }
                }

            }
            //sada kada imamo sve spremno moramo da pokrenemo rekurziju unutra u stablo tako sto cemo one stringove deci proslediti
            foreach (string item in this.zaDecu)
            {
                DrvoZaPretragu<string> dete= this.AddChild(item);
                
            }
        }
        //PRETRAGA ZA TIP
        public bool PretragaTip(Tip tip) {
            //ako ima decu onda idemo rekurzivni poziv, ali ako nema onda je to dno i tu onda filtriramo string i pravimo boolean izraz!
            bool daLiPodrzava = false;

            if (Children.Count != 0)
            {
                int i = 0;
                if (Cvorovi.Count != 0) //ovo moramo da proverimo iz razloga kada ostane upit (nesto="nesto AND nesto="nest2") zbog zagrada moze da pobrka sve!!
                {
                    //ovo u foreach ce se rekurzivno stalno pozivati dok ne dodjemo do skroz dubine!
                    foreach (string item in Cvorovi)
                    {
                        if (++i == 1)
                        {
                            //ovo je kao pocetak pa ako imamo vise izraza ovo cemo uzimati 2 izraza pa onda treci dodajemo na to pa 4. dodajemo na sve ono pre i tako.. al ovo je prvi
                            if (item == "AND")
                            {
                                daLiPodrzava = Children.ElementAt(i - 1).PretragaTip(tip) && Children.ElementAt(i).PretragaTip(tip); //ako je tip cvora AND onda samo postavi && izmedju 2 bool tipa
                            }
                            else if (item == "OR")
                            {
                                daLiPodrzava = (Children.ElementAt(i - 1).PretragaTip(tip) || Children.ElementAt(i).PretragaTip(tip)); //ovo je suprtono za ili 
                            }

                        }
                        else
                        {
                            if (item == "OR") //ovo ako nije prvi element onda svaki sledeci samo nadodavaj!!
                            {
                                daLiPodrzava = daLiPodrzava && Children.ElementAt(i).PretragaTip(tip);
                            }
                            else
                            {
                                daLiPodrzava = daLiPodrzava || Children.ElementAt(i).PretragaTip(tip);
                            }
                        }
                    }
                }
                else
                {
                    daLiPodrzava = Children.ElementAt(0).PretragaTip(tip);     
                }

            }
            else {
                //okej dosli smo do dna sada onaj string trebamo da isparsiramo ovde imamo opciju ime="" i id="" ! 
                String[] delovi = Data.Split('=');
                //ovde ispitujemo da li je korisnik lepo uneo upit pa ako jeste i ako pocinje sa id onda poredimo id sa onim uslovom ako je name isto tako i to vracamo nazad!!
                if (delovi.Length != 2)
                    return false;
                else if (!delovi[1].StartsWith("\""))
                    return false;

                delovi[0] = delovi[0].Replace(" ", string.Empty);
                if (delovi[0] == "id")
                {
                    string uslov = delovi[1].Replace(" ",string.Empty);
                    uslov = uslov.Replace("\"", string.Empty);
                    uslov = uslov.ToLower();
                    string odTipa = tip.Id.Replace(" ", string.Empty);
                    odTipa = odTipa.ToLower();
                    if (odTipa == uslov)
                        return true;
                    else
                        return false;
                }
                else if (delovi[0] == "id!") //ovo oznacava da se trazi razlicito od unosa !!
                {
                    string uslov = delovi[1].Replace(" ", string.Empty);
                    uslov = uslov.Replace("\"", string.Empty);
                    uslov = uslov.ToLower();

                    string odTipa = tip.Id.Replace(" ", string.Empty);
                    odTipa = odTipa.ToLower();

                    if (odTipa == uslov)
                        return false;
                    else
                        return true;
                }
                else if (delovi[0] == "ime") {
                    string uslov = delovi[1].Replace(" ", string.Empty);
                    uslov = uslov.Replace("\"", string.Empty);
                    uslov = uslov.ToLower();

                    string odTipa = tip.Name.Replace(" ", string.Empty);
                    odTipa = odTipa.ToLower();
                    if (odTipa == uslov)
                        return true;
                    else
                        return false;
                }
                else if (delovi[0] == "ime!") //ovo oznacava da se trazi razlicito od unosa !!
                {
                    string uslov = delovi[1].Replace(" ", string.Empty);
                    uslov = uslov.Replace("\"", string.Empty);
                    uslov = uslov.ToLower();
                    string odTipa = tip.Name.Replace(" ", string.Empty);
                    odTipa = odTipa.ToLower();

                    if (odTipa == uslov)
                        return false;
                    else
                        return true;
                }
                else
                {
                    return false;
                }
            }

            return daLiPodrzava;

        }


        //PRETRAGA ZA ETIKETU

        public bool PretragaEtiketa(Etiketa etiketa)
        {
            //ako ima decu onda idemo rekurzivni poziv, ali ako nema onda je to dno i tu onda filtriramo string i pravimo boolean izraz!
            bool daLiPodrzava = false;

            if (Children.Count != 0)
            {
                int i = 0;
                if (Cvorovi.Count != 0) //ovo moramo da proverimo iz razloga kada ostane upit (nesto="nesto AND nesto="nest2") zbog zagrada moze da pobrka sve!!
                {
                    //ovo u foreach ce se rekurzivno stalno pozivati dok ne dodjemo do skroz dubine!
                    foreach (string item in Cvorovi)
                    {
                        if (++i == 1)
                        {
                            //ovo je kao pocetak pa ako imamo vise izraza ovo cemo uzimati 2 izraza pa onda treci dodajemo na to pa 4. dodajemo na sve ono pre i tako.. al ovo je prvi
                            if (item == "AND")
                            {
                                daLiPodrzava = Children.ElementAt(i - 1).PretragaEtiketa(etiketa) && Children.ElementAt(i).PretragaEtiketa(etiketa); //ako je tip cvora AND onda samo postavi && izmedju 2 bool tipa
                            }
                            else if (item == "OR")
                            {
                                daLiPodrzava = (Children.ElementAt(i - 1).PretragaEtiketa(etiketa) || Children.ElementAt(i).PretragaEtiketa(etiketa)); //ovo je suprtono za ili 
                            }

                        }
                        else
                        {
                            if (item == "OR") //ovo ako nije prvi element onda svaki sledeci samo nadodavaj!!
                            {
                                daLiPodrzava = daLiPodrzava && Children.ElementAt(i).PretragaEtiketa(etiketa);
                            }
                            else
                            {
                                daLiPodrzava = daLiPodrzava || Children.ElementAt(i).PretragaEtiketa(etiketa);
                            }
                        }
                    }
                }
                else
                {
                    daLiPodrzava = Children.ElementAt(0).PretragaEtiketa(etiketa);
                }

            }
            else
            {
                //okej dosli smo do dna sada onaj string trebamo da isparsiramo ovde imamo opciju ime="" i id="" ! 
                String[] delovi = Data.Split('=');
                //ovde ispitujemo da li je korisnik lepo uneo upit pa ako jeste i ako pocinje sa id onda poredimo id sa onim uslovom ako je name isto tako i to vracamo nazad!!
                if (delovi.Length != 2)
                    return false;
                else if (!delovi[1].StartsWith("\""))
                    return false;

                delovi[0] = delovi[0].Replace(" ", string.Empty);
                if (delovi[0] == "id")
                {
                    string uslov = delovi[1].Replace(" ", string.Empty);
                    uslov = uslov.Replace("\"", string.Empty);
                    uslov = uslov.ToLower();
                    string odTipa = etiketa.Id.Replace(" ", string.Empty);
                    odTipa = odTipa.ToLower();

                    if (odTipa == uslov)
                        return true;
                    else
                        return false;
                }
                else if (delovi[0] == "id!") //u slucaju trazenja etiketa koje nisu ovaj id
                {
                    string uslov = delovi[1].Replace(" ", string.Empty);
                    uslov = uslov.Replace("\"", string.Empty);
                    uslov = uslov.ToLower();
                    string odTipa = etiketa.Id.Replace(" ", string.Empty);
                    odTipa = odTipa.ToLower();

                    if (odTipa == uslov)
                        return false;
                    else
                        return true;
                }
                else if (delovi[0] == "boja")
                {
                    string uslov = delovi[1].Replace(" ", string.Empty);
                    uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                    uslov = uslov.ToLower();
                    string odTipa = etiketa.Color.Replace(" ", string.Empty);
                    odTipa = odTipa.ToLower();

                    if (odTipa == uslov)
                        return true;
                    else
                        return false;
                }
                else if (delovi[0] == "boja!") // u slucaju obrnutog trazenaj
                {
                    string uslov = delovi[1].Replace(" ", string.Empty);
                    uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                    uslov = uslov.ToLower();
                    string odTipa = etiketa.Color.Replace(" ", string.Empty);
                    odTipa = odTipa.ToLower();

                    if (odTipa == uslov)
                        return false;
                    else
                        return true;
                }
                else
                {
                    return false;
                }
            }

            return daLiPodrzava;

        }

        //PRETRAGA ZA MANIFETACIJU !!!

        public bool PretragaManifestacija1(Manifestacija manifestacija)
        {
            //ako ima decu onda idemo rekurzivni poziv, ali ako nema onda je to dno i tu onda filtriramo string i pravimo boolean izraz!
            bool daLiPodrzava = false;

            if (Children.Count != 0)
            {
                int i = 0;
                if (Cvorovi.Count != 0) //ovo moramo da proverimo iz razloga kada ostane upit (nesto="nesto AND nesto="nest2") zbog zagrada moze da pobrka sve!!
                {
                    //ovo u foreach ce se rekurzivno stalno pozivati dok ne dodjemo do skroz dubine!
                    foreach (string item in Cvorovi)
                    {
                        if (++i == 1)
                        {
                            //ovo je kao pocetak pa ako imamo vise izraza ovo cemo uzimati 2 izraza pa onda treci dodajemo na to pa 4. dodajemo na sve ono pre i tako.. al ovo je prvi
                            if (item == "AND")
                            {
                                daLiPodrzava = Children.ElementAt(i - 1).PretragaManifestacija1(manifestacija) && Children.ElementAt(i).PretragaManifestacija1(manifestacija); //ako je tip cvora AND onda samo postavi && izmedju 2 bool tipa
                            }
                            else if (item == "OR")
                            {
                                daLiPodrzava = (Children.ElementAt(i - 1).PretragaManifestacija1(manifestacija) || Children.ElementAt(i).PretragaManifestacija1(manifestacija)); //ovo je suprtono za ili 
                            }

                        }
                        else
                        {
                            if (item == "OR") //ovo ako nije prvi element onda svaki sledeci samo nadodavaj!!
                            {
                                daLiPodrzava = daLiPodrzava && Children.ElementAt(i).PretragaManifestacija1(manifestacija);
                            }
                            else
                            {
                                daLiPodrzava = daLiPodrzava || Children.ElementAt(i).PretragaManifestacija1(manifestacija);
                            }
                        }
                    }
                }
                else
                {
                    daLiPodrzava = Children.ElementAt(0).PretragaManifestacija1(manifestacija); //y slucaju samo zagrade da ima onda uzimamo dete koje je zapravo bez zagrade
                }

            }
            else
            {
                /*
                 IMAMO 3 TIPA POREDJENJA A TO SU JEDNAKO (=) , MANJE (<) i VECE (>) I TO CEMO SVAKO POSEBNO PROVERITI POCEVSI OD =
                 */
                //okej dosli smo do dna sada onaj string trebamo da isparsiramo ovde imamo opciju ime="" i id="" ! 
                if (Data.Contains("<="))
                {
                    String[] delovi = Data.Split('<');
                    //ovde ispitujemo da li je korisnik lepo uneo upit pa ako jeste i ako pocinje sa id onda poredimo id sa onim uslovom ako je name isto tako i to vracamo nazad!!
                    if (delovi.Length != 2)
                        return false;
                    else if (!delovi[1].StartsWith("=\""))
                        return false;

                    delovi[0] = delovi[0].Replace(" ", string.Empty);
                    if (delovi[0] == "publika")
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("=", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        if (IsDigitsOnly(uslov))
                        { //ako je samo od brojeva sastavljen onda mozemo da poredimo
                            if (int.Parse(manifestacija.OcekivanaPublika) <= int.Parse(uslov))
                                return true;
                            else
                                return false;
                        }
                        else
                            return false; // ne sastoji se od cifara
                    }
                    else if (delovi[0] == "datum")
                    {
                        //izvlacimo vreme koje je uneo i proveravamo da li je to to !
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        uslov = uslov.Replace("=", string.Empty);
                        String[] datum = uslov.Split('-');
                        if (datum.Length != 3)
                        {
                            return false;
                        }
                        DateTime datumFilter = new DateTime();
                        if (int.Parse(datum[2]) > 31 || int.Parse(datum[2]) < 1 || int.Parse(datum[1]) < 1 || int.Parse(datum[1]) > 12 || int.Parse(datum[0]) < 1) // ako je nepravilno uneo datum! MESEC/DAN/GODINA
                        {
                            return false;
                        }
                        datumFilter = Convert.ToDateTime(uslov);

                        int DaLiJeRanijeIliTajDan = DateTime.Compare(manifestacija.Date, datumFilter);
                        if (DaLiJeRanijeIliTajDan <= 0) // ako je ovaj datum ranije od postavljenog datuma onda ce ovo vratiti vrednost ili 0 ili <0 (tj nula ako je to isti dan, sto ovde dozvoljavamo)
                            return true;
                        else
                            return false;

                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Data.Contains(">="))
                {
                    String[] delovi = Data.Split('>');
                    //ovde ispitujemo da li je korisnik lepo uneo upit pa ako jeste i ako pocinje sa id onda poredimo id sa onim uslovom ako je name isto tako i to vracamo nazad!!
                    if (delovi.Length != 2)
                        return false;
                    else if (!delovi[1].StartsWith("=\""))
                        return false;

                    delovi[0] = delovi[0].Replace(" ", string.Empty);
                    if (delovi[0] == "publika")
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("=", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        if (IsDigitsOnly(uslov))
                        { //ako je samo od brojeva sastavljen onda mozemo da poredimo
                            if (int.Parse(manifestacija.OcekivanaPublika) >= int.Parse(uslov))
                                return true;
                            else
                                return false;
                        }
                        else
                            return false; // ne sastoji se od cifara
                    }
                    else if (delovi[0] == "datum")
                    {
                        //izvlacimo vreme koje je uneo i proveravamo da li je to to !
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        uslov = uslov.Replace("=", string.Empty); //skidamo = iz uslova

                        String[] datum = uslov.Split('-');

                        if (datum.Length != 3)
                        {
                            return false;
                        }
                        DateTime datumFilter = new DateTime();
                        if (int.Parse(datum[2]) > 31 || int.Parse(datum[2]) < 1 || int.Parse(datum[1]) < 1 || int.Parse(datum[1]) > 12 || int.Parse(datum[0]) < 1) // ako je nepravilno uneo datum! MESEC/DAN/GODINA
                        {
                            return false;
                        }
                        datumFilter = Convert.ToDateTime(uslov);

                        int DaLiJeKasnijeOD = DateTime.Compare(manifestacija.Date, datumFilter);
                        if (DaLiJeKasnijeOD >= 0) // ako je ovaj datum kasnije od postavljenog datuma onda ce ovo vratiti vrednost ili 0 ili >0 (tj nula ako je to isti dan, sto ovde dozvoljavamo)
                            return true;
                        else
                            return false;

                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Data.Contains("="))
                {
                    String[] delovi = Data.Split('=');
                    //ovde ispitujemo da li je korisnik lepo uneo upit pa ako jeste i ako pocinje sa id onda poredimo id sa onim uslovom ako je name isto tako i to vracamo nazad!!
                    if (delovi.Length != 2)
                        return false;
                    else if (!delovi[1].StartsWith("\""))
                        return false;

                    delovi[0] = delovi[0].Replace(" ", string.Empty);
                    if (delovi[0] == "id")
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        uslov = uslov.ToLower();
                        string odTipa = manifestacija.Id.Replace(" ", string.Empty);
                        odTipa = odTipa.ToLower();

                        if (odTipa == uslov)
                            return true;
                        else
                            return false;
                    }
                    else if (delovi[0] == "id!") // ZA NEGACIJU ID-a
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        uslov = uslov.ToLower();
                        string odTipa = manifestacija.Id.Replace(" ", string.Empty);
                        odTipa = odTipa.ToLower();

                        if (odTipa == uslov)
                            return false;
                        else
                            return true;
                    }
                    else if (delovi[0] == "ime")
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        
                        string odTipa = manifestacija.Name.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();

                        if (odTipa == uslov)
                            return true;
                        else
                            return false;
                    }
                    else if (delovi[0] == "ime!") //ZA NEGACIJU IMENA
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        string odTipa = manifestacija.Name.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (odTipa == uslov)
                            return false;
                        else
                            return true;
                    }
                    else if (delovi[0] == "mOdrzavanja") //proveravamo mesto odrzavanja!
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        string odTipa = manifestacija.MestoOdrzavanja.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (odTipa == uslov)
                            return true;
                        else
                            return false;
                    }
                    else if (delovi[0] == "mOdrzavanja!") //proveravamo mesto odrzavanja!
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        string odTipa = manifestacija.MestoOdrzavanja.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (uslov == "napolju" || uslov == "unutra")
                        {
                            if (odTipa == uslov)
                                return false;
                            else
                                return true;
                        }
                        else
                            return false;
                    }
                    else if (delovi[0] == "sAlkohola") //proveravamo statusAlkohola!
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty);
                        string odTipa = manifestacija.StatusAlkohola.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (odTipa == uslov)
                            return true;
                        else
                            return false;
                    }
                    else if (delovi[0] == "sAlkohola!") //proveravamo statusAlkohola!
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty);
                        string odTipa = manifestacija.StatusAlkohola.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (uslov == "nemaalkohola" || uslov == "alkoholsemožedoneti" || uslov == "kupujesenalicumesta")
                        {
                            if (odTipa == uslov)
                                return false;
                            else
                                return true;
                        }
                        else
                            return false;
                    }
                    else if (delovi[0] == "kCena") //proveravamo kategorijuCena!
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty);
                        string odTipa = manifestacija.KategorijaCena.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (odTipa == uslov)
                            return true;
                        else
                            return false;
                    }
                    else if (delovi[0] == "kCena!") //proveravamo kategorijuCena!
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty);
                        string odTipa = manifestacija.KategorijaCena.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (uslov == "besplatno" || uslov == "niskecene" || uslov == "srednjecene" || uslov == "visokecene")
                        {
                            if (odTipa == uslov)
                                return false;
                            else
                                return true;
                        }
                        else
                            return false;
                    }
                    else if (delovi[0] == "pusenje") //proveravamo pusenje
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        
                        if (uslov == "true" || uslov == "TRUE")
                        { //ako je upisano true onda gledamo da li je postavljeno pusenje na true
                            if (manifestacija.PusenjeDozvoljeno)
                                return true;
                            else
                                return false;
                        }
                        else if (uslov == "false" || uslov=="FALSE") //ako je postavljeno na false onda pogledamo da li je pusenjeNijedozvoljeno na true!
                        {
                            if (manifestacija.PusenjeNijeDozvoljeno)
                                return true;
                            else
                                return false;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else if (delovi[0] == "hendikepirani") //ispitujemo da li su hendikepirani dozvoljeni
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        if (uslov == "true" || uslov=="TRUE") //ako je stavlejno na true ispitujemo da li je vrednost atributa hendikepiraniDozvoljeni na true
                        {
                            if (manifestacija.HendikepiraniDozvoljeni)
                                return true;
                            else
                                return false;
                        }
                        else if (uslov == "false" || uslov=="FALSE") // ako je sastavljeno na false onda ispitujemo dal i je vrednost atributa hendikeprianiNisuDozvoljeni na true
                        {
                            if (manifestacija.HendikepiraniNisuDozvoljeni)
                                return true;
                            else
                                return false;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else if (delovi[0] == "etiketa") //proveravamo etiketu, znaci ako je nema u spisku etiketa manifestacije znaci vracamo false (ako ne iskoci pre toga!!)
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        foreach (Etiketa item11 in manifestacija.Etikete)
                        {
                            string odTipa = item11.Id.Replace(" ", string.Empty);
                            uslov = uslov.ToLower();
                            odTipa = odTipa.ToLower();
                            if (odTipa == uslov)
                                return true;

                        }
                        return false;
                    }
                    else if (delovi[0] == "etiketa!") //NEGACIJA OD TRAZENAJ ETIKETE
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        foreach (Etiketa item11 in manifestacija.Etikete)
                        {
                            string odTipa = item11.Id.Replace(" ", string.Empty);
                            uslov = uslov.ToLower();
                            odTipa = odTipa.ToLower();
                            if (odTipa == uslov)
                                return false;

                        }
                        return true;
                    }
                    else if (delovi[0] == "tip") //proveravamo tip tj ID tipa koji zelimo da poredimo !!!
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        string odTipa = manifestacija.Tip.Id.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (odTipa == uslov)
                            return true;
                        else
                            return false;
                    }
                    else if (delovi[0] == "tip!") //NEGACIJA OD TRAZENJA TIPA
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        string odTipa = manifestacija.Tip.Id.Replace(" ", string.Empty);
                        uslov = uslov.ToLower();
                        odTipa = odTipa.ToLower();
                        if (odTipa == uslov)
                            return false;
                        else
                            return true;
                    }
                    else if (delovi[0] == "publika") //proveravamo da li se poklapa tacna vrednost za ocekivanu publiku !
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        if (manifestacija.OcekivanaPublika == uslov)
                            return true;
                        else
                            return false;
                    }
                    else if (delovi[0] == "publika!") //NEGACIJA OD TRAZENAJ PUBLIKE
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        if (manifestacija.OcekivanaPublika == uslov)
                            return false;
                        else
                            return true;
                    }
                    else if (delovi[0] == "datum")
                    {
                        //izvlacimo vreme koje je uneo i proveravamo da li je to to !
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        String[] datum= uslov.Split('-');
                        if (datum.Length != 3)
                        {
                            return false;
                        }
                        DateTime datumFilter = new DateTime();
                        if(int.Parse(datum[2]) > 31 || int.Parse(datum[2]) < 1 || int.Parse(datum[1]) < 1 || int.Parse(datum[1]) > 12 || int.Parse(datum[0]) < 1) // ako je nepravilno uneo datum! MESEC/DAN/GODINA
                        {
                            return false;
                        }
                        datumFilter = Convert.ToDateTime(uslov);

                        if (manifestacija.Date == datumFilter)
                        {
                            return true;
                        }
                        else
                            return false;

                    }
                    else if (delovi[0] == "datum!")
                    {
                        //izvlacimo vreme koje je uneo i proveravamo da li je to to !
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        String[] datum = uslov.Split('-');
                        if (datum.Length != 3)
                        {
                            return false;
                        }
                        DateTime datumFilter = new DateTime();
                        if (int.Parse(datum[2]) > 31 || int.Parse(datum[2]) < 1 || int.Parse(datum[1]) < 1 || int.Parse(datum[1]) > 12 || int.Parse(datum[0]) < 1) // ako je nepravilno uneo datum! MESEC/DAN/GODINA
                        {
                            return false;
                        }
                        datumFilter = Convert.ToDateTime(uslov);

                        if (manifestacija.Date == datumFilter)
                        {
                            return false;
                        }
                        else
                            return true;

                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Data.Contains("<")) {
                    String[] delovi = Data.Split('<');
                    //ovde ispitujemo da li je korisnik lepo uneo upit pa ako jeste i ako pocinje sa id onda poredimo id sa onim uslovom ako je name isto tako i to vracamo nazad!!
                    if (delovi.Length != 2)
                        return false;
                    else if (!delovi[1].StartsWith("\""))
                        return false;

                    delovi[0] = delovi[0].Replace(" ", string.Empty);
                    if (delovi[0] == "publika") {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        if (IsDigitsOnly(uslov))
                        { //ako je samo od brojeva sastavljen onda mozemo da poredimo
                            if (int.Parse(manifestacija.OcekivanaPublika) < int.Parse(uslov))
                                return true;
                            else
                                return false;
                        }
                        else
                            return false; // ne sastoji se od cifara
                    }
                    else if (delovi[0] == "datum")
                    {
                        //izvlacimo vreme koje je uneo i proveravamo da li je to to !
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        String[] datum = uslov.Split('-');
                        if (datum.Length != 3)
                        {
                            return false;
                        }
                        DateTime datumFilter = new DateTime();
                        if (int.Parse(datum[2]) > 31 || int.Parse(datum[2]) < 1 || int.Parse(datum[1]) < 1 || int.Parse(datum[1]) > 12 || int.Parse(datum[0]) < 1) // ako je nepravilno uneo datum! MESEC/DAN/GODINA
                        {
                            return false;
                        }
                        datumFilter = Convert.ToDateTime(uslov);

                        int DaLiJeRanije = DateTime.Compare(manifestacija.Date, datumFilter);
                        if (DaLiJeRanije < 0) // ako je ovaj datum ranije od postavljenog datuma onda ce ovo vratiti vrednost <0
                            return true;
                        else
                            return false;

                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Data.Contains(">"))
                {
                    String[] delovi = Data.Split('>');
                    //ovde ispitujemo da li je korisnik lepo uneo upit pa ako jeste i ako pocinje sa id onda poredimo id sa onim uslovom ako je name isto tako i to vracamo nazad!!
                    if (delovi.Length != 2)
                        return false;
                    else if (!delovi[1].StartsWith("\""))
                        return false;

                    delovi[0] = delovi[0].Replace(" ", string.Empty);
                    if (delovi[0] == "publika")
                    {
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        if (IsDigitsOnly(uslov))
                        { //ako je samo od brojeva sastavljen onda mozemo da poredimo
                            if (int.Parse(manifestacija.OcekivanaPublika) > int.Parse(uslov))
                                return true;
                            else
                                return false;
                        }
                        else
                            return false; // ne sastoji se od cifara
                    }
                    else if (delovi[0] == "datum")
                    {
                        //izvlacimo vreme koje je uneo i proveravamo da li je to to !
                        string uslov = delovi[1].Replace(" ", string.Empty);
                        uslov = uslov.Replace("\"", string.Empty); //skidamo navodnike iz uslova
                        String[] datum = uslov.Split('-');
                        if (datum.Length != 3)
                        {
                            return false;
                        }
                        DateTime datumFilter = new DateTime();
                        if (int.Parse(datum[2]) > 31 || int.Parse(datum[2]) < 1 || int.Parse(datum[1]) < 1 || int.Parse(datum[1]) > 12 || int.Parse(datum[0]) < 1) // ako je nepravilno uneo datum! MESEC/DAN/GODINA
                        {
                            return false;
                        }
                        datumFilter = Convert.ToDateTime(uslov);

                        int DaLiKasnije = DateTime.Compare(manifestacija.Date, datumFilter);
                        if (DaLiKasnije > 0) // ako je ovaj datum kasnije od postavljenog datuma onda ce ovo vratiti vrednost >0
                            return true;
                        else
                            return false;

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }






            return daLiPodrzava;

        }

        public bool IsDigitsOnly(string str) //ovo koristimo samo da proverimo da li je broj publike namesten samo na cifre!
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }


        public DrvoZaPretragu<string> AddChild(string child)
        {
            DrvoZaPretragu<string> childNode = new DrvoZaPretragu<string>(child);        
            childNode.Parent = this;
            this.Children.Add(childNode);
            return childNode;
        }

        public IEnumerator<DrvoZaPretragu<T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<DrvoZaPretragu<string>> IEnumerable<DrvoZaPretragu<string>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
