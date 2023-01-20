using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            string mängd = Console.ReadLine();

            int mängden = int.Parse(mängd);
;
            int[] m = new int[mängden];

            for(int i =0; i < mängden; i++)
            {

                Console.Write("Skriv in ditt tal: ");
                m[i]=int.Parse(Console.ReadLine());

            }

            foreach(int i in m)
            {
                Console.WriteLine(i);
            }
        }
    }
}

