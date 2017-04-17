using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class unarydemo
    {
        int x, y, z;
        public unarydemo()
        {
            x = y = z = 0;
        }
        public unarydemo(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }
        public static unarydemo operator -(unarydemo u)
        {
            unarydemo result = new unarydemo();
            result.x = -u.x;
            result.y = -u.y;
            result.z = -u.z;
            return result;
        }
        public void show()
        {
            Console.WriteLine(x + " , " + y + ", " + z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            unarydemo a=new unarydemo(1,2,3);
            unarydemo b=new unarydemo(10,10,10);
            unarydemo c=new unarydemo();
            a.show();
            c = -a;
            c.show();
            c = -b;
            c.show();
            Console.ReadKey();
        }
    }
}
