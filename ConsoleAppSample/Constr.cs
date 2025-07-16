using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    class Constr
    {
        public Constr() {  // exe auto on Object creation
            Console.WriteLine("constr");
        }  // no return type 
        public void T1() {
            Console.WriteLine("Non sttaic"); //obj
        }

        public static  void T2() {
            Console.WriteLine("static method"); // class name
        }
    }
}
