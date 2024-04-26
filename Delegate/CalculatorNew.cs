using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public  class CalculatorNew
    {
        //public delegate int Calculate(int input);

        public int Execute(Func<int,int> calculate, Action<int> print,int input)
        {
            var result =calculate(input);
            print(result);
            return result;
        }
    }
}
