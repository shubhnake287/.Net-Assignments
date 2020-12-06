using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {

            //MyPoint m = new MyPoint();
            
            //Console.WriteLine(m.X);
            //Console.WriteLine(m.Y);
            //Console.ReadLine();

            Display2(TimeOfDay.Morning);
            Display2(TimeOfDay.Afternoon);
            Console.ReadLine();

        }

        static void Display2(TimeOfDay t)
        {
            if (t == TimeOfDay.Morning)
                Console.WriteLine("Good Morning");
            else if (t == TimeOfDay.Afternoon)
                Console.WriteLine("Good Afternoon");
            else if (t == TimeOfDay.Evening)
                Console.WriteLine("Good Evening");
            else if (t == TimeOfDay.Night)
                Console.WriteLine("Good Night");
        }
    }

   



    public enum TimeOfDay //: long
    {
        Morning = 100,
        Afternoon = 200,
        Evening,
        Night
    }
    public struct MyPoint
    {

        public MyPoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public int X, Y;
    }
}
