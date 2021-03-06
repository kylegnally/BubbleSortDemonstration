﻿using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace BubbleSortDemonstration
{
    class ArrayToSort
    {
        private readonly int _size;

        private  int[] _resultingArray;
        private readonly Random _rand;
        private int[] _result;

        public int[] Result
        {
            get { return _result; }
            private set { _result = _resultingArray; }
        }

        public DateTime OuterLoopElapsed { get; set; }
        public DateTime InnerLoopElapsed { get; set; }

        public ArrayToSort(int size, Random r)
        {
            Result = null;
            _size = size;
            _rand = r;
            _resultingArray = new int[_size];
        }

        //private int[] MakeArray(int size, Random rnd)
        //{
        //    for (int i = 0; i < size; i++)
        //    {
        //        _resultingArray[i] = rnd.Next(1, _size + 1);
        //    }

        //    return _resultingArray;
        //}

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

        //public int[] SortArray(int[] array)
        //{
        //    //DateTime start = DateTime.Now;
        //    //DateTime end;
        //    bool sorted = false;
        //    int size = array.Length;

        //    while (!sorted)
        //    {
        //        foreach (int arrayMember in array)
        //        {

        //            for (int i = 1; i < size; i++)
        //            {
        //                if (array[i] <= array[i - 1])
        //                {
        //                    int temp = array[i];
        //                    array[i] = array[i - 1];
        //                    array[i - 1] = temp;
        //                    sorted = true;
        //                }

        //                // size--; this should be different
        //            }

        //            size = size - 1;
        //        }
        //        // end = DateTime.Now;
        //    }
        //    _resultingArray = array;
        //    return Result;
        //}

        //public override string ToString()
        //{
        //    string s = null;
        //    int i = 0;

        //    foreach (int member in Result)
        //    {
        //        s += "Element number:\t" + i.ToString() + "\tValue:\t" + Result[member].ToString() + "\n";
        //        i++;
        //    }

        //    return s;
        //}
    }
}
