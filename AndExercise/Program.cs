using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //min mates 85p
            //min keemias 90p
            //min bios 95p
            //programm küsib kasutajal sisestada tema eksami punktid
            //ja otsustab kas, kas kasutaja saab arstiks õppida

            Console.WriteLine("Sisestage matemaatika eksami tulemus:");
            int matePunktid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisestage keemia eksami tulemus:");
            int keemiaPunktid = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sisestage bioloogia eksami tulemus:");
            int bioPunktid = Convert.ToInt32(Console.ReadLine());

            if (matePunktid >= 85 && keemiaPunktid >= 90 && bioPunktid >= 95)
            {
                Console.WriteLine("Saate asuda õppima arstiks");
            }
            else
            {
                Console.WriteLine("Teie tulemus pole piisav, et asuda õppima arstiks");
            }
        }
    }
}
