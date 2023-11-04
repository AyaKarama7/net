using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct point
    {
        int x,y;
        //user defined constructor for struct
        public point(int _x,int _y)
        {
            x = _x;
            y = _y;
            //in c# any user defined constructor must intialize all attributes in struct
            //you must intialize x & y not only x or y.
            //but classes stored in heap so it take intial value by default
        }
        public point(int n)
        {
            x = y = n;
        }
        //you can't generate parameterless cstor as it is by default intialized by compiler
        //public point()
        //{
        //    x = y = 0;
        //}
        //override function ToString in system.object as struct inherit from it.
        public override string ToString()
        {
            return ($"x={x},y={y}");
        }
    }
}
