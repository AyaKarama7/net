using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct SeriesBy2 : Iseries
    {
        int c;
        public int Current
        {
            get { return c; }
        }

        public void GetNext()
        {
            c += 2;
        }

        public void Reset()
        {
            c = 0;
        }
    }
}
