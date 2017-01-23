using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod001
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate md = delegate { Console.WriteLine("Hello"); };
            md();
        }
    }
}
