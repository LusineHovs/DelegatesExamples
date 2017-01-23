using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate001
{
    public delegate void MyDelegate();

    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("This method has used by delegate");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mydelegate = new MyDelegate(MyClass.Method);
            mydelegate();
        }
    }
}
