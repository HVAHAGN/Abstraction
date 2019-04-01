using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_02
{
    // An abstract class can be inherited from a particular class.

    
        // Specific class A.
        class ConcreteClassA
        {
            public void Operation()
            {
                Console.WriteLine("ConcreteClassA.Operation");
            }
        }

        // Abstract class.
        abstract class AbstractClass : ConcreteClassA
        {
            public abstract void Method();
        }

        // Specific class B.
        class ConcreteClassB : AbstractClass
        {
            public override void Method()
            {
                Console.WriteLine("ConcreteClassB.Method");
            }
        }

        class program
        {
            static void Main()
            {
                AbstractClass instance = new ConcreteClassB();

                instance.Method();
                instance.Operation();

                // Delay.
                Console.ReadKey();
            }
        }
    }
