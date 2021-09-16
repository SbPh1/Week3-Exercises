using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmeid
            //kui sisestatud kasutajatunnus on "admin" ja 
            //sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast!"
            //muul juhul programm kuvab "Vale kasutajatunnus või parool. Proovi uuesti";

            Console.WriteLine("Sisestage kasutajatunnus ja parool:");
            string userName = Console.ReadLine();
            string passWord = Console.ReadLine();

            /*if (userName == "admin" && passWord == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
            }    */
            
            if (userName != "admin" || passWord != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
