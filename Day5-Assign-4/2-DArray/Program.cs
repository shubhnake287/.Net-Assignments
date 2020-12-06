using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[5,3];

            Console.WriteLine( arr.Length);
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine( arr.GetLength(1));
            Console.WriteLine(arr.Rank);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter the element  {0} and subject {1} : ",i,j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
            //foreach (int x in arr )
            //{
            //    Console.WriteLine("the values in {0} : ", x);

            //}

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter the element  {0} and subject {1} {2}: ", i, j , arr[i,j]);
                    
                }
                
            }
            Console.ReadLine();

        }
    }
}
