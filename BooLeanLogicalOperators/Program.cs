using System;

namespace BooLeanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja kasutajatunnust
            //programm küsib kasutaja parooli
            //programm kontrollib kas mõlemad on õiged
            //kui mõlemad on õiged konsool be like Tere Tulemast
            //Kui on vale siis programm be like sisselogimine ebaõnnestus
            //kt:admin pr:admin1234


            Console.WriteLine("Kasutajanimi");
            string Kasutaja = (Console.ReadLine());
            Console.WriteLine("Parool");
            string Parool = (Console.ReadLine());
            if (Kasutaja == "admin" && Parool == "admin1234") 
            {
                Console.WriteLine("Tere Tulemast!");
            }
            else
            {
                Console.WriteLine("Lahku");
            }
               















        }
    }
}
