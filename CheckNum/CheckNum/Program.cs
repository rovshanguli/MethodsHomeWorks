using System;

namespace MethodsPracties
{
    class Program
    {
        static void Main(string[] args)
        {
            Check(67);
        }

        static void Check(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("N 3 ve 7 -ye bolunur ");
            }
            else
            {
                Console.WriteLine("N 3 ve ya 7 -ye bolunmur ");
            }
        }
    }
}
