using System;
using System.Collections.Generic;
using System.Text;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int temp=0;
            Console.WriteLine("ENTER NUMBER");
            num1 = Convert.ToInt32(Console.ReadLine());
            for (int x = 1; x <= num1; x++)
            {
                int counter = 0;
                for (int y = 2; y < x; y++)
                {
                    temp = x % y;
                    if (temp == 0)
                    counter = counter + 1;
                }
                if (counter == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
