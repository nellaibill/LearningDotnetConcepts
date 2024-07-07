using System;

namespace CSharpConcepts
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from Program.cs!");
        }
    }
}


//CollectionTest.RemoveDuplicates(new int[] { 1, 2, 3 ,1,5});

/*

//PrivateConstructor pc = new PrivateConstructor();
StaticConstructor.Log("Hello");
EfCoreJoinLinq ef = new EfCoreJoinLinq();
ef.getData();

SealedClass s = new SealedClass();
s.PrintMethod();
s.PrintMethod();
s.PrintMethod();
/*
 
Cat  catObj = new Cat();
catObj.Eat();
catObj.MakeSound();
catObj.Run();

Console.WriteLine(StaticClass_Utilities.Add(1,10));
Console.WriteLine(StaticClass_Utilities.Add(2, 10));
Console.WriteLine(StaticClass_Utilities.Add(3, 10));
Console.WriteLine(StaticClass_Utilities.Multiply(1, 10));
Console.WriteLine(StaticClass_Utilities.Multiply(2, 10));
Console.WriteLine(StaticClass_Utilities.Multiply(3, 10));



Utilities.WriteHeadingAndDrawLine("PrivateConstructor");
PrivateConstructor.PrintMessage();

string[] arr = new string[2];
arr[0] = "a";
arr[1] = "b";
arr[2] = "c";


ArrayList arrayList = new ArrayList();
arrayList.Add("a");
arrayList.Add(1);

List<int> list = new List<int>();
list.Add(1);
list.Add(2);

Hashtable ht = new Hashtable();
ht.Add("a", "a");
ht.Add("b", 1);

Dictionary<int,int> ht2 = new Dictionary<int,int>();
ht2.Add(1, 2);

var test = Tuple.Create("Hello", 1, true);
Console.WriteLine(test.Item1);
Console.WriteLine(test.Item2);
Console.WriteLine(test.Item3);

var test1 = new { name = "test", num = 2, bol = true };
Console.WriteLine(test1.name);

testDelegate tst = new testDelegate();
addnum test10 = new addnum(tst.sum);
test10(10, 20);

list.Select(a=>a.Equals(1)).ToList();

Console.WriteLine(StaticClass_Utilities.Add(10, 20));
Singleton singleton = Singleton.Instance;
singleton.DoSomething();


Utilities.WriteHeadingAndDrawLine("Const Vs Readonly");
Console.WriteLine("• Const : Compile Time\r\nReadonly : Run- Time read values (e.g - read from appsettings)");
ConstAndReadOnly obj1 = new ConstAndReadOnly();
obj1.PrintConstAndRead();

Utilities.WriteHeadingAndDrawLine("Out and Ref Keywords");
Console.WriteLine("Inside function the value is getting incremented to 10");
int withoutRefAndOutValue = 20;
WithoutOutAndRefFunction(withoutRefAndOutValue);
Console.WriteLine("withoutRefAndOutValue(20)  = " + withoutRefAndOutValue);

int passRefValue = 20;
callRefFunction(ref passRefValue);
Console.WriteLine("callRefFunction(20) = " + passRefValue);


int passOutValue;
callOutFunction(out passOutValue);
Console.WriteLine("callOutFunction -value assignment inside only(20) = " + passOutValue);
static int WithoutOutAndRefFunction(int number)
{
    number = number + 10;
    return number;
}
static int callRefFunction(ref int number)
{
    number = number + 10;
    return number;
}
static int callOutFunction(out int number)
{
    number = 20;
    number = number + 10;
    return number;
}

Utilities.WriteHeadingAndDrawLine("Grouping multiple values into a single object.");

var sampleTuple = Tuple.Create("Mohamed Saleem", 33, 9578795653);
Console.WriteLine("Result from Tuples : " + sampleTuple.Item1);


var sampleAnonymousType = new { name = "Mohamed Saleem", age = 33, mobileNumber = 9578795653 };
Console.WriteLine("Anonymous Types : Better Readability");
Console.WriteLine("Result from Anonymous Types : " + sampleAnonymousType.name);




Utilities.WriteHeadingAndDrawLine("Extension Methods");
Console.WriteLine("Extension Methods : Helps to add new methods to the existing type without modifying the original code");
string post = "This is suppose to be a very long post";
var shortenPost = post.Shorten(5);
Console.WriteLine(shortenPost);

Utilities.WriteHeadingAndDrawLine("IS vs AS Keyword");
object testIsFunctionality1 = "Test";
object testIsFunctionality2 = 123;
if (testIsFunctionality1 is string)
{
    Console.WriteLine("testIsFunctionality1 :  is string datatype? = " + "True");
}

string convertToStringWithAsKeyword = testIsFunctionality1 as string;
string convertToStringWithAsKeyword1 = testIsFunctionality2 as string;
Console.WriteLine(convertToStringWithAsKeyword);
Console.WriteLine(convertToStringWithAsKeyword1);//This will return null becuase it cannot



Utilities.WriteHeadingAndDrawLine("Reflection");

Person person = new Person { Name = "John", Age = 30 };
Console.WriteLine(person.GetType().Namespace);
PropertyInfo[] properties = person.GetType().GetProperties();
foreach (var property in properties)
{
    Console.WriteLine($"{property.Name} : {property.GetValue(person)}");
}


Utilities.WriteHeadingAndDrawLine("Dyamamic Keyword");
dynamic testDyanamic1 = "saleem";
dynamic testDyanamic2 = 100;
//testDyanamic1++; //Build will success runtime only check will happen 
testDyanamic2++;
Console.WriteLine(testDyanamic2);


Utilities.WriteHeadingAndDrawLine("Indexers");
Indexers ind = new Indexers();
ind[0] = "Mohamed Saleem";
ind[1] = "Mohammed Fathims";

Console.WriteLine(ind[0]);


Utilities.WriteHeadingAndDrawLine("ArrayList Vs HashTables");
ArrayList arrayList = new ArrayList();
Person p1 = new Person();
p1.Name = "Saleem";
p1.Age = 34;
Person p2 = new Person();
p2.Name = "Fathima";
p2.Age = 29;
arrayList.Add(p2);
Person arrayListPerson = (Person)arrayList[0];
Console.WriteLine("To Access ArrrayList : " + arrayListPerson.Name +" - " + arrayListPerson.Age);

Hashtable hashTable = new Hashtable();
hashTable.Add(p1.Name, p1);
hashTable.Add(p2.Name, p2);
Person hashTablePerson = (Person)hashTable["Saleem"];
Console.WriteLine("To Access Hashtable : " + hashTablePerson.Name + " - " + hashTablePerson.Age);

Utilities.WriteHeadingAndDrawLine("Stack Vs Queue");

Stack stack = new Stack();
stack.Push(p1);
stack.Push(p2);
Person stackPerson = (Person)stack.Pop();
Console.WriteLine("To Access Stack : " + stackPerson.Name + " - " + stackPerson.Age);

Queue queue = new Queue();
queue.Enqueue(p1);
queue.Enqueue(p2);
Person queuePerson = (Person)queue.Dequeue();
Console.WriteLine("To Access Queue : " + queuePerson.Name + " - " + queuePerson.Age);

Utilities.WriteHeadingAndDrawLine("Generics");

Generics<int> g1 = new Generics<int>();
Console.WriteLine("Generics - Integer Comparision(1,1) = " +  g1.CompareValues(1,1));


Generics<string> g2 = new Generics<string>();
Console.WriteLine("Generics - String Comparision('Saleem','Fathima') = " + g2.CompareValues("Saleem", "Fathima"));

Utilities.WriteHeadingAndDrawLine("Generics Constraints");

GenericsConstraints<Customer> genericCustomer = new GenericsConstraints<Customer>();
//GenericsConstraints<int> int1 = new GenericsConstraints<int>();
Console.WriteLine("Generic Constrains allow only specific datatype which mentioned ");

genericCustomer.Add(new Customer());

Utilities.WriteHeadingAndDrawLine("Generic Collection");

List<int> lst1 = new List<int>();
lst1.Add(1);
lst1.Add(2);
Console.WriteLine("Generic Colleciton List Output = " + lst1[0]);

Dictionary<int,string> dic1 = new Dictionary<int, string>();
dic1.Add(1,"Monday");
dic1.Add(2,"Tuesday");
Console.WriteLine("Generic Collection Dictionary Output = " + dic1[1]);

Stack<int> stack1 = new Stack<int>();
stack1.Push(1);
stack1.Push(2);
Console.WriteLine("Generic Collection Stack Output = " + stack1.Pop());

Queue<int>  queue1 = new Queue<int>();
queue1.Enqueue(1);
queue1.Enqueue(2);

Console.WriteLine("Generic Collection Queue Output = " + queue1.Dequeue());

Utilities.WriteHeadingAndDrawLine("IEnumerable,ICollection,IList,IDictionary");

CustomerLibrary cs1 = new CustomerLibrary();
IEnumerable iEnumerable = cs1.LoadCustomersWithIEnumerable();
ICollection iCollection =  cs1.LoadCustomersWithICollection();
IList iList = cs1.LoadCustomersWithIList();
iList.Add(new CustomerLibrary{ CustomerCode ="103" , CustomerName="Hana"});

IDictionary iDictionary = cs1.LoadCustomersWithIDictionary();

foreach (object i in iEnumerable)
{
    CustomerLibrary test =(CustomerLibrary)i;
    Console.WriteLine("Customer Name  with IEnumerable = " + test.CustomerName);
}

Console.WriteLine("Total Customer with Icollection = " + iCollection.Count);


foreach (object i in iList)
{
    CustomerLibrary test = (CustomerLibrary)i;
    Console.WriteLine("Customer Name  with IList after adding Hana to the list = " + test.CustomerName);
}


Console.WriteLine("Total Customer with IList after adding Hana to the list = " + iList.Count);

CustomerLibrary c = (CustomerLibrary)iDictionary["101"];
Console.WriteLine("Customer Name  with IDictionary  " + c.CustomerName);


Utilities.WriteHeadingAndDrawLine("IEnumerable vs IEnumerator");


List<int> lstYears = new List<int>();
lstYears.Add(2001);
lstYears.Add(2002);
lstYears.Add(2003);
lstYears.Add(2004);
lstYears.Add(2005);
lstYears.Add(2006);
lstYears.Add(2007);
lstYears.Add(2008);

foreach (int i in lstYears)
{
    if (i > 2005)
    {
        Iterate2005AndAboveWithIEnumerable(lstYears);
    }
    Console.WriteLine("Print Using IEnumerable " + i);
}

IEnumerator<int> lstYearsWitEnum = lstYears.GetEnumerator();
while (lstYearsWitEnum.MoveNext())
{
    Console.WriteLine("Print Using IEnumerator " + lstYearsWitEnum.Current);
    if (lstYearsWitEnum.Current > 2005)
    {
        Iterate2005AndAbove(lstYearsWitEnum);
    }
}

static void Iterate2005AndAbove(IEnumerator<int> o)
{
    while (o.MoveNext())
    {
        Console.WriteLine("Print Using IEnumerator from Current State" + o.Current);
    }
}
static void Iterate2005AndAboveWithIEnumerable(IEnumerable<int> o)
{
   foreach (int i in o)
    {
        Console.WriteLine("Print Using IEnumerable  Current State is not possible so repeating " + i);
    }
}
*/