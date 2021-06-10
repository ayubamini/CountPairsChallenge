using System;
using System.Collections.Generic;

namespace CountPairsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter count of numbers in list/array: ");
            var n = Convert.ToInt32(Console.ReadLine()?.Trim());

            Console.WriteLine("Please, enter list of numbers to find count of pair: ");
            var numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()?.Trim()));
            }

            Console.WriteLine("Please, enter value for k: ");
            var k = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The count of pair(s) number in the list is: ");
            Console.WriteLine(GetCountPairs(numbers, k));
            Console.ReadKey();
        }

        private static int GetCountPairs(List<int> numbersCount, int k)
        {
            var result = 0;

            for (int i = 0; i < numbersCount.Count; i++)
            {
                for (int j = i + 1; j < numbersCount.Count;)
                {
                    if (numbersCount[i] + k == numbersCount[j])
                    {
                        result++;
                    }
                    break;
                }
            }
            return result;
        }
    }
}
