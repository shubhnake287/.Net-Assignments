using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraydemo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //array class s a abstract class
           

            // array class
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("element are in {0} :",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());//console.readline convert into string heance it required to convert in total 32

            }
            //Array.Clear(arr,0,5); it just give u the default value 
            //arr copy (arr,arr2,5);
            // Array.ConstrainedCopy();
            //int pos = Array.IndexOf(arr,10);//its not found then -1 return
            //Console.WriteLine( pos);

            //int pos = Array.LastIndexOf(arr, 10);//its not found then -1 return
            //Console.WriteLine(pos);

            //int pos = Array.BinarySearch(arr, 10);//its not found then -1 return
            //Console.WriteLine(pos);
            //Array.Reverse(arr);
            //Console.WriteLine(arr);
            //Array.Sort(arr);
            //Console.WriteLine( arr);

            foreach (int x in arr)
            {
                Console.WriteLine("value in {0} :",x);

            }
            Console.ReadLine();




        
            
        }


    }
}
