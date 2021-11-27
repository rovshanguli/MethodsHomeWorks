using System;

namespace SumOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOddNumbers(1, 13);
        }
        static void SumOddNumbers(int n , int m)
        {
            int total = 0;
            for (int i = n; i < m; i++)
            {
                
                if (i % 2 == 1)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}
