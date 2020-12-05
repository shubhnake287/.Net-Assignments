using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refandvaluetypesin.netcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            Init(out i, out j);//with using init out is just changes made in code reflect in original code..
            Swap(ref i, ref j);// they just does not required incial value...


            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();
        }
        static void Swap(ref int i, ref int j)//in this function the value swap..
        
        {
            int temp = i;
            i = j;
            j = temp;

        }

    static void Init(out int i, out int j)
        {
            i = 100;
            j = 200;

        }
    }
}
