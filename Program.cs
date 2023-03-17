using System.Collections;

namespace ciclo_for_arraylist
{
    internal class Program
    {
         public static void Main(string[] args)
         {
            Random rnd = new Random();

            ArrayList persone = new ArrayList() { "Riccardo", "viviana", "gianmarco", "mirko", "aiello", "andrea", "alan", "godyl", "giulia" };
    
            int personeIndex = rnd.Next(persone.Count);
 
            Console.WriteLine(persone[personeIndex]);
         }
    }
}

