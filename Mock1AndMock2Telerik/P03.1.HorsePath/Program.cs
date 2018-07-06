using System;

namespace P03._1.HorsePath
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N,N];
            int counter = 1;
            for (int r = 0; r < matrix.Length; r++)
            {

                for (int c = 0; c < matrix.Length; c++)
                {
                    if (matrix[r,c] != 0)
                    {
                        continue;
                    }
                    int row = r;
                    int col = c;
                    while (true)
                    {
                        matrix[row, col] = counter;
                        counter++;





                    }



                }




            }


        }
    }
}
