using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegate
{
    public delegate void MyDelegate(); //declaring a delegate
    public delegate void MyDelegate1(string msg); //declaring a delegate
    public delegate void MyDelegate2(string msg, int numero); //declaring a delegate
    public delegate int MyDelegate3(int numero); //declaring a delegate


    internal class ClassDelegates
    {
        internal static void MethodA()
        {
            Console.WriteLine("Called ClassA.MethodA() with no parameters.");
        }
        internal static void MethodAA()
        {
            Console.WriteLine("Called ClassA.MethodAA() with no parameters.");
        }

        internal static void MethodB(string msg)
        {
            Console.WriteLine("Called ClassB.MethodB(string msg) with parameter: " + msg);
        }

        internal static void MethodC(string msg, int numero)
        {
            Console.WriteLine("Called ClassA.MethodC(string msg, int numero) with parameter: " + msg + " " + numero.ToString());
        }

        internal static int AddOne(int numero)
        {
            return numero + 1;
        }
    }
}
