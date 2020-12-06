using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntegerStack o = new IntegerStack(3);
            //o.Push(10);
            //o.Push(20);
            //o.Push(30);

            //Console.WriteLine(o.Pop());
            //Console.WriteLine(o.Pop());
            //Console.WriteLine(o.Pop());

            MyStack<int> m = new MyStack<int>(3);
            m.Push(10);
            m.Push(20);
            m.Push(30);

            Console.WriteLine(m.Pop());
            Console.WriteLine(m.Pop());
            Console.WriteLine(m.Pop());

            MyStack<string> o2 = new MyStack<string>(5);
            o2.Push("1");
            o2.Push("12");
            o2.Push("123");
            Console.WriteLine(o2.Pop());
            Console.WriteLine(o2.Pop());
            Console.WriteLine(o2.Pop());



            Console.ReadLine(  );

        }
    }

    //class MYOperation<S> 
    //{
    //    public static void Swap(ref S i ,ref S j) //GENERIC function its like a template in cpp 
    //    {
    //        S temp = i;
    //        i = j;
    //        j = temp;
        
    //    }
    
    //}


    //class ShortOperation
    //{
    //    public static void Swap(ref short i, ref short j)
    //    {
    //        short temp = i;
    //        i = j;
    //        j = temp;

    //    }

    //}

    //class IntegerStack
    //{
    //    int[] arr;
    //    public IntegerStack(int Size)
    //    {
    //        arr = new int[Size];
    //    }
    //    int Pos = -1;
    //    public void Push(int i)
    //    {
    //        if (Pos == (arr.Length - 1))
    //            throw new Exception("Stack full");
    //        arr[++Pos] = i;
    //    }
    //    public int Pop()
    //    {
    //        if (Pos == -1)
    //            throw new Exception("Stack Empty");
    //        return arr[Pos--];
    //    }
    //}


    class MyStack<T>
    {
        T[] arr;
        public MyStack(int Size)
        {
            arr = new T[Size];
        }
        int Pos = -1;
        public void Push(T i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public T Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }




}
