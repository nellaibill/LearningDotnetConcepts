using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Synch_Asynch_Delegates_MulticastDelegates_and_Events
{
    internal class Factorial
    {
        public delegate void Sendresult(BigInteger number);
        public Sendresult WhereToSend;
        public void  Calculate(BigInteger number)
        {
            BigInteger result = number;
            for(BigInteger i = 1; i < number; i++)
            {
                result = result * i;
            }
            WhereToSend(result);
        }
    }
}
