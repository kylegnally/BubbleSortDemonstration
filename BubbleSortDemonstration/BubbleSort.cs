//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BubbleSortDemonstration
//{
//    class BubbleSort
//    {
//        private int[] _arrayToSort;
//        private int _size;
//        private bool _swapped;

//        public BubbleSort(int[] array)
//        {
//            _arrayToSort = null;
//            _size = 0;
//            _swapped = false;
//            SortArray(_arrayToSort);
//        }

//        public BubbleSort()
//        {

//        }

//        private bool SortArray(int[] array)
//        {
//            _arrayToSort = array;
//            _size = _arrayToSort.Length;
//            int temp;
//            while (_swapped == false)
//            {
//                for (int i = 1; i <= _size - 1; i++)
//                {
//                    if (_arrayToSort[i - 1] > _arrayToSort[i])
//                    {
//                        temp = _arrayToSort[i];
//                        _arrayToSort[i] = _arrayToSort[i - 1];
//                        _arrayToSort[i - 1] = temp;
//                        _swapped = true;
//                    }
//                }

//                _size--;
//            }

//            return true;
//        }
//    }
//}
