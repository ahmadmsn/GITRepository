using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class operatoroverdemo
    {
        int x,y,z;
        public operatoroverdemo()
        {
            int x=y=z=0;
        }
        public operatoroverdemo(int i,int j, int k)
        {
            x=i;
            y=j;
            z=k;
        }
        public static operatoroverdemo operator +(operatoroverdemo op1,operatoroverdemo op2)
        {
            operatoroverdemo r=new operatoroverdemo();
            r.x=op1.x + op2.x;
            r.y=op1.y + op2.y;
            r.z=op1.z + op2.z;
            return r;
        }
        public static operatoroverdemo operator -(operatoroverdemo op1, operatoroverdemo op2)
        {
            operatoroverdemo r=new operatoroverdemo();
            r.x=op1.x - op2.x;
            r.y=op1.y - op2.y;
            r.z=op1.z - op2.z;
            return r;
        }
        public static operatoroverdemo operator ++ (operatoroverdemo op1)
        {
            op1.x ++;
            op1.y ++;
            op1.z ++;
            return op1;
        }
        public static operatoroverdemo operator -(operatoroverdemo op1)
        {
            operatoroverdemo r=new operatoroverdemo();
            r.x=-op1.x;
            r.y=-op1.y;
            r.z=-op1.z;
            return r;
        }
        public void show()
        {
               Console.WriteLine(x+ ", "+y+ " , "+z);
        }

    class Program
    {
        static void Main(string[] args)
        {
            operatoroverdemo a = new operatoroverdemo(1, 2, 3);
            operatoroverdemo b = new operatoroverdemo(10, 10, 10);
            operatoroverdemo c = new operatoroverdemo();
            a.show();
            b.show();
            c = a + b;
            c.show();
            c = -a;
            c.show();
            c = b - a;
            c.show();
            Console.ReadKey();
        }
        


        }
    }
}
