using System;
using System.Collections.Generic;
using System.Text;

namespace smallestfactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,num, result;
            result = 1;
            Console.WriteLine("Enter Number");
            num = Int32.Parse(Console.ReadLine());
            for (i = 2; i <= num; i++)
            {
                result = num % i;
                if (result == 0)
                    break;
                
            }
            Console.WriteLine(i);
            Console.ReadLine();
            
        }

    }
}
