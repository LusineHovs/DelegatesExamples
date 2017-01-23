using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate002
{
    public delegate void MyDelegate();

    public class MyClass
    {
        public void Method()
        {
            Console.WriteLine("This method was used by delegate2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new MyClass();
            var mydelegate = new MyDelegate(instance.Method);
            mydelegate();
        }
    }
}
