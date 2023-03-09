namespace esercizio6
{

    static class Menu
    { 
        public static string Username { get; private set; }
        public static string Password { get; private set; }
        public static string ConfermaPassword { get; private set; }
        public static bool AuthOk { get; private set; }
        public static string DataLogin { get; private set }
        public static bool SeiFuori { get; private set } = false;
        public static DateTime[] ListaAccessi { get; private set; }




        public static void Login()
        {
            Console.WriteLine("inserire username");
            string nome = Console.ReadLine();
            Username = nome;

            Console.WriteLine("insert password");
            string password = Console.ReadLine();
            Password = password;

            Console.WriteLine("confermare password");
            string confermapassword = Console.ReadLine();

            if (confermapassword == password)
            {
                Console.WriteLine($"Benvenuto {Username}!");
                AuthOk = true;
                DataLogin = DateTime.Now.ToString();

            }
            else
            {
                Console.WriteLine("Le password è errata!");
            }
        }

        public static void Logout()
        {
            if (AuthOk)
            {
                Username = "";
                Password = "";
                ConfermaPassword = "";
                AuthOk = false;
                DataLogin = "";
                Console.WriteLine("logout");
            }
            else
            {
                Console.WriteLine("errore");
            }

        }
        public static void DataOraLogin()
        {
            if (AuthOk)
            {
                Console.WriteLine($"ti sei autenticato in {DataLogin}");
            }
            else
            {
                Console.WriteLine("non sei loggato");
            }

        }
        public static void Esci()
        {
            SeiFuori = true;
        }

        internal class Program
        {
            static void Main()
            {
                string[] opzioni = { "Login", "Logout", "Verifica ora e data di login", "Lista degli accessi", "Esci" };

                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l’operazione da effettuare:");
                for (int i = 0; i < opzioni.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {opzioni[i]}");
                }
                Console.WriteLine("========================================");
            }

            public static void Gestione()
            {
                Main();
                string stringa = Console.ReadLine();
                int scelta = int.Parse(stringa);
                switch (scelta)
                {
                    case 1:
                        Menu.Login();
                        break;
                    case 2:
                        Menu.Logout();
                        break;
                    case 3:
                        Menu.DataOraLogin();
                        break;
                    case 5:
                        Menu.Esci();
                        break;
                    default:
                        Console.WriteLine("Non è una scelta valida");
                        break;
                }

            }
            static void Main(string[] args)
            {
                do
                {
                    Gestione();
                } while (Menu.SeiFuori == false);
            }
        }
    }
}
        