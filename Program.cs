namespace pippofranco
{
    internal class Program
    {
        class Automobile
        {
            public decimal Prezzo { get; set; }
            public string Marca { get; set; }
            public string Modello { get; set; }

            public int Anno { get; set; }

            public void stampa() 
            {
                Console.WriteLine("automobile : {0} {1}, Anno: {2}, Prezzo:{3}  £", Marca, Modello, Anno, Prezzo);
            }
        }
        class Animale
        {
            public string Specie { get; set; }
            public string Habitat { get; set; }
            public int Zampe { get; set; }
            public string Colore { get; set; }

            public void stampa()
            {
                Console.WriteLine($"animale di specie {Specie} che vive {Habitat}, ha {Zampe} zampe ed ha il manto {Colore}");
            }
        }
        class Dipendente
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public int Eta { get; set; }

            public void stampa()
            {
                Console.WriteLine($"sono {Nome} {Cognome} e ho {Eta} anni");
            }
        }
        class Atleta
        {
            public string Nome { get; set; }
            public string Sport { get; set; }
            public int Altezza { get; set; }
            public int Peso { get; set; }

            public void presentazione()
            {
                Console.WriteLine($"sono {Nome} pratico il {Sport} sono alto {Altezza} centimetri e peso {Peso} kg");
            }
        }

        static void Main(string[] args)
        {
            Atleta duck = new Atleta();
            duck.Nome = "duck";
            duck.Sport = "nuoto";
            duck.Altezza = 2;
            duck.Peso = 50;
            duck.presentazione();
            Atleta bird = new Atleta();
            bird.Nome = "bird";
            bird.Sport = "danza";
            bird.Altezza = 1;
            bird.Peso = 36;
            bird.presentazione();

            Dipendente dipendente = new Dipendente();
            dipendente.Nome = "severo";
            dipendente.Cognome = "tuorlo";
            dipendente.Eta = 67;
            dipendente.stampa();
            Dipendente dipendente2 = new Dipendente();
            dipendente2.Nome = "carlotta";
            dipendente2.Cognome = "parola";
            dipendente2.Eta = 45;
            dipendente2.stampa();

            Animale tigre = new Animale();
            tigre.Specie = "felino";
            tigre.Habitat = "malesia";
            tigre.Zampe = 4;
            tigre.Colore = "arancione";
            tigre.stampa();
            Animale leone = new Animale();
            leone.Specie = "felino";
            leone.Habitat = "foresta";
            leone.Zampe = 4;
            leone.Colore = "giallo";
            leone.stampa();

            Automobile bmw = new Automobile();
            bmw.Anno = 2010;
            bmw.Marca = "BMW";
            bmw.Modello = "x5";
            bmw.Prezzo = 37000;
            bmw.stampa();
            Automobile tucson = new Automobile();
            tucson.Anno = 2018;
            tucson.Marca = "hunday";
            tucson.Modello = "tucson";
            tucson.Prezzo = 26000;
            tucson.stampa();


        }

       
    }
}