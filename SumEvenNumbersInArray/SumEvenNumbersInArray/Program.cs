using System;

namespace SumEvenNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 1, 23, 43, 56, 78, 34, 67 };
            SumEvenNumbers(numbers);
        }
        static void SumEvenNumbers(int[] SelectNum)
        {
            var sum = 0;
            for (int i = 0; i < SelectNum.Length; i++)
            {
                if (SelectNum[i] % 2 == 0)
                {
                    sum = sum + SelectNum[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
