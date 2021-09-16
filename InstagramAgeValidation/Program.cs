using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sünniaastat
            //programm arvutab kasutaja vanuse
            //programm kontrollib kas kasutaja on vanem kui 13 või 13 aastat vana
            //kui kasutaja on 13 aastat vana või vanem,
            //siis ta võib Instagram'i kasutada
            //Kui kasutaja on noorem kui 13, siis ta on liiga noor

            Console.WriteLine("Sisestage oma sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int Age = 2021 - YearOfBirth;

                if (Age >= 13)
            {
                Console.WriteLine("Tere tulemast Instagrami!");
            }
                else
            {
                Console.WriteLine("Oled liiga noor");
            }
        }

    }
}
