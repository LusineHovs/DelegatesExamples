using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegateAsArgument_WithLambdaExpression_
{
    public delegate MyDelegate Functional(MyDelegate delegate1, MyDelegate delegate2);
    public delegate string MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate delegate1 = () => "Lusine";
            MyDelegate delegate2 = () => "Hovsepyan";

            // Functional functional = delegate (MyDelegate d1, MyDelegate d2) { return delegate () { return d1.Invoke() + d2.Invoke(); }; };
            // Functional functional = delegate (MyDelegate d1, MyDelegate d2) { return () => d1.Invoke() + d2.Invoke(); }; 
            Functional functional = (MyDelegate d1, MyDelegate d2) => () => d1() + d2();

            Console.WriteLine(functional(delegate1,delegate2)());
        }
    }
}
