using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Nurse : IUser
    {
        public void ShowDetails() => Console.WriteLine("Nurse Details");
    }

}
