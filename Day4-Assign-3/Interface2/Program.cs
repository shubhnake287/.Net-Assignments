using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.Delete();
            o.Insert();
            o.Update();

            Console.WriteLine("=================");

            IFileFunctions oIFile;
            oIFile = o;
            oIFile.Close();
            oIFile.Open();
            oIFile.Delete();
            Console.ReadLine();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();

    }

    class Class1 : IDbFunctions, IFileFunctions
    {
        public void Delete()
        {
            Console.WriteLine("delete() function IDbFunctions");
        }

        public void Insert()
        {
            Console.WriteLine("Insert() function IDbFunctions");
        }

        public void Update()
        {
            Console.WriteLine("Update() function IDbFunctions");
        }

        void IFileFunctions.Close()
        {
            Console.WriteLine("Close() function IFileFunctions");
        }

        void IFileFunctions.Delete()
        {
            Console.WriteLine("Delete() function IFileFunctions");
        }

        void IFileFunctions.Open()
        {
            Console.WriteLine("Open() function IFileFunctions");
        }
    }






}
