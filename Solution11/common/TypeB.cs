using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class TypeB
    {
        public TypeB()
        {
            TypeA obj;
            obj.y = obj.z = 2;
            //obj.x; not accessable.
        }
    }
}
