using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main1(string[] args)
        {
            Action o1 = display;
            o1();
            Action <string>o2 = display;
            o2("shubham");
            Console.ReadLine();
        }


        static void Main2(string[] args) 
        {
            Func<int, int, int> o1 = Add;
            Console.WriteLine(o1(10, 20));

            Func<int, string, int> o2 = Dosomething;
            Console.WriteLine(o2(10,"shubham"));

            Console.WriteLine("======================");
            Predicate<int> o3 = Iseven;
            Console.WriteLine(o3(10));
            Console.ReadLine();
        
        }

        static void Main(string[] args) {
            int i = 10;
            Action o = delegate
            {

                Console.WriteLine("Display()");
                i++;
            };
            Console.WriteLine(i);
            o();
            o();
            o();
            o();
            Console.WriteLine(i);
            Console.ReadLine(  );
        }



        static void display()
        {

            Console.WriteLine("Display()");
        }

        static void display(string s)
        {

            Console.WriteLine("Display()"+s);
        }

        static int Add(int x,int y) {
            return x + y;
        }

        static int Dosomething(int x ,string name) {
            return x;
            
        }

        static bool Iseven(int g) {
            return g % 2 == 0;
        }

    }

    
}
