using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct employee:IComparable  //implemented to use compare function
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
        //ret + if this > obj
        //ret - if this < obj
        //ret 0 if this = 0
        //items[j].CompareTo(items[j+1])
        //items[j]=this/phantom
        //items[j+1]=obj
        public int CompareTo(object obj)
        {
            employee emp = (employee)obj; //unboxing
            //if (salary > emp.salary) return 1;
            //else if (salary < emp.salary) return -1;
            //else return 0;
            //as all base class types (int,..) implement compare function you can do so:
            return salary.CompareTo(emp.salary);
            //Array.Sort-->sort function cal CompareTo()
        }

        public employee(int d,string n,decimal s)//ctor to easily help creating array of employees
        {
            id = d;
            name = n;
            salary = s;
        }

    }
}
