using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Shadowing
    {
        public int InvoiceNumber { get; set; }
    }

    public class Shadwing2 :Shadowing 
    { 
        public new object InvoiceNumber { get; set; }
    
    }

}
