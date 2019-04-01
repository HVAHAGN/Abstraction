using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_05
{
    abstract class AbstractBaseClass
    {
        // 1.//substitute
        // A normal method is passed to the derived class as if it were inherited from a particular class.
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod");
        }

        // 2. override
        // The virtual method is passed to the derived class as if it were inherited from a particular class.
        virtual public void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod");
        }

        // 3. implemented
        // Abstract method - implemented in a derived class.
        abstract public void AbstractMethod();
    }
}
