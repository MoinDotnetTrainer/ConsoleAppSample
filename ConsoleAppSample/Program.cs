using System.ComponentModel;

namespace ConsoleAppSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello, World!");



            //  ClassExamplre obj = new ClassExamplre();
            //  obj.Add();
            //  obj.Sub();
            //  ClassExamplre.Mul();
            //  ClassExamplre.Div(12, 6);


            //  ClassExamplre obj2 = new ClassExamplre();
            //  obj2.Add();
            //  obj2.Sub();
            //  ClassExamplre.Mul();

            //  Console.WriteLine();
            //string str=  Console.ReadLine();

            //Constr x = new Constr();  // constr
            //x.T1();
            //Constr.T2();

            //   OverLoading obj = new OverLoading("67");

            Refout.Test();
            Refout.cal(12, 2, out int Add, out int sub);
            Console.WriteLine(Add);
            Console.WriteLine(sub);
        }
    }
}
