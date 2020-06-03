using System;

namespace BubbleSortDemonstration
{
    class ArrayToSort
    {
        private readonly int _size;
        private readonly int[] _resultingArray;
        private readonly Random _rand;
        public int[] Result { get; private set; }

        public ArrayToSort(int size, Random r)
        {
            _size = size;
            _rand = r;
            _resultingArray = new int[_size];
            MakeArray(_rand);
        }

        private void MakeArray(Random rnd)
        {
            for (int i = 0; i < _size; i++)
            {
                _resultingArray[i] = rnd.Next(_size);
            }
            Result = _resultingArray;
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
