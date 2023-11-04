using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;//syntax sugar
using System.Diagnostics.CodeAnalysis;
using common;

namespace ConsoleApp1
{
    enum grades { a,b,c};
    internal class Program
    {
       
        static void Main(string[] args)
        {
            point p1;//reserve 8 bytes in stack
            point p2=new point(2,3);//call UD cstor , 8 byte reserved in stack,new to catch cstor only
            grades g = grades.b;
            if (g == grades.a) Console.WriteLine("yes");

        }
    }
}