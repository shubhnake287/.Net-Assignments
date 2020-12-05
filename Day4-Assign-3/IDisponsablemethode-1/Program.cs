using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisponsablemethode_1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();//shubham code here is dispose methode called..
            o.Display();
            o.Dispose();
           // o.Display(); this check for dispose is used here ...
            Console.ReadLine(  );
        }

        static void Main(string[] args) 
        {
            using (Class1 o = new Class1()) //just using block it can automatically called the dispose methode
            {
                o.Display();
                
            }
            Console.ReadLine();

        }
    }


    public class Class1:IDisposable
    {
        public void Display() 
        {
            CheckforDispose();
            Console.WriteLine("Display methode()");
        }

        private void CheckforDispose()
        {
            if (isDisposed) {
                throw new ObjectDisposedException("Class1");
            }
        
        
        }

        private bool isDisposed = false;//set a flage false it not called.

        public void Dispose()
        {
            Console.WriteLine("Dispose methode() free the resources");
            isDisposed = true;//we just used the turn to true..
        }
    }
}
