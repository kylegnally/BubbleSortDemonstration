using System;

namespace BubbleSortDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand;
            //ArraysCollection finalArrays = new ArraysCollection();
            //BubbleSort sortThis;

            int[] arraySizes =
            {
                10, // 100, 1000, 10000, 25000, 50000, 100000, 250000, 500000, 750000,  1000000,
            };

            foreach (int size in arraySizes)
            {
                rand = new Random();
                ArrayToSort newArray = new ArrayToSort(size, rand);
                Console.WriteLine("Collection created.");
                //Console.WriteLine(newArray.ToString());
            }
            Environment.Exit(0);
        }

        
    }
}
