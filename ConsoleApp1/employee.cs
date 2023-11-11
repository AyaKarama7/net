using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct employee
    {
        public int id;
        string name;//private
        public string getName()
        {
            return name;
        }
        internal void setName(string n)
        {
            this.name = n.Length <= 20 ? n : n.Substring(0, 20);
        }
        decimal salary;
        //property
        public decimal Salary
        {
            get { return salary; }
            internal set { salary = value>=1200?value:1200; }
        }
        public override string ToString()
        {
            return ($"{id}::{name}::{salary}");
            //return ($"{id}::{name}::{Salary}");filtration
        }

    }
}
