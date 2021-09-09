using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana,
            //et juhiluba saada (tingimuseks 18 aastat vana)

            Console.WriteLine("Mis aastal sündisid?");
            int Sünniaasta = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - Sünniaasta;


            if (Age > 18)
            {
                Console.WriteLine("Saad teha juhiload.");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Sa oled liiga noor, et teha juhiload,");
            }
            else
            {
                Console.WriteLine("Oled täpselt 18, et teha juhiload.");
            }

            Console.WriteLine("Kena päeva jätku.");
        }
    }
}
