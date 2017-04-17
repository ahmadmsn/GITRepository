using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Table
    {
        static void Main(string[] args)
        {
            int i, j,div;
            Console.WriteLine("Enter number for multipication");
            i = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= 10; j++)
            {
                div = i * j;
                Console.WriteLine(i +" * "+ j +" = "+div);
            } Console.ReadLine();
            
        }
    }
}
