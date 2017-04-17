using System;
using System.Collections.Generic;
using System.Text;

namespace swap
{
    class Program
    {
        int num;
        public void display()
        {
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number Is" + num);
        }
    }
    class abc
    {
        static void Main(string[] args)
        {
           Program a = new Program();
            a.display();
            Console.ReadLine();
        }
    }
}
