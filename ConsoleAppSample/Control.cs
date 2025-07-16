using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    internal class Control
    {
        public void test()
        {
            //simple if , if else , else if , Nested if else  // condtion True or false

            int x = 3454, y = 56, z = 3454;
            if (x > y && x > z) // true
            {
                Console.WriteLine("x");
            }
            else if (y>x && y> z) { Console.WriteLine("y"); }
            else
            {
                Console.WriteLine("z");
            }


            string Email = "Patel@yahoo.com", Password = "123";
            bool Status = true;
            if (Email == "Patel@yahoo.com" && Password == "123")
            {
                if (Status == false)
                {
                    Console.WriteLine("Successfully Login");
                }
                else
                {
                    Console.WriteLine("User is Inactive");
                }
            }
            else
            {
                Console.WriteLine("Emil or pwd is not correct");
            }


        }
    }
}
