using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_15._04._11
{
    class MyClass
    {
        int nAlpha, nBeta;
        public MyClass(int i, int j)
        {
            nAlpha = i;
            nBeta = j;
        }
        public bool sameAs(MyClass ob)
        {
            if ((ob.nAlpha == nAlpha) & (ob.nBeta == nBeta))
            {
                return true;
            }
            else
                return false;
        }
        public void copy(MyClass ob)
        {
            nAlpha = ob.nAlpha;
            nBeta = ob.nBeta;
        }
        public string show()
        {
            string strShow = string.Empty;
            strShow = string.Format("alpha: {0}, beta: {1}", nAlpha, nBeta);
            return strShow;
            //Console.WriteLine("alpha: {0}, beta: {1}", nAlpha, nBeta);
        }
    }
}
