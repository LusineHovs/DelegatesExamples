using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod003
{
    public delegate int MyDelegate(ref int a, ref int b, out int c);
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 3, sum;
            MyDelegate myDelegate = delegate (ref int a, ref int b, out int c) { a++; b++; return c = a + b; };
            myDelegate(ref x, ref y, out sum); // invokation of delegate
            Console.WriteLine(myDelegate(ref x, ref y, out sum));
        }
    }
}
