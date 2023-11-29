using System;

namespace ConsoleApp1
{
    internal class Program { 
    
        public static void process(Iseries series)//refrence from interface for any datatype implement interface
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}, ");
                series.GetNext();
            }
            Console.WriteLine("");
            series.Reset();
        }
        static void Main(string[] args)
        {
            #region Interface
            ////mystruct s = new mystruct();
            ////Console.WriteLine(s.Salary);
            //SeriesBy2 series1 = new SeriesBy2();
            //process(series1);
            //Iseries series2;//refrence to any class/struct that implement Iseries
            //series2 = new Feponacci();//make the refrence point to Feponaci
            //process(series2);

            //int[] arr = { 5, 7, 4, 3, 1, 2, 6 };
            //Array.Sort(arr);
            //foreach(int x in arr)
            //{
            //    Console.WriteLine(x);//x:iteration variable for loop arr[i]
            //    //x read only
            //}

            //employee[] earr = new employee[3]
            //{
            //    new employee(1,"Ahmed Ali",20000),
            //    new employee(2,"Aya Ahmed",27000),
            //    new employee(3,"mohammed",25000)
            //};
            //Array.Sort(earr); 
            ////compiler don't know which values to compare if you don't implementcompare function
            //foreach (var e in earr) Console.Write(e);
            #endregion

            #region ExceptionHandling
            //try
            //{
            //    doSomework();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Main catch");
            //}
            try
            {
                doSomeprotectWork();//protictive programming better than doSomework();
            }
            catch
            {
                Console.WriteLine("main catch");
                //Exception e is not used as i don't need it as i write protictive code
            } 
            #endregion

        }
        public static void doSomework()
        {
            //when runtime error occurs the clr stop, create an object of the type of exception, an pass it to user
            //int x =int.Parse( Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = x / y;
            //Console.WriteLine(z);//if y=0 --> unhandled exception, the program stop
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                if (y < 0) throw new MyNegativeException();
                int z = x / y;
                Console.WriteLine(z);
                string s = Console.ReadLine();
                int a = Convert.ToInt32(s);
                Console.WriteLine(a);
                Console.WriteLine("End of try");
            }
            catch(MyNegativeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            finally
            {
                Console.WriteLine("inside finally");
            }
            Console.WriteLine("End of code");
            //catch optional ,may use more than 1 catch
            //Exception is the parent class of all exceptions whether they are built or you built them
            //when y=0 the clr create an object to the exception 
            //catch take the object and write the message it cotain(Attempt to devide by 0)
            //then the program skip the rest of try and continue the program 
            //the output:
            //Attempt to devide by 0
            //End of code
            //try and catch is the last soldier for protecting code
            //code inside catch block is minimal and correct 
            //order of catch blocks is important-->derived then base 
            //Finally contain some line of code you should implement in any case
            //if unhandled exception occured finally implemented despite the code stop
            //End of Code not printed but inside finally printed
            //Creat my own exception->create class inherit from Exception

        }
        public static void doSomeprotectWork()
        {
            int x, y, z;
            //int.Parse has aproblem that if the data couldn't be parsed it's an exception
            //x = int.Parse(Console.ReadLine());//a--->unhandled exception
            //solution :use TryParse as it return true if the value can be parsed 
            //out x-->give x to compiler and compiler fill it with the value
            do
            {
                Console.WriteLine("Enter x:");
            } while (!int.TryParse(Console.ReadLine(), out x));
            //continue output "Enter x:" until the user input correct format for x
            Console.WriteLine("Enter y:");
            if (!int.TryParse(Console.ReadLine(), out y)||y<=0) Console.WriteLine("Wrong Format");
            else Console.WriteLine(y);//the value entered is assigned to y
            z = x / y;
            Console.WriteLine(z);

        }
    }
}
