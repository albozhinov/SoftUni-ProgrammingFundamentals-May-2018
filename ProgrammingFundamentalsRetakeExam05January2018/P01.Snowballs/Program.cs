using System;
using System.Numerics;


namespace P01.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            BigInteger result = 0;
            int highestsnowballSnow = 0;
            int highestsnowballTime = 0;
            int highestsnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {                
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                

                if (snowballValue > result)
                {
                    highestsnowballSnow = snowballSnow;
                    highestsnowballTime = snowballTime;
                    highestsnowballQuality = snowballQuality;
                    result = snowballValue;
                }
            }
            Console.WriteLine($"{highestsnowballSnow} : {highestsnowballTime} = {result} ({highestsnowballQuality})");
        }
    }
}
