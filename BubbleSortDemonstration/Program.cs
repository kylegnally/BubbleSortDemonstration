using System;
using System.IO;
using System.Text;

namespace BubbleSortDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand;
            ArrayToSort newArray;

            StreamReader reader;
            StreamWriter writer;
            StringBuilder stBuilder;

            int[] arraySizes =
            {
                10, 100, //1000, 10000, 25000, 50000, 100000, 250000, 500000, 750000,  1000000,
            };

            foreach (int size in arraySizes)
            {
                rand = new Random();
                newArray = new ArrayToSort(size, rand);

                Console.WriteLine("Collection created.");

                //foreach (int number in newArray.Result)
                //{
                //    Console.WriteLine(newArray.Result);
                //}
            }
            Environment.Exit(0);
        }

        
    }
}
