using System;

namespace Session3Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var integer = new int[] { 1, 2, 3, 4 };
            var name = nameof(integer);

            for (var i = 0; i < integer.Length; i++)
            {
                
                var value = integer[i];

                Console.WriteLine($"Index {i} i arrayen {(nameof(integer))} har värdet: {value}");
            }

            var dowhileIndex = 0;
            do
            {
                var value = integer[dowhileIndex];
                Console.WriteLine($"Index do while {dowhileIndex} i arrayen {(nameof(integer))} har värdet: {value}");
                dowhileIndex++;

            }
            while (dowhileIndex < integer.Length);

            var whileIndex = 0;

            while (whileIndex < integer.Length)
            {
                var value = integer[whileIndex]; 
                
                Console.WriteLine($"While Index {whileIndex} i arrayen {(nameof(integer))} har värdet: {value}");
                whileIndex++;
            }

        }
    }
}
