using System;
using System.Collections.Generic;
using System.Text;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            //int result;
            Console.WriteLine("Enter number for factorial");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = num-1; i>=1; i--)
            {
                num = num * i;
                
            }
            Console.WriteLine(num);
            Console.ReadLine();
        }
        
    }
}
