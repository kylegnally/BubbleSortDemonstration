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
        private string TYPE = "";
        private const string DELIMITER = ",";
        private const string ESCAPE = ",,\n";
        private int[] _array;
        public string CSVString { get; set; }

        public CSVBuilder(int[] arrayToMakeString)
        {
            _array = arrayToMakeString;
        }

        public void BuildString(string loopName, string stringToAdd)
        {
            string str = loopName;
            _csvString = "";
            switch (str)
            {
                    
                //case "Total Computation":
                //    _csvString += "\n" + str + ESCAPE
            }
            if (_csvString == "")
            {
                int colCount = 0;
                _csvString =
                    "OPERATION TYPE" + DELIMITER +
                    "OPERATION TIMESTAMP" + DELIMITER +
                    "OPERATION ELAPSED" + ESCAPE;
            }
            else _csvString += stringToAdd ;
        }
    }
}
