using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    class Refout
    {
        public static void RefMethod(ref int x)  //10101
        {
            x = x + 100;
            Console.WriteLine(x);  // 110
        }


        public static void Test()
        {
            int a = 10;
            Console.WriteLine("a Value , before :" + a); // 10
            RefMethod(ref a);  //10101
            Console.WriteLine("Value of a after ref method: " + a);  // 110
        }

        public static void cal(int x , int y , out int add , out int Sub) {
            add = x + y;
            Sub = x - y;
        }
    }
}
