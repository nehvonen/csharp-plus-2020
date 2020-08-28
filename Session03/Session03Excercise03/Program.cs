using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Session03Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");

            var input = Console.ReadLine();

            var inputData = input.Split(" , ", StringSplitOptions.RemoveEmptyEntries);
            double[] numberArray = new double[inputData.Length];

            for (int i = 0; i < inputData.Length; i++)
            {
                NumberStyles numberStyle = NumberStyles.Integer | NumberStyles.Float;

                bool parsed = double.TryParse(inputData[i], numberStyle, CultureInfo.InvariantCulture, out double parsedValue);

                if (parsed == true)
                {
                    numberArray[i] = parsedValue;
                }
                else
                {
                  //  numberArray[i] = null; 

                }

                /*/ try
                {
                    numberArray[i] = Convert.ToDouble(inputData[i]);

                    //Debug Assert{i<inputData.Length -1};
                }
                catch (Exception)
                {
                    numberArray[i] = 0;
                }
                finally
                {

                } /*/ 
            }


            foreach (var number in numberArray)
            {
                Console.WriteLine("Värde: " + number.ToString());
            }
        }
    }
}
