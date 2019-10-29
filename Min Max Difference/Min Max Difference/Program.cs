using System;
using System.Collections.Generic;


namespace Min_Max_Difference
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] sampleNums = { 15, 22, 84, 14, 88, 23 };
            List<int> intlist = new List<int>(sampleNums);
            Console.WriteLine(findSmallest(intlist));
            Console.WriteLine(findBiggest(intlist));
            Console.WriteLine(findDifference(intlist));
            Console.ReadLine();
        }

        static int findSmallest(List<int> intlist)
        {
            int currentSmallest = intlist[0];
            foreach (int num in intlist)
            {
                if(num < currentSmallest)
                {
                    currentSmallest = num;
                }
            }
            return currentSmallest;
        }
        static int findBiggest(List<int> intlist)
        {
            int currentBiggest = intlist[0];
            foreach (int num in intlist)
            {
                if (num > currentBiggest)
                {
                    currentBiggest = num;
                }
            }
            return currentBiggest;
        }
        static int findDifference(List<int> intlist)
        {
            int smallest = findSmallest(intlist);
            int biggest = findBiggest(intlist);
            int difference = biggest - smallest;
            return difference;
        }
    }
}
