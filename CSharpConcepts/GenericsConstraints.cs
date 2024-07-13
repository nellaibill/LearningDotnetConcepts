using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class GenericsConstraints<T> where T : class
    {
        public void Add(T item)
        {

        }
        public bool CompareValues(T i, T j)
        {
            if (i.Equals(j)) return true;
            return false;
        }
    }

}
