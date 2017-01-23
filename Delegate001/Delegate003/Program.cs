using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate003
{
    public delegate string MyDelegate(string name);

    class Myclass
    {
        public string Method(string name)
        {
            return "Hello" + name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new Myclass();
            var mydelegate = new MyDelegate(instance.Method);
            Console.WriteLine(mydelegate.Invoke("Garry"));
        }
    }
}
