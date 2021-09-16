using System;

namespace Week3Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage PIN-kood:");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            /*if (userPIN == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }*/

            if (userPIN != 1234)
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
