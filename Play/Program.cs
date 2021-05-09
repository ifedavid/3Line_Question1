using System;
using System.Collections.Generic;

namespace Play
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! baby.");

            Console.Read();
        }
    }

    public class Question1
    {

        public int DifferentNumber(int[] array)
        {

            if (array.Length == 0) return 1;

            HashSet<int> mySet = new HashSet<int>();


            //Load all data in the array into a hashSet
            foreach (int item in array)
            {
                mySet.Add(item);
            }


            //Find the minimum +ive element in O(n) time.
            for (int i = 1; i < array.Length + 1; i++)
            {
                if (!mySet.Contains(i))
                {
                    return i;
                }
            }

            return 1;

        }
    }
}
