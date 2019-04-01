using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_06
{
    abstract class AbstractClass
    {
        // Constructor (executes first).
        public AbstractClass()
        {
            Console.WriteLine("1 AbstractClass ()");

            // Called the implementation of the method from the derived class - ConcreteClass.
            this.AbstractMethod();

            Console.WriteLine("2 AbstractClass ()");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "FIRST";

        // Constructor (executes second).
        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass ()");
            s = "SECOND";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Implementation of the AbstractMethod () method in ConcreteClass {0}", s);
        }
    }

    class program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();

            Console.WriteLine(new string('-', 55));

            instance.AbstractMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}