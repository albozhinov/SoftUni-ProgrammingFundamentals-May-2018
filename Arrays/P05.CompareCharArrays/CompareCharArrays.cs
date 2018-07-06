using System;
using System.Linq;

namespace P05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool isFirst = false;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] < arr2[i])
                {
                    isFirst = true;
                    break;
                }
                else if (arr1[i] > arr2[i])
                {
                    isFirst = false;
                    break;
                }
                if (i == Math.Min(arr1.Length, arr2.Length) - 1)
                {
                    if (arr1.Length <= arr2.Length)
                    {
                        isFirst = true;
                    }
                    else if (arr1.Length > arr2.Length)
                    {
                        isFirst = false;
                    }                    
                }
            }
            if (isFirst)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
        }
    }
}
