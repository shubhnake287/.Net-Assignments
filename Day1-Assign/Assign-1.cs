﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("shubh",123,10);
            Console.WriteLine("Acept");
            Console.WriteLine("========================");


            Employee o2 = new Employee("shubh", 123);
            Console.WriteLine("Deptno");
            Console.WriteLine("========================");

            Employee o3 = new Employee("shubh");
            Console.WriteLine("Basic and Depno");
            Console.WriteLine("========================");

            Employee o4 = new Employee();
            Console.WriteLine(" Accepted!");
            Console.WriteLine("========================");

            Console.WriteLine("Empno : " + o1.EmpNo);
            Console.WriteLine("Empno : " + o2.EmpNo);
            Console.WriteLine("Empno : " + o3.EmpNo);
            Console.WriteLine("Empno : " + o4.EmpNo);
            Console.WriteLine("========================");
            Console.WriteLine("Empno : " + o4.EmpNo);
            Console.WriteLine("Empno : " + o3.EmpNo);
            Console.WriteLine("Empno : " + o2.EmpNo);
            Console.WriteLine("Empno : " + o1.EmpNo);
            Console.ReadLine(  );
        }
    }

    public class Employee {
        //Properties
        //string Name -> no blank names should be allowed
        private string name;
        private string Name {
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name not be null");
                }
            
            }

            get 
            {
                return name;
            
            }
        }


        //Properties
        //int EmpNo -> must be readonly and autogenerated

        private static int empnoC = 0;
        private int empno;
        public int EmpNo
        {
            get
            {
                return empno;
            }
        }

        //Properties
        //decimal Basic -> must be between some range
        private decimal basic;
        public decimal Basic {

            set
            {
                if (value > 10000 && value < 50000)
                {

                    basic = value;
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
            get
            {
                return basic;
            }
        
        
        }


        //Properties
        //short DeptNo -> must be > 0

        private short depNo;
        public short DepNo {
            set
            {
                if (value > 0)
                {
                    depNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid deptNo");
                }
            
            }
        
        }

        //Methode
        public decimal GetNetSalary() {
            decimal salary;
            salary = basic + (basic * 10);
            return salary;
        
        }

        public Employee(string Name = null, decimal Basic = 0, short DepNo = 0)
        {
            empnoC++;
            empno = empnoC;
            this.Name = Name;
            this.Basic = Basic;
            this.DepNo = DepNo;


        }
    }
}