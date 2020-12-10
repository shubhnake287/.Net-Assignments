using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicitevariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            var j = 200;//implicite methode.
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
