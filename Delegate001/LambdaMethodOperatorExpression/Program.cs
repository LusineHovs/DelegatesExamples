using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaMethodOperatorExpression
{
    public delegate int MyDelgate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelgate myDelegate;
            myDelegate = delegate (int x) { Console.WriteLine("its ok"); return x * 2; }; //Lambda Method 
            myDelegate = (x) => { Console.WriteLine(1987); return x * 2; };               // Lambda operator
            myDelegate = x => x * 2;                                                      // Lambda expression
            int result = myDelegate(5);
            Console.WriteLine(result);
        }
    }
}
