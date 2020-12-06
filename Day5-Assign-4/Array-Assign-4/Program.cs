using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assign_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the empoyee info");
            Employee[] arr = new Employee[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter the Employee Name");
                string name = Console.ReadLine();
                Console.Write("Enter the Basic");
                decimal basic = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Dept No :");
                short deptNo = short.Parse(Console.ReadLine());
                Employee e1 = new Employee(name, basic, deptNo);
                arr[i] = e1;

            }

            Console.WriteLine("Enter EmpId you want the details of Employee");
            int empId = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (empId == arr[i].EmpNo)
                {
                   
                    arr[i].Display();
                }
            }


            decimal max = arr[0].Basic;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Basic > max)
                {
                    max = arr[i].Basic;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Basic == max)
                {
                    Console.WriteLine("Max Salary: " + arr[i].Basic);
                }
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Not valid Name!!!");
                
                }
            
            }
        
        }

        private static int auto;
        private int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                    Console.WriteLine("Dept No must be greater than 0");
            }
            get
            {
                return deptNo;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set;
            get;
        }

        public decimal GetNetSalary()
        {
            return basic + 1000 + 1000;
        }

        public Employee(string name, decimal basic, short deptno)
        {
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptno;
            auto++;
            this.empNo = auto;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name + " " + "Basic: " + Basic + " " + "Dept No: " + DeptNo);
        }






    }
}
