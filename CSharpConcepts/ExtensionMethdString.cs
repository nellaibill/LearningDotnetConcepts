using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public static class ExtensionMethdString
    {
        public static string Shorten(this string str, int numberofwords)
        {
            var splittedString = str.Split(' ');
            return string.Join(" ", splittedString.Take(numberofwords)) + " .....";
        }
    }
}
