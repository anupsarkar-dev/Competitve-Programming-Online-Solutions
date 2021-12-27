using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Reverse(2147483647));
            

        }

        public static int Reverse(int x)
        {
            double n = 0;

            bool isNegative = x < 0;

            if (x == int.MinValue || x == int.MaxValue) 
                return 0;
            else 
                x = Math.Abs(x);
         
            while (x > 0)
            {              
                n = (n * 10) + (x % 10);              
                x = x / 10;          
            }

            if(n > Int32.MaxValue)
            {
                return 0;
            }

            return  isNegative ? (int) -n : (int) n;
        }
    }
}
