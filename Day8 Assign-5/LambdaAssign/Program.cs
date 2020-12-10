using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal,decimal,decimal,decimal> o1 = (a,b,c)=> (a * b * c) / 100;
            Console.WriteLine( o1(10,10,10));

            Console.WriteLine("=========================");

            Func<int, int, bool> o2 = (g, h) => (g > h);
            Console.WriteLine(o2(10,20));
            

            Console.WriteLine("=========================");
            Employee emp = new Employee();
            Func<Employee,decimal> o4 = (a) => emp.Getbasic(emp);
            Console.WriteLine( o4(emp));
            Console.WriteLine("=========================");

            Func<int, bool> o6 = (k) => (k%2==0);
            Console.WriteLine(o6(10));
            Console.ReadLine();


           
          
            Console.WriteLine("=========================");
        }


      

    }

    class Employee {
        public decimal basic = 10000;

        public decimal Getbasic(Employee emp)
        {
            return emp.basic;

        }
    
    }


    
}
