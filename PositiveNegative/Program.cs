using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numbrit - 10 kuni 10;
            //programm kontrollib numbrit;
            //kui number on positiivne, konsool kuvab "positive";
            //kui number on negatiivne; konsool kuvab "negative";
            //kui number on 0, siis konsool kuvab "null";

            Console.WriteLine("Enter a number from -10 to 10");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number > 0)
            {
                Console.WriteLine("Positive.");
            }
            else if (Number < 0)
            {
                Console.WriteLine("Negative.");
            }
            else
            {
                Console.WriteLine("Zero.");
            }
        }
    }
}
