using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class PrinterAdapter : IModernPrinter
    {
       private readonly LegacyPrinter _legacyPrinter;

        public PrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }
        public void print(string message)
        {
            _legacyPrinter.print(message);
        }
    }
}
