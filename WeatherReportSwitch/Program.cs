using System;

namespace WeatherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi õues on?");
            int Celsius = Convert.ToInt32(Console.ReadLine());

            switch (Celsius)
            {
                case var _ when Celsius >= 35:
                    Console.WriteLine("Boiling hot");
                    break;
                case var _ when Celsius >= 30 && Celsius <= 35:
                    Console.WriteLine("Hot");
                    break;
                case var _ when Celsius >= 20 && Celsius <= 30:
                    Console.WriteLine("Nice");
                    break;
                case var _ when Celsius >= 10 && Celsius <= 20:
                    Console.WriteLine("Chilly");
                    break;
                case var _ when Celsius >= 0 && Celsius <= 10:
                    Console.WriteLine("Cold");
                    break;
                default:
                    Console.WriteLine("Freezing cold");
                    break;

            }
        }
    }
}
