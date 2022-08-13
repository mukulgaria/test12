using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 14, 5, 2, 4, 6, 7 };
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]] += 1;
                }
            }

            foreach(var i in dict)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

        }
    }
}
