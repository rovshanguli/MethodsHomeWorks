using System;

namespace SimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleNumbers(121);
        }

        static void SimpleNumbers(int n)
        {
            if(n == 0 || n == 1)
            {
                Console.WriteLine("Please Enter Correct Number");
            }
            else
            {
                var m = 0;
                for(int i = 2; i < n ; i++)
                {
                    if (n % i == 0)
                    {
                        m = m + 1;
                    }
                }
                if (m > 0)
                {
                    Console.WriteLine("N sade eded deyil");
                }
                else
                {
                    Console.WriteLine("N sade ededdir");
                }
                 
            }
            
        }
    }
}
