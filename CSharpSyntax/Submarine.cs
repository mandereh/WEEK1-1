using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week1TestClass.CSharpSyntax
{
    public class Submarine // Father class or base class
    {
        public virtual void Dive()
        {
            Console.WriteLine("The submarine is diving.");
        }

        public  void Dive(string mode)
        {
            Console.WriteLine("The submarine is diving.");
        }
    }
}