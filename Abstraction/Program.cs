using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
   /* Abstraction and encapsulation are related features in object-oriented programming.
    * Abstraction allows making relevant information visible and encapsulation enables a programmer 
    * to implement the desired level of abstraction.
    * Abstraction can be achieved using abstract classes in C#. C# allows you to create abstract 
    * classes that are used to provide a partial class implementation of an interface. 
    * Implementation is completed when a derived class inherits from it. Abstract classes contain abstract methods, 
    * which are implemented by the derived class. The derived classes have more specialized functionality.

The following are some of the key points −
You cannot create an instance of an abstract class
You cannot declare an abstract method outside an abstract class
When a class is declared sealed, it cannot be inherited, abstract classes cannot be declared sealed.*/
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
