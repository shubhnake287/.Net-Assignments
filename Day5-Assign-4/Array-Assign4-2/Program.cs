using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assign4_2
{
    class Program
    {
        static void Main(string[] args)
        {//Jaggerarray Questions

            Console.Write("Enter the number of batches: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[n][];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter the number of students of batch {0}: ", i);
                int nos = Convert.ToInt32(Console.ReadLine());
                int[] marks = new int[nos];

                Console.Write("Enter the marks of students of batch {0}: ", i);
                for (int j = 0; j < nos; j++)
                {
                    marks[j] = Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = marks;
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("Marks of student of batch {0} : ", i);
                    Console.WriteLine(arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}



namespace Assignment4Q3
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter the Details of Students :");
            Student[] s = new Student[5];
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("RollNo of Students :");
                int rollNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name of Students :");
                string name = Console.ReadLine();
                Console.Write("Marks of Students :");
                decimal marks = Convert.ToDecimal(Console.ReadLine());

                Student s1 = new Student(rollNo, name, marks);
                s[i] = s1;
            }


            for (int i = 0; i < s.Length; i++)
            {
                s[i].Display();
            }


            Console.ReadLine();
        }
    }

    struct Student
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
                if (value != "")
                {
                    name = value;
                }
                else
                    Console.WriteLine("invalid name");
            }
        }


        private int rollNo;

        public int RollNo
        {
            get
            {

                return rollNo;
            }
            set
            {
                if (value != 0)
                {
                    rollNo = value;
                }
                else
                    Console.WriteLine("Invalid RollNo");

            }
        }


        private decimal marks;
        public decimal Marks
        {
            get
            {
                return marks;
            }
            set
            {

                marks = value;

            }
        }

        public Student(int RollNo, string Name, decimal Marks) : this()
        {
            this.Marks = Marks;
            this.RollNo = RollNo;
            this.Name = Name;
        }

        public void Display()
        {
            Console.WriteLine("RollNo :" + RollNo + " " + "Name :" + Name + " " + "Marks :" + Marks);
        }
    }
}
