using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konvertera det inmatade värdena från strängar till siffror
            // Resultatet skall presentera:
            // Lägsta värdet
            // Högsta värdet
            // Medelvärde (snitt)
            // Programmet skall vara felhanterat
            // Felaktiga värden får inte påverka medelvärde, lägsta eller högsta.

            Console.WriteLine("Skriv en eller flera siffror separerad med kommatecken");

            string inputString = Console.ReadLine();
            var inputArray = inputString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);


            Object[] objectInteger = new Object[inputArray.Length];


            for (int i = 0; i < inputArray.Length; i++)
            {
                double inputInteger;
                if (double.TryParse(inputArray[i], out inputInteger))
                {
                    objectInteger[i] = inputInteger;
                    Console.WriteLine(inputInteger);
                }
                else
                {
                    Console.WriteLine("Felvärde. Försök igen");
                }
            }
            Console.WriteLine("Ditt största värde är " + objectInteger.Max());
            Console.WriteLine("Ditt minsta värda är " + inputArray.Min());
        }
    }
}
