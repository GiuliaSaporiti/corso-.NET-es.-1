namespace esercizio_2
{
    internal class Program
    {
        class Persona
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public int Eta { get; set; }

            public void GetName()
            
            {
                Console.WriteLine($"salve sono {Nome} ");
            }
            public void GetCognome()
            {
                Console.WriteLine($" il mio cognome è {Cognome}");
            }

            public void GetEta()
            {
                Console.WriteLine($"la mia età è di {Eta}");
            }

            public void GetDettagli()
            {
                Console.WriteLine($"sono molto contento di conoscervi sono {Nome} {Cognome} e ho {Eta} anni ");
            }
        }
        static void Main(string[] args)
        {
            Persona bella = new Persona();
            bella.Nome = "Giulia";
            bella.Cognome = "Sapo";
            bella.Eta = 25;

            bella.GetName();
            bella.GetCognome();
            bella.GetEta();
            bella.GetDettagli();

            
        }
    }
}
