using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaMethodOpExp002
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mydelegate;
            mydelegate = delegate { Console.WriteLine("Hello1"); };
            mydelegate += () => { Console.WriteLine("Hello2"); };
            mydelegate += () => Console.WriteLine("Hello3");
            mydelegate();
        }
    }
}
