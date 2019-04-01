using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
   
{
    // Abstract class.

        abstract class AbstractClass
    { 
        //public virtual void Method(){} is the same
        public abstract void Method();
    }

    //Concrete class
    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementation"); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass(); 

            instance.Method();


            Console.ReadLine();
        }
    }
}
