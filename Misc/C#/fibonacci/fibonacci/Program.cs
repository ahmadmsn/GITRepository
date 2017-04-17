using System;
using System.Collections.Generic;
using System.Text;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            //Console.WriteLine("Enter Number For Fibonacci");
            //i = Convert.ToInt32(Console.ReadLine());
            
           i=j=1;
            Console.WriteLine(i);
            for(k=1;k<=20;k++)
            {
                Console.WriteLine(j);
                j=j+i;
                i= j - i;
            }
            Console.ReadLine();
        }
    }
}
