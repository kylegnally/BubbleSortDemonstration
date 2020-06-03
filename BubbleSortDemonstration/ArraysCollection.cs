using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDemonstration
{
    class ArraysCollection
    {
        private ArrayToSort _anArray;
        private List<ArrayToSort> _collection;

        public List<ArrayToSort> Collection { get; set; }

        public ArraysCollection()
        {
            _anArray = null;
            _collection = new List<ArrayToSort>();
        }
        public ArraysCollection(ArrayToSort arrayToSort)
        {
            _anArray = arrayToSort;
            Add(_anArray);
        }

        public void Add(ArrayToSort arrayToSort)
        {
            if (_collection != null)
            {
                _collection.Add(arrayToSort);
                Collection = _collection;
            }
        }
    }
}
