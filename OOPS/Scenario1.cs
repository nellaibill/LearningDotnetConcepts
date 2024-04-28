using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    interface I1 { void Method1(); }
    interface I2 { void Method1(); }
    class Scenario1 : I1, I2
    {
         void I1.Method1()
        {
            Debug.WriteLine("Called by I1");
        }

         void I2.Method1()
        {
            Debug.WriteLine("Called by I2");
        }
    }
}
