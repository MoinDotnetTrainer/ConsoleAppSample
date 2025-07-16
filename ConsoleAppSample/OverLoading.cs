using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    internal class OverLoading
    {
        public OverLoading() {
            Console.WriteLine("t1");
        }
        public OverLoading(int x) {

            Console.WriteLine("t2");
        }
        public OverLoading(string str) {
            Console.WriteLine("t3");
        }
        public void M1() { }
        public void M1(int x) { }
        public void M1(string str) { }
        public void M1(int x , int y) { }
        public void M1(string x , string y) { }
        public void M1(int x , string y) { }
        public void M1(string x , int y) { }
    }
}
