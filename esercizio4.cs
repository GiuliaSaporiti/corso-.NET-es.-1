using System.ComponentModel.Design;

namespace esercizio4
{
    internal class esercizio4
    {
        static void Main(string[] args)
        {
             string[] nomi = new string[] { "marta", "giulia", "gloria", "aiello" };
             static void ricercaNome(string[] arr)
             {
                Console.WriteLine("nome cercato");
                string nomeCercato = Console.ReadLine();
                bool m = false;

                foreach (string s in arr)
                {
                    if (s == nomeCercato)
                    {
                        m = true;
                    }
                }
                if (m)
                {
                    Console.WriteLine("il nome esiste");
                }
                else
                {
                    Console.WriteLine("il nome non esiste nell'array");
                }
            }
          ricercaNome(nomi);
        }
    }
}