using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public abstract class abstract_sal
    {
        public abstract_sal()
        {
            Console.WriteLine("baseclass");
        }
        public abstract void Eat();
        public virtual void MakeSound()
        {
            Console.WriteLine("Make Sound");
        }
        public void Run()
        {
            Console.WriteLine("Animal is running");
        }

    }


    public class Cat : abstract_sal
    {
        public Cat()
        {
            Console.WriteLine("child class");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat - Should Eat");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Cat is making Sound");
        }
        public new void Run()
        {
            Console.WriteLine("Cat is running");
        }
    }

}
