using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    internal class ReadLineEx
    {
        public void test()
        {
            /* Console.WriteLine("Enter ur name!");
             string Name = Console.ReadLine();
             Console.WriteLine("Ur Name is :"+Name);

             Console.WriteLine("Enter ur Age!");
             int Age =Convert.ToInt32( Console.ReadLine());
             Console.WriteLine("Ur Age is :" + Age);

             byte b = Convert.ToByte(Console.ReadLine());

             float f = Convert.ToSingle(Console.ReadLine());

             char c = Convert.ToChar(Console.ReadLine());


             Console.WriteLine("enter res");
             int res = int.Parse(Console.ReadLine());   //
             Console.WriteLine(res);


             byte b1 = byte.Parse(Console.ReadLine());

             float f1 = float.Parse(Console.ReadLine());

             char c1 =char.Parse(Console.ReadLine());*/


            string str = null;
            int result = Convert.ToInt32(str);
            Console.WriteLine(result); // 0


            string str1 = null;
            int result1 = int.Parse(str1);
            Console.WriteLine(result1);  // run time

            int? x2 = null;// x2 is nullable
            Nullable<int> x3 = null;
            string str2 = null;

            // boxing and Unboxing
            // value to ref 
            // ref to value id Un

            int res1 = 43;
            string s1 = res1.ToString(); // "43"

            object o1 = "6565";
            int res2 = (int)o1; // Unboxing

            // implict & explict
            //lower to heighr conver impliuct

            int myres1 = 34;
            long lg = myres1;

            long myres12 = 34;
            int lg2 = (int)myres12;


            // "43"
            // Convertion tech  and parsing tech
        }
    }
}
