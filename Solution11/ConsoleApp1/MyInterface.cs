using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface MyInterface
    {
        void fun1();
        decimal Salary { get; set; }
        
    }
    struct mystruct : MyInterface
    {
        public decimal Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void fun1()
        {
            throw new NotImplementedException();//give you an exception that the function not implemented
        }
    }
}
