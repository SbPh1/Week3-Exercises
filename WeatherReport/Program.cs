using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mitu kraadi õues on;
            //kui õues on rohkem kui 35 kraadi, programm kuvab "boiling hot"
            //kui õues on 30 kuni 35 kraadi, programm kuvab "hot"
            //kui õues on 20 kuni 30 kraadi, programm kuvab "nice"
            //kui õues on 10 kuni 20 kraadi, programm kuvab "chilly"
            //kui õues on 0 kuni 10 kraadi, programm kuvab "Cold"

            Console.WriteLine("Mitu kraadi õues on?");
            int Celsius = Convert.ToInt32(Console.ReadLine());

            if (Celsius > 35)
            {
                Console.WriteLine("Boiling hot");
            }
            else if (Celsius >= 30 && Celsius < 35)
            {
                Console.WriteLine("Hot");
            }
            else if (Celsius >= 20 && Celsius < 30)
            {
                Console.WriteLine("Nice");
            }
            else if (Celsius >= 10 && Celsius < 20)
            {
                Console.WriteLine("Chilly");
            }
            else if (Celsius >= 0 && Celsius < 10)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("Freezing Cold");
            }

           


        }
    }
}
