using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    class ClassExamplre
    {
        public void Add()
        {
            int x = 45, y = 45, z;
            z = x + y;
            Console.WriteLine("Add is:" + z);
          
        }
        public void Sub()
        {
            int x = 45, y = 45, z;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }
        public static void Mul()
        {
            int x = 45, y = 45, z;
            z = x * y;
            Console.WriteLine("Mul is:" + z);
        }
        public static int Div(int x, int y)
        {
            int z;
            z = x / y;
            Console.WriteLine("Div is:" + z);
            return z;
        }

    }
}
