using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand;
            ArraysCollection finalArrays = new ArraysCollection();

            int[] arraySizes =
            {
                100, 1000, 10000, 25000, 50000, 100000, 250000, 500000, 750000, 1000000
            };

            foreach (int size in arraySizes)
            {
                rand = new Random();
                ArrayToSort newArray = new ArrayToSort(size, rand);
                finalArrays.Add(newArray);
            }
            Console.WriteLine("Collection created.");
            Environment.Exit(0);
        }
    }
}
