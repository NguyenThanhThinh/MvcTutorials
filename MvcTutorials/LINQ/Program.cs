using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("demo :\n");
            int[] arr = new int[] { 4, 6, 9, 20, 21, 22, 23 ,25};
            /* var searchArr = arr.Where(n => n % 2 != 0);
             foreach (var item in searchArr)
             {
                 Console.WriteLine("number is {0} ", +item);

             }
             */
            List<int> listArr = new List<int>();
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] % 2 != 0)
                {
                    listArr.Add(arr[i]);
                }

            }
            /*foreach (var number in listArr)
            {
                Console.WriteLine("number is {0} ", +number);
            }*/
            for (int number = 0; number < listArr.Count(); number++)
            {
                Console.WriteLine("number is {0} ", +listArr[number]);
            }

            Console.ReadLine();

        }
    }
}
