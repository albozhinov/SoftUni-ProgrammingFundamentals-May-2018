using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace P01.ConvertFromBase10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var firstNum = int.Parse(input[0]);
            var secNum = BigInteger.Parse(input[1]);
            string result = null;
            BigInteger currNum;
            
            while (secNum != 0)
            {
                currNum = secNum % firstNum;
                result = currNum.ToString() + result;
                secNum /= firstNum;
            }           
            

            Console.WriteLine(result);
        } 
    }
}
