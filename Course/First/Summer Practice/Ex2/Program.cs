using System;

namespace Ex2
{
    class Program
    {
        private const int I = 20;
        private const int J = 20;

        static void Main(string[] args)
        {
            var array = new int[I, J];
            FillArray(array);

            int flag, rowCount = 0;
   
            for (var i = 0; i < I; i++)
            {
                flag = 0;
                for (var j = 0; j < J; j++)
                {
                    if (array[i, j] == array[i, j + 1]) 
                        flag = 1;
                }

                if (flag != 1)
                    rowCount++;
            }

            Console.WriteLine($"Row count: {rowCount}");
        }

        private static void FillArray(int[,] array)
        {
            var random = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 10; j++)
                   array[i, j] = random.Next(100);
        }
    }
}
