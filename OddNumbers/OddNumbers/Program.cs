using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            OddNumbers(5, 2222222);
        }

        static void OddNumbers(int n , int m)
        {
            int count = 0;
            for (int i  = n; i < m ; i++ )
            {
                if (i % 2 == 1)
                {
                    
                    count++;
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}
