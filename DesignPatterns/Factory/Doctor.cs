using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Doctor : IUser
    {
        public void ShowDetails() => Console.WriteLine("Doctor Details");
    }
}
