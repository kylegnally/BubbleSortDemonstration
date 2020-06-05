using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDemonstration
{
    class CSVBuilder
    {
        private string _csvString;
        private string _delimiter = ",";
        private ArrayToSort _array;
        public string CSVString { get; set; }

        public CSVBuilder(ArrayToSort arrayToMakeString)
        {
            _array = arrayToMakeString;
            _csvString = "";
            BuildString(arrayToMakeString);
        }

        private void BuildString(ArrayToSort array)
        {
            _csvString = "";
            for (int i = 0; i < array.; i++)
            {
                // if this is the first row
                if (i == 0)
                {
                    _csvString = "OPERATION TYPE,OPERATION TIMESTAMP,OPERATION ELAPSED,,";
                }
                _csvString += "\n" + array.SortedArray[i]
            }
        }
    }
}
