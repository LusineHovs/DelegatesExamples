using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegateAsArgument
{
    public delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);
    public delegate string Delegate1();
    public delegate string Delegate2();
    public delegate string Delegate3();

    class Program
    {
        public static Delegate3 MethodF(Delegate1 delegate1, Delegate2 delegate2)
        {
            return delegate { return delegate1.Invoke() + delegate2.Invoke(); };

        }
        public static string Method1() { return "Hello";}
        public static string Method2() { return "world"; }

        static void Main(string[] args)
        {
            Functional functional = new Functional(MethodF);

            Delegate3 delegate3 = functional.Invoke(new Delegate1(Method1), new Delegate2(Method2));
            Console.WriteLine(delegate3());    
        

        }
    }
}
