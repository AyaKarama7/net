using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Iseries
    {
        int Current { get; }
        void GetNext();
        void Reset();
    }
}
