using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyNegativeException:Exception    //all exceptions must inherit from Exception(syntax rule)
    {
        internal MyNegativeException() : base("Y is Negative")
        {
        }
    }
}
