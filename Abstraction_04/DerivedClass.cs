using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_04
{
    class ConcreteDerivedClass : AbstractBaseClass
    {
        // Override the virtual method VirtualMethod () of the base abstract class.
        // If we do not override the virtual method, then the method from the base class will be used.

        public override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass.VirtualMethod ();");
        }

        // Implement the abstract method AbstractMethod () of the base abstract class.

        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass.AbstractMethod ();");
        }
    }
}
