using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] score = new double[3, 3];
            for (int i = 0; i < score.GetLength(0); i++)
            {
                Console.WriteLine("{0}", i + 1);
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    Console.Write("{0}", j + 1);
                    score[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
    }
}
