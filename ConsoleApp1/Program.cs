using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region property
            employee e = new employee();
            //pros & cons of using public attributes versus privates and setter & getters

            //advantage of public attributes=you can use them easily
            e.id = 1;
            Console.WriteLine(e.id);
            //disadvantage of public attributes:code become titly copied
            //if you change name of var or any thing you should change it in the whole code
            //you can't filter values (if user input -10 for id it is accepted)
            //you can't manage access:you can't make read public and write private

            //solution1:encapsulation-->setters,getters
            //advantages:solve all problems of publics
            //disadvantages:usage form not straight forward:form for setting another one for getting
            e.setName("Aya Ahmed");
            Console.WriteLine(e.getName());

            //solution2:setters and gettes+the same form of writting attributes (property)-->improve the form of code writing only
            //property:is a collection of methods that has all featuers of methods
            //ther is no proberty overloading as it working with a single input paramter
            e.Salary = 10000;
            Console.WriteLine(e.Salary);
            #endregion

            //indexing :a paramter that take more than one input parameter
            phoneBook p = new phoneBook(5);
            p.SetEntry(0, "ABC", 123);
            p.SetEntry(1, "DEF", 5678);
            p.SetEntry(2, "XYZ", 6750);
            Console.WriteLine(p.GetNumber("DEF"));
            p["ABC"] = 999;
            Console.WriteLine(p["ABC"]);
            //overloading is avaliable
            Console.WriteLine(p[2]);
            p[3, "Aya"] = 1234;
            for(int i=0;i<p.Size;i++)Console.WriteLine($"{p[i]}");
            string s = "1234";
            if (s[0] == '1') ;//indexer
            //s[0] = 2;readonly indexer
        }
    }
}