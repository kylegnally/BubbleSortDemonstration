using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDemonstration
{
    class RequiredSorting
    {
        private int[] _array;
        private string[,] _operationResults;
        private CSVBuilder _builder;

        public int[] SortedArray { get; set; }

        public string OperationName { get; set; }
        public string OperationDuration { get; set; }

        public RequiredSorting(int[] array)
        {
            SortedArray = SortArray(array);
            //CSVBuilder builder = new CSVBuilder(array);
        }

        private int[] SortArray(int[] array)
        {
            DateTime _singleLoop;
            DateTime _singleComparison;
            DateTime _singleSwap;

            TimeSpan ts;

            string loopString;
            int k, l ;
            //_operationResults = new string[array.Length,array.Length];
            bool sorted = false;
            int size = array.Length;
            while (!sorted)
            {
                int loopCounter = 0;
                DateTime _operationStartTime = DateTime.Now;
                foreach (int arrayMember in array)
                {
                    loopString = "Total Computation";
                    k = 0;
                    for (int i = 1; i < size; i++)
                    {
                        loopString = "Array Member Loop";
                        l = i;
                        if (array[i] <= array[i - 1])
                        {
                            loopString = "Single Swap";
                            int temp = array[i];
                            array[i] = array[i - 1];
                            array[i - 1] = temp;
                            sorted = true;
                            _singleSwap = DateTime.Now;
                            OperationName = loopString;
                            OperationDuration = CalcTime(_operationStartTime, DateTime.Now).ToString();
                            ts = _singleSwap.Subtract(_operationStartTime);
                        }
                    }

                    k++;
                    _singleComparison = DateTime.Now;
                    ts = _singleComparison.Subtract(_operationStartTime);
                    size = size - 1;
                }
                _singleLoop = DateTime.Now;
                ts = _singleLoop.Subtract(_operationStartTime);
            }
            _array = array;

            // each operation duration will be added here with its name
            // this is a string[,]
            
            return SortedArray;
        }

        private TimeSpan CalcTime(DateTime operationStartTime, DateTime operationEndTime)
        {
            TimeSpan ts = operationStartTime.Subtract(operationEndTime);
            return ts;
        }
    }
}
