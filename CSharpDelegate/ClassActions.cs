using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegate
{
    internal class ClassActions
    {
        public static void Action1()
        {
            Console.WriteLine("Called Class2.Action1() with no parameters.");
        }
        public static void Action2(int i)
        {
            Console.WriteLine("Called Class2.Action2() with parameter: " + i.ToString());
        }
    }
}
