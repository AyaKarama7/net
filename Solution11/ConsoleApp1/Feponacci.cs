using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Feponacci : Iseries
    {
        int c ,p;
        public Feponacci() { c = 0;p = 1; }//cunstroctor
        public int Current
        {
            get { return c; }
        }
        public void GetNext()
        {
            int temp = c;
            c += p;
            p = temp;
        }

        public void Reset() { c = 0; p = 1; }
    }
}
