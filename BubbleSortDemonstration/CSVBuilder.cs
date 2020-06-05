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
            //BuildString(_array);
        }
    }
}
