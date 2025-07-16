using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    internal class Arrays
    {
        public void test()
        {
            // int 
            //int?
            //int[]

            int[] arr = { 345, 4545, 6, 57, 657, 657, 768, 76, 8 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



            Console.WriteLine("while");
            int res = 0;
            while (res<arr.Length)
            {
                Console.WriteLine(arr[res]);
                res++;
            }


            Console.WriteLine("for each");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            // i=i+1;
            //i=0+1;
            //i=1;
        }
    }
}
