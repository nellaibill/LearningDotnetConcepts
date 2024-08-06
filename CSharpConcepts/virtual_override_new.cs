namespace CSharpConcepts
{
    class BC
    {
        //•	Virtual Method: Allows a method to be overridden in derived classes.
        public virtual void Display() 
        {
            System.Console.WriteLine("BC::Display");
        }
    }
    class DC : BC
    {
        //•	Override: Provides a new implementation of a virtual method in a derived class.
        public override void Display() 
        {
            System.Console.WriteLine("DC::Display"); 
        }
    }

    class TC : DC
    {
        //•	New Keyword: Hides a method in the base class, but does not override it.
        //When accessed through a base class reference, the base class method will be called.
        public new void Display() 
        {
            System.Console.WriteLine("TC::Display"); 
        }
    }
    public class virtual_override_new
    {
        public void Print() // This is the entry point of the program
        {
            BC b; // Declare a variable of type BC
            b = new TC(); // Create an instance of TC and assign it to the BC variable
            b.Display(); // Call the Display method on the BC variable
            Console.ReadLine(); 
        }
    }
}
