using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public  class Generics<T> 
    {

        public bool CompareValues(T i,T j)
        {
            if(i.Equals(j)) return true;
            return false;   
        }
       

    }

}
