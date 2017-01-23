using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod002
{
    public delegate int MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate (int a, int b) { return a + b; };  // anonymous method
            Console.WriteLine(myDelegate(2, 5));
        }
    }
}
