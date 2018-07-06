using System;
using System.Linq;

namespace P04.LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ')
                                         .Select(int.Parse)
                                         .ToArray();
            var len = new int[nums.Length];
            len[0] = 1;
            int[] prev = new int[nums.Length];
            prev[0] = -1;
            int maxLen = 0;
            int lastIndex = 0;

            for (int x = 1; x < nums.Length; x++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (nums[x] > nums[i] && len[x] <= len[i])
                    {
                        len[x] = len[i] + 1;                                         prev[x] = i;      
                    }                   
                }

                if (len[x] > maxLen)
                {
                    maxLen = len[x];
                    lastIndex = x;
                }
                
                
            }
        }
    }
}
