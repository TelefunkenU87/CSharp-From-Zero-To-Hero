﻿using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testArr = null;
            //int[] testArr = new int[0];
            int[] testArr = new int[5] {0, 1, 2, 3, 4};
            //int[] testArr = new int[5] { 5, 4, 3, 2, 1};
            //int[] testArr = new int[5] { 3, 10, 3, 2, 0 };
            int[] returnArr = new int[6];


            //ArrayOperations.Sort(testArr);
            //ArrayOperations.Reverse(testArr);
            //returnArr = ArrayOperations.RemoveAt(testArr, 2);
            //returnArr = ArrayOperations.RemoveFirst(testArr);
            //returnArr = ArrayOperations.RemoveLast(testArr);
            //returnArr = ArrayOperations.InsertAt(testArr, 99, 4);
            //returnArr = ArrayOperations.InsertFirst(testArr, 99);
            returnArr = ArrayOperations.InsertLast(testArr, 99);

            //Array.ForEach(testArr, Console.WriteLine);
            Array.ForEach(returnArr, Console.WriteLine);
        }
    }
}
