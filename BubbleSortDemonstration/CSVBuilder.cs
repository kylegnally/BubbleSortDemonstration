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
        private string _COL_DELIMITER = ",";
        private const string _COLESCAPE = ",,";
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
            for (int i = 0; i < array.Result.Length; i++)
            {
                // if this is the first row, make the column headers
                if (i == 0)
                {
                    _csvString = 
                        "OPERATION TYPE" + _COL_DELIMITER + 
                        "OPERATION TIMESTAMP" + _COL_DELIMITER + 
                        "OPERATION ELAPSED" + _COLESCAPE;
                }
                //_csvString += "\n" + array.Result[i]
            }
        }
    }
}
