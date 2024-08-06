using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public  class Finalize_Dispose : IDisposable
    {
        public Finalize_Dispose()
        {
        }
       ~Finalize_Dispose()
        {
        }

        public void Dispose()
        {
            // Cleaning up the memory
            GC.SuppressFinalize(this);
        }
    }
}
