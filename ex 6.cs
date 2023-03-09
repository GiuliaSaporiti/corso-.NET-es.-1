namespace esercizio6
{

    class Menu


    {
        private string _username;
        private string _password;
        private string _confermaPassword;
        private bool _display;
        private bool _autok;
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfermaPassword { get; set; }
        public bool Display { get; set; }
        public bool Autok { get; set; }
        public static void Banner()
        {
            string[] opzioni = { "login", "logout", "verifica ora e data", "lista degli accessi", "esci" };


            Console.WriteLine("========OPZIONI=======");
            Console.WriteLine("Segli l'operazione da effettuare:");
            for (int i = 0; i < opzioni.Length; i++)
            {
                Console.WriteLine($"{i + 1} {opzioni[i]}");
            }
            Console.WriteLine("=======================");
        }

        public void Login()
        {
            Console.WriteLine("insert name");
            string nome = Console.ReadLine();
            Username = nome;

            Console.WriteLine("insert password");
            string password = Console.ReadLine();
            Password = password;

            Console.WriteLine("confirm password");
            string confermaPassword = Console.ReadLine();
            if (confermaPassword == password)
            {
                Console.WriteLine($"password giusta ciao {nome}");
                Autok = true;
                DateTime date = DateTime.Now;
                Console.WriteLine(date);
            } 
            else
            {
                Console.WriteLine("la password è sbagliata");
            }

            Banner();
        }
        public void Logout()
        {
            if (Autok)
            {
                Username = "";
                Password = "";
                ConfermaPassword = "";
                Autok = false;
            }
            else
            {
                Console.WriteLine("sei uscito");
            }

            Banner();
        }
        public void DataOraLogin(object datetime)
        {
            if (!Autok)
            {
                Console.WriteLine(datetime);
            }
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu.Banner();
        }
    }
}