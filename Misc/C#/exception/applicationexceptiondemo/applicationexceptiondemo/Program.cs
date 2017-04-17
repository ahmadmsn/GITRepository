using System;
using System.Collections.Generic;
using System.Text;

namespace applicationexceptiondemo
{
    class myexception:ApplicationException
    {
        public myexception():base()
        {}
        public myexception (string str) : base(str)
        {}
        public override string  ToString()
        {
               return ("Attempt to divide by 2 is invalid operation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 50;
            for(int k=0; k<10; k++)
            {
                try
                {
                    if (k == 2)
                    {
                        throw new myexception();
                    }
                    Console.WriteLine("divide number is " + i + " by "+k + " "+ i/k);
                   
                }
                catch(DivideByZeroException exc)
                {
                    Console.WriteLine(exc);
                }
                catch(myexception e)
                {
                    Console.WriteLine(e);
                }
               
            }
            Console.ReadKey();
        }
    }
}
