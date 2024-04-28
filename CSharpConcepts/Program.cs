
using CSharpConcepts;

WriteHeadingAndDrawLine("Extension Methods");
Console.WriteLine("Extension Methods : Helps to add new methods to the existing type without modifying the original code");
string post = "This is suppose to be a very long post";
var shortenPost = post.Shorten(5);
Console.WriteLine(shortenPost);

WriteHeadingAndDrawLine("IS vs AS Keyword");
object testIsFunctionality1 = "Test";
object  testIsFunctionality2 = 123;
if (testIsFunctionality1 is string)
{
    Console.WriteLine("testIsFunctionality1 :  is string datatype? = " + "True");
}

string convertToStringWithAsKeyword = testIsFunctionality1 as string;
string convertToStringWithAsKeyword1 = testIsFunctionality2 as string;
Console.WriteLine(convertToStringWithAsKeyword);
Console.WriteLine(convertToStringWithAsKeyword1);//This will return null becuase it cannot



WriteHeadingAndDrawLine("Const Vs Readonly");
Console.WriteLine("• Const : Compile Time\r\nReadonly : Run- Time read values (e.g - read from appsettings)");
ConstAndReadOnly obj1 = new ConstAndReadOnly();
obj1.PrintConstAndRead();

WriteHeadingAndDrawLine("Out and Ref Keywords");
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

WriteHeadingAndDrawLine("Grouping multiple values into a single object.");

var sampleTuple = Tuple.Create("Mohamed Saleem", 33, 9578795653);
Console.WriteLine("Result from Tuples : " + sampleTuple.Item1);


var sampleAnonymousType = new { name = "Mohamed Saleem", age = 33, mobileNumber = 9578795653 };
Console.WriteLine("Anonymous Types : Better Readability");
Console.WriteLine("Result from Anonymous Types : " + sampleAnonymousType.name);

static void WriteHeadingAndDrawLine(string input)
{
    Console.WriteLine("--------------------------------------------------------------------------------------");
    Console.WriteLine(input);
    Console.WriteLine("--------------------------------------------------------------------------------------");
}



