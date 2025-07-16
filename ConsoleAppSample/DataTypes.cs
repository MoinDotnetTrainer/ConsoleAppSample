using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    internal class DataTypes
    {
        public void Test() {
            //Inyterger category 0-9 , no point values
            // byte short int long
            // 1 2 4 8
            // signed unsigned
            // 1 byte = 8 bit = 0-255
            byte b = 255; // unsigned byte --> only postive value , No -ve
            sbyte sb =127;  //  +ve and -ve value 

            //Floating cat 0-9 , including points
            // float double Nd decimal
            float f = 23.35f;
            double d = 4.45;
            decimal dm = 4.4m;

            // bool True or false
            bool b1 = true;

            // char SIngle Char 

            char c = 'A';

            string str = "akf8326832&^%&^%";

            int x = 76;

            //other cat of Datatypes
            // var dynamic & object


            //compile time
            var v1 = 67;
            v1 = 56;
            var v2 = "test";
            v2 = "testing";
           // v2 = 45;
            var v3 = true;
            var v4 = 34.45;


            // run time 
            dynamic d1 = 34;
            
            dynamic d2 = 67;
            dynamic d3 = true;
            dynamic d4 = 445.56;

            int myres = d1 + d2;


            // ref type datatype
            object o1 = 34;
          
            object o2 = 65;
            object o3 = true;
            object o4 = 45.56;

            int res = (int)o1 + (int)o2; //ref




        }
    }
}
