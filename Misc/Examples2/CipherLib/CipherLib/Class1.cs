using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;

namespace CipherLib
{
    public class CipherComp:Component
    {
        static int useid = 0;
        int id;
        bool isdisposed;
        FileStream log;

        public CipherComp()
        {
            isdisposed = false;
            try
            {
                log = new FileStream(@"c:\MyLog"+useid+".txt", FileMode.Create);
                id = useid;
                useid++;
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc);
                log = null;
            }
        }
        ~CipherComp()
        {
            Console.WriteLine("Distructor from Componenet" + id);
            Dispose(false);
        }
        public string Encode(string msg)
        {
            string temp = "";
            for (int i = 0; i < msg.Length; i++)
            {
                temp+=(char)(msg[i] + 1);
            }
            for(int i=0;i<temp.Length;i++)
            {
                log.WriteByte((byte)(temp[i]));
            }
            return temp;
        }
        public string Decode(string msg)
        {
            string temp = "";
            for (int i = 0; i < msg.Length; i++)
            {
                temp+=(char)(msg[i] - 1);
            }
            for (int i = 0; i < temp.Length; i++)
            {
                log.WriteByte((byte)(temp[i]));
            }
            return temp;
        }
        protected override void Dispose(bool dispall)
        {
            Console.WriteLine("Dispose(" + dispall + ")for Componenet " + id);
            if (!isdisposed)
            {
                if (dispall)
                {
                    Console.WriteLine("Closing File For " + "Component" + id);
                    log.Close();
                    isdisposed = true;
                }
                base.Dispose(dispall);
            }

        }

    }
}
