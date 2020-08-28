using System;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");

            var input = Console.ReadLine();

            var inputData = input.Split(" , ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in inputData)
            {
                Console.WriteLine("Värdet är " + number);
            }

        }
    }
}
