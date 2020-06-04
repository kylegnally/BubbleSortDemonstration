using System;
using System.Runtime.ExceptionServices;

namespace BubbleSortDemonstration
{
    class ArrayToSort
    {
        private readonly int _size;
        private int[] origArray;

        private  int[] _resultingArray;
        private readonly Random _rand;

        public int[] Result { get; private set; }

        public ArrayToSort(int size, Random r)
        {
            Result = null;
            _size = size;
            _rand = r;
            _resultingArray = new int[_size];
            MakeArray(_rand);
            SortArray(Result);
        }

        private void MakeArray(Random rnd)
        {
            for (int i = 0; i < _size; i++)
            {
                _resultingArray[i] = rnd.Next(1, _size + 1);
            }
            Result = _resultingArray;
        }

        //static void bubbleSort(int[] arr)
        //{
        //    int n = arr.Length;
        //    for (int i = 0; i < n - 1; i++)
        //    for (int j = 0; j < n - i - 1; j++)
        //        if (arr[j] > arr[j + 1])
        //        {
        //            // swap temp and arr[i] 
        //            int temp = arr[j];
        //            arr[j] = arr[j + 1];
        //            arr[j + 1] = temp;
        //        }
        //}

        public void SortArray(int[] array)
        {
            int size = array.Length;
            foreach (int arrayMember in array)
            {
                //for (int i = 1; i < size - 1; i++)
                for (int i = 1; i < size; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        int temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                }
            }
            
            _resultingArray = array;
        }

        public override string ToString()
        {
            string s = null;
            int i = 0;

            foreach (int member in Result)
            {
                s += "Element number:\t" + i.ToString() + "\tValue:\t" + Result[member].ToString() + "\n";
                i++;
            }

            return s;
        }
    }
}
