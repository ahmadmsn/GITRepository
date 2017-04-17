using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Interface
{
    public abstract class AbstractInterface
    {
        public abstract int add();
        public int substract()
        {
            int i, j, k;
            i = 10;
            j = 20;
            return k = j - i;
        }

       

    }
    interface iFly
    {
        string kite();
        string Aeroplane();
    }

    public class ImplementClass : AbstractInterface, iFly
    {
        public override int add()
        {
            int i, j, k;
            i = 10;
            j = 20;
            return k = i + j;
        }
        #region iFly Members

        string iFly.kite()
        {
            return "kite";
        }

        string iFly.Aeroplane()
        {
            return "Aerplane";
        }

        #endregion

        public void callInterface(iFly oiFly)
        {
            oiFly.kite();
            oiFly.Aeroplane();
        }
    }



}
