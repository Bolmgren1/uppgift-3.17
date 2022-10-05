using System;

namespace inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 tal");
            Console.WriteLine("Skriv tal 1 här");

            double tal1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in tal 2 här");

            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Välj 1-4 räknesätt här under");

            Console.WriteLine("1 = Addition");
            Console.WriteLine("2 = Subtraktion");
            Console.WriteLine("3 = Multiplikation");
            Console.WriteLine("4 = Division");

            int räknesätt = int.Parse(Console.ReadLine());

            switch(räknesätt)
            {
                case 1: Console.WriteLine("addition");
                    double summa1 = tal1 + tal2;
                    Console.WriteLine("Svaret blir " + summa1);
                    break;

                case 2: Console.WriteLine("Subtraktion");
                    double summa2 = tal1 - tal2;
                    Console.WriteLine("Svaret blir " + summa2);
                    break;

                case 3: Console.WriteLine("Multiplikation");
                    double summa3 = tal1 * tal2;
                    Console.WriteLine("Svaret blir " + summa3);
                    break;

                case 4: Console.WriteLine("Division");
                    double summa4 = tal1 / tal2;
                    Console.WriteLine("Svaret blir " + summa4);
                    break;



            }

        }
    }
}
