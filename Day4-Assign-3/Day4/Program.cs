using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //methode 1
            Class1 o1 = new Class1();
            o1.delete();
            o1.insert();
            o1.update();
            o1.Display();
            Console.WriteLine("==============================");
            Class2 o2 = new Class2();
            o2.delete();
            o2.insert();
            o2.update();




            //Console.WriteLine("==============================");
            ////methode2
            //IDbFunction oIDb;
            //oIDb = o1;
            //oIDb.delete();
            //oIDb.insert();
            //oIDb.update();
            //Console.WriteLine("==============================");

            ////methode 3 
            //((IDbFunction)o1).update();
            //((IDbFunction)o1).delete();



            Console.ReadLine();
        }
    }

    public interface IDbFunction
    {
        void insert();
        void update();
        void delete();

    }

    public class Class1 : IDbFunction
    {
        public void delete()
        {
            Console.WriteLine("Override delete() function");
        }

        public void Display()
        {
            Console.WriteLine("Display Function is Executed...");
        }

        public void insert()
        {
            Console.WriteLine("Override insert() function");
        }
        public void update()
        {
            Console.WriteLine("Override update() function");
        }
    }

    class Class2 : IDbFunction
    {
        public void delete()
        {
            Console.WriteLine("class-2-Override delete() function");
        }

        public void insert()
        {
            Console.WriteLine("class-2-Override insert() function");
        }
        public void update()
        {
            Console.WriteLine("class-2-Override update() function");
        }
    }







}
