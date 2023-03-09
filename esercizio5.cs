using System.Globalization;

namespace esercizio5
{
    internal class esercizio5
    {   
        static void Operazione(int[] arr)
        {
            int sum = 0;

            foreach (int j in arr)
            {
                sum += j;
            }

            Console.WriteLine(sum);

            double media = sum / arr.Length;

            Console.WriteLine(media);
        }

        static void Main(string[] args)
        {
            int[] numbers = { 6, 5, 4, 3, 2, 1 };

            Operazione(numbers);
        }
    }
}