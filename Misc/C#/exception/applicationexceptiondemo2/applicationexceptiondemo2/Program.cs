using System;
using System.Collections.Generic;
using System.Text;

namespace applicationexceptiondemo2
{
    class myexception2 : ApplicationException
    {
        public myexception2()
            : base()
        { }
        public myexception2(string str)
            : base(str)
        { }
        public override string ToString()
        {
            return("Invalid Operation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 50;
            for (int k = 0; k < 10; k++)
            {
                try
                {
                    if ((k % 2) !=0)
                    {
                        throw new myexception2();
                    }
                    Console.WriteLine("Division" + i + " " + k + " " + "is" + i / k);
                }
                catch (DivideByZeroException exc)
                {
                    Console.WriteLine(exc);
                }
                catch (myexception2 e)
                {
                    Console.WriteLine(e);
                }
            }
            Console.ReadKey();
        }
    }
}
