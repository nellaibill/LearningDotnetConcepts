using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    internal class Program
    {
        public static void main(string[] args)
        {
            var person = Tuple.Create("Mohamed Saleem", 33, 9578795653);
            Console.WriteLine(person.Item1);
        }
    }
}
