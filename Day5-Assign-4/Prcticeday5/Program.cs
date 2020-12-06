using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prcticeday5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mypoint m = new Mypoint();
            //// m.x = 100;
            //// m.y = 200;
            // Console.WriteLine(m.x);
            // Console.WriteLine(m.y);
            // Console.ReadLine();
            Display22(TimeofDay.Morning);
            Display22(TimeofDay.Afternoon);
            Console.ReadLine();
         


        }
        static void Display22(TimeofDay t)
        {
            if (t == TimeofDay.Morning)
                Console.WriteLine("Good Morning");
            else if (t == TimeofDay.Afternoon)
                Console.WriteLine("Good Afternoon");
            else if (t == TimeofDay.Evening)
                Console.WriteLine("Good Evening");
            else if (t == TimeofDay.Night)
                Console.WriteLine("Good Night");
        }

    }


    //public struct Mypoint 
    //{
    //    public void Mypoint1(int x,int y) 
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }

    //    public int x, y;

    //}

    
    public enum TimeofDay
    {
        Morning ,
        Afternoon ,
        Evening,
        Night
    }



}
