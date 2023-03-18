using esercizio7;
using System.Globalization;
using System.IO.Pipes;

namespace esercizio7
{

    class Contribuente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public string DataNascita { get; private set; }
        public string CodiceFiscale { get; private set; }
        public string Sesso { get; private set; }
        public string ComuneResidenza { get; private set; }
        public decimal RedditoAnnuale { get; private set; }
        public decimal Aliquota { get; private set; }
        

        public decimal CalAliquota()
        {

            if (RedditoAnnuale > 0 && RedditoAnnuale <= 15000)

            {
               Aliquota = (RedditoAnnuale) * (23 / 100);
            }
            else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
            {
                Aliquota = 3450 + (RedditoAnnuale - 15000) * (27 / 100);
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
               Aliquota = 6960 + (RedditoAnnuale - 28000) * (38 / 100);
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)

            {
                Aliquota = 17220 + (RedditoAnnuale - 28000) * (41 / 100);
            }
            else if (RedditoAnnuale >= 75000)
            {
                Aliquota = 25420 + (RedditoAnnuale - 75000) * (43 / 100);
            }
            return Aliquota;
        }

        
        public Contribuente (string nome, string cognome, string datanascita, string codicefiscale, string sesso, string comuneresidenza, decimal redditoAnnuale )
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = datanascita;
            CodiceFiscale = codicefiscale;
            Sesso = sesso;
            ComuneResidenza = comuneresidenza;
            RedditoAnnuale = redditoAnnuale;
        }
    }

    class Program
    {
        public static Contribuente Persona()
        {
            Console.WriteLine("come ti chiami ?");
            string nome1 = Console.ReadLine();
            

            Console.WriteLine("cognome ?");
            string cognome1 = Console.ReadLine();
           

            Console.WriteLine("data di nascita ?");
            string datanascita1 = Console.ReadLine();
            

            Console.WriteLine("codice fiscale ?");
            string codicefiscale1 = Console.ReadLine();
            

            Console.WriteLine("inserisci il tuo sesso");
            string sesso1 = Console.ReadLine();
            

            Console.WriteLine("quale è il comune di residenza");
            string comuneresidenza = Console.ReadLine();
            

            Console.WriteLine("inserisci reddito annuale");
            string redditoannuale = Console.ReadLine();
            decimal redditoannuale1 = decimal.Parse(redditoannuale);
                
            return new Contribuente(nome1, cognome1, datanascita1, codicefiscale1, sesso1, comuneresidenza, redditoannuale1);
            
        }
       
        public static void Stampa(Contribuente x)

        {
            x.CalAliquota();
            Console.WriteLine($"contribuente {x.Nome} {x.Cognome} ");
            Console.WriteLine($"sono nato il giorno {x.DataNascita}");
            Console.WriteLine($"sono residente a {x.ComuneResidenza}");
            Console.WriteLine($"il mio codice fiscale è {x.CodiceFiscale}");
            Console.WriteLine($"sono un {x.Sesso}");
            Console.WriteLine($"il mio reddito annuale è di {x.RedditoAnnuale}");
            Console.WriteLine($"aliquota {x.Aliquota}");

        }

        static void Main(string[] args)
        {
            Stampa(Persona());
        }
    }

}