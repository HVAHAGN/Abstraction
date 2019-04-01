using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_03

{// An abstract class can be inherited from an abstract class.
// Implementing an abstract method from a base abstract class, in a derived abstract class, is optional.


        // Abstract class A.
        abstract class AbstractClassA
        {
            public abstract void OperationA();
        }

        // Abstract class B.
        abstract class AbstractClassB : AbstractClassA
        {
            public abstract void OperationB();
        }

        // Specific class.
        class ConcreteClass : AbstractClassB
        {
            public override void OperationA()
            {
                Console.WriteLine("ConcreteClass.OperationA");
            }

            public override void OperationB()
            {
                Console.WriteLine("ConcreteClass.OperationB");
            }
        }

        class program
        {
            static void Main()
            {
                AbstractClassA instance = new ConcreteClass();

                instance.OperationA();

                //instance.OperationB (); // Question: Why is this method not available?

                // Delay.
                Console.ReadKey();
            }
        }
    }
