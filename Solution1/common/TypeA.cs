using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
   
    public struct TypeA
    {
        int x;
        internal int y;
        public int z;
        public void print()
        {
            Console.WriteLine($"X={x}.");
        }
    }
}
