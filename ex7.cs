using esercizio7;
using System.Globalization;
using System.IO.Pipes;

namespace esercizio7
{

    class Contribuente
    {
        public  string Nome { get; private set; }
        public  string Cognome { get; private set; }
        public string DataNascita { get; private set; }
        public string CodiceFiscale { get; private set; }
        public string Sesso { get; private set; }
        public string ComuneResidenza { get; private set; }
        public decimal RedditoAnnuale { get; private set; }
        public decimal Aliquota { get; private set; }

        public void CalAliquota()
        {

            if (RedditoAnnuale > 0 && RedditoAnnuale <= 15000)

            {
                Aliquota = (RedditoAnnuale) * (23 / 100);
            }
            else if (RedditoAnnuale > 15001 && RedditoAnnuale <= 28000)
            {
                Aliquota = (RedditoAnnuale - 3450) * (27 / 100);
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                Aliquota = (RedditoAnnuale - 6960) * (38 / 100);
            }
            else if (RedditoAnnuale > 55001 && RedditoAnnuale <= 75000) 

            {
                Aliquota = (RedditoAnnuale - 17220) * (41/100);
            }
            else if (RedditoAnnuale >= 75001)
            {
                Aliquota = (RedditoAnnuale -25420) * (43/100);
            }

        }

        public void Persona()
        {
            Console.WriteLine("come ti chiami ?");
            string nome1 = Console.ReadLine();
            Nome = nome1;

            Console.WriteLine("cognome ?");
            string cognome1 = Console.ReadLine();
            Cognome = cognome1;

            Console.WriteLine("data di nascita ?");
            string datanascita1 = Console.ReadLine();
            DataNascita = datanascita1;

            Console.WriteLine("codice fiscale ?");
            string codicefiscale1 = Console.ReadLine();
            CodiceFiscale = codicefiscale1;

            Console.WriteLine("inserisci il tuo sesso");
            string sesso1 = Console.ReadLine();
            Sesso = sesso1;

            Console.WriteLine("quale è il comune di residenza");
            string comuneresidenza = Console.ReadLine();
            ComuneResidenza = comuneresidenza;

            Console.WriteLine("inserisci reddito annuale");
            string redditoannuale = Console.ReadLine();
            decimal redditoannuale1 = decimal.Parse(redditoannuale);
            RedditoAnnuale = redditoannuale1;

            Console.WriteLine("inserisci aliquota");
            string aliquota = Console.ReadLine();
            decimal aliquota1 = decimal.Parse(aliquota);
            Aliquota = aliquota1;

            Console.WriteLine($"contribuente {Nome} {Cognome} ");
            Console.WriteLine($"sono nato il giorno {DataNascita}");
            Console.WriteLine($"sono residente a {ComuneResidenza}");
            Console.WriteLine($"il mio codice fiscale è {CodiceFiscale}");
            Console.WriteLine($"sono un {Sesso}");
            Console.WriteLine($"il mio reddito annuale è di {RedditoAnnuale}");
            Console.WriteLine($"aliquota {Aliquota}");
        }

    }

}

    internal class Program
    {

        static void Main(string[] args)
        {
            Contribuente cicciolo = new Contribuente();
            cicciolo.Persona(); 
        }
    }

