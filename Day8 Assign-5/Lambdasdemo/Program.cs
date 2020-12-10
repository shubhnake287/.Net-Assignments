using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdasdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> o = MakedoubleFun;
            //Console.WriteLine( o(10));


            Func<int, int> o = x => x * 2;
            Console.WriteLine("Lambda  : "+o(10));

            Func<int, int> o1 = delegate (int a)
             {
                 return a * 2;
             };

            Console.WriteLine(o(10));//Annonimas class for that we just have lambda


            Console.WriteLine("=====================");

            Func<int, int, int> obj = (a, b) => a + b;
            Console.WriteLine(obj(10,20));
            Console.ReadLine();
        }

        static int MakedoubleFun(int a) 
        {
            return a * 2;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
