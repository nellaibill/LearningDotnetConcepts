


using DesignPatterns;
using DesignPatterns.Adapter;
using DesignPatterns.BuilderDesignPattern;
using DesignPatterns.Factory.NetworkFactory;
using DesignPatterns.Factory.NetworkUtitlity;

MealBuilder mealBuilder = new MealBuilder();
mealBuilder.BuildMainCourse("Briyani");
mealBuilder.BuildSideDish("Chicken 65");
mealBuilder.BuildDrink("Pepsi");
Console.WriteLine(mealBuilder.Build());

LegacyPrinter legacyPrinter = new LegacyPrinter();
legacyPrinter.print("From Legacy");
IModernPrinter modernPrinter = new PrinterAdapter(legacyPrinter);
modernPrinter.print("From Printer Adapter");

NetworkFactory networkFactory = new NetworkFactory();
networkFactory.GetNetworkInstance("ping").SendRequest();
networkFactory.GetNetworkInstance("dns").SendRequest();




Singleton singleton = Singleton.Instance();
Singleton singleton1 = Singleton.Instance();

if(singleton == singleton1)
{
    Console.WriteLine("These objects are same");
}

Console.ReadLine();

