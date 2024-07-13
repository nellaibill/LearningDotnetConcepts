using CSharpConcepts;
using CSharpConcepts.DSA;
using CSharpConcepts.EFCore;
using CSharpConcepts.OOPS;
using System;



Linq_Questions.question11();
StaticConstructor.Log("Hello");
StaticConstructor.Log("Hello1");
PrivateConstructor.PrintMessage();
Console.ReadLine();
//EfCoreLogic.GetValues();
/*
DelegateTesting delegateTesting = new DelegateTesting();
Calculation calc = DelegateTesting.Add;
Console.WriteLine(calc.Invoke(10, 20));
calc += DelegateTesting.Sub;
Console.WriteLine(calc.Invoke(30,20));

// Console.WriteLine("Hello from Program.cs!");


//CollectionTest.RemoveDuplicates(new int[] { 1, 2, 3 ,1,5});



//PrivateConstructor pc = new PrivateConstructor();
StaticConstructor.Log("Hello");
EfCoreJoinLinq ef = new EfCoreJoinLinq();
ef.getData();

SealedClass s = new SealedClass();
s.PrintMethod();
s.PrintMethod();
s.PrintMethod();

 
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


//EfCoreLogic.AddValues();
EfCoreLogic.GetValues();
//var delegateTesting = new DelegateTesting();
//var response = delegateTesting.Execute((x) => x * x, Console.WriteLine, 5);


int test = 12345;
Console.WriteLine(test.ToString().Sum(x => x - '0'));
int[] test1 = new int[] { 1, 2, 3, 4, 5, 6,7,8,4,9 };
int[] test2 = new int[] { 8,9,10}; 
CollectionTest.RemoveDuplicates(test1);
CollectionTest.MaximumInteger(test1);
CollectionTest.ReverseString("Saleem");
CollectionTest.MergeArrays(test1,test2);
CollectionTest.IntersectArrays(test1,test2);

ArrayLogics.RemoveDuplicates(new int[] {1,2,3,4,2,3,4,4,5,5});
Console.WriteLine(ArrayLogics.GetFirstUniqueCharacter("loveleetcode"));


Int_qns qns = new Int_qns();
qns.question1();
qns.question2();
qns.question3();
qns.question4();
qns.question5();
qns.question6();
qns.question7();


int[] numbers = [1, 3, 2, 5, 4];
int[] swapResult = new int[numbers.Length];
Patterns.PrintStarPattern18(4);
LoadHashing();
//ReversePrograms();
BasicMathsPrograms();
LoadPatterns();
LoadArrayPrograms();

Console.WriteLine(String_Array_Program.firstNonRepeatedCharacter("aabbcdd"));
ArrayLogics.DrawLineWithHeading("returnFibonacciofGivenNumber");
Console.WriteLine(RecursionProblems.returnFibonacciofGivenNumber(8));




void LoadHashing()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];

    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    // Precompute
    Dictionary<int, int> hash = new Dictionary<int, int>();
    for (int i = 0; i < n; i++)
    {
        if (!hash.ContainsKey(arr[i]))
        {
            hash[arr[i]] = 1;
        }
        else
        {
            hash[arr[i]]++;
        }
    }

    int q = Convert.ToInt32(Console.ReadLine());
    while (q-- > 0)
    {
        int number;
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input for 'number'.");
            return;
        }
        Console.WriteLine(hash.ContainsKey(number) ? hash[number] : 0);
    }
    //int[] arr = { 10, 5, 10, 15, 10, 5 };
    //int n = arr.Length;
    //ArrayLogics.DrawLineWithHeading("Hashing");
    //Hashing.CountFreq(arr, n);
}


void ReversePrograms()
{
    int[] numbers = [1, 3, 2, 5, 4];
    int[] swapResult = new int[numbers.Length];
    ArrayLogics.DrawLineWithHeading("swapArray");
    Console.WriteLine(String.Join("", RecursionProblems.swapArray(numbers, 0, swapResult)));

    ArrayLogics.DrawLineWithHeading("checkStringisPalindrome");
    Console.WriteLine(RecursionProblems.checkStringisPalindrome("madamd", 0));

    ArrayLogics.DrawLineWithHeading("returnMultiplyofN_Numbers");
    Console.WriteLine("multiply of the given number is : " + RecursionProblems.returnMultiplyofN_Numbers(5));
    ArrayLogics.DrawLineWithHeading("printSumofN_Numbers");
    RecursionProblems.printSumofN_Numbers(1, 5, 0);

    ArrayLogics.DrawLineWithHeading("printName");
    RecursionProblems.printName(1, 5);
    ArrayLogics.DrawLineWithHeading("printNumber");
    RecursionProblems.printNumber(1, 5);
    ArrayLogics.DrawLineWithHeading("printNumberReverse");
    RecursionProblems.printNumberReverse(1, 5);
    ArrayLogics.DrawLineWithHeading("printNumberBackTracking1TON");
    RecursionProblems.printNumberBackTracking1TON(5, 5);
    ArrayLogics.DrawLineWithHeading("printNumberBackTrackingNTO1");
    RecursionProblems.printNumberBackTrackingNTO1(1, 5);
}
void BasicMathsPrograms()
{
    Console.WriteLine("GCD :" + BasicMaths.GCD(24, 36));

    Console.WriteLine("CircularRotation Output :" + String.Join(" ", Numbers.circularRotation([1, 2, 3, 4, 5])));
    Console.WriteLine("countDigits : " + BasicMaths.countDigits(12345));
    Console.WriteLine("reverseNumber : " + BasicMaths.reverseNumber(12345));
    BasicMaths.PrintAllDivisors(36);
    BasicMaths.PrintAllDivisors(97);
}
void LoadPatterns()
{
    Patterns.PrintStarPattern1(4);
    Patterns.PrintStarPattern2(4);
    Patterns.PrintStarPattern3(5);
    Patterns.PrintStarPattern4(5);
    Patterns.PrintStarPattern5(5);
    Patterns.PrintStarPattern6(5);
    Patterns.PrintStarPattern7(5);
    Patterns.PrintStarPattern8(5);
    Patterns.PrintStarPattern10(5);
    Patterns.PrintStarPattern11(5);
    Patterns.PrintStarPattern12(9);
    Patterns.PrintStarPattern13(5);
    Patterns.PrintStarPattern14(5);
    Patterns.PrintStarPattern15(5);
    Patterns.PrintStarPattern16(10);
    Patterns.PrintStarPattern17(4);


}
void LoadArrayPrograms()
{
    //Console.WriteLine($"RestoreString : " + String_Array_Program.RestoreString("codeleet", [4, 5, 6, 7, 0, 2, 1, 3]));
    Console.WriteLine(String_Array_Program.CountMatches([["phone", "blue", "pixel"], ["computer", "silver", "lenovo"], ["phone", "gold", "iphone"]], "color", "silver"));
    Console.WriteLine(String_Array_Program.firstNonRepeatedCharacter("aabbcdd"));
    Console.WriteLine(String_Array_Program.IsPathCrossing("SN"));
    Console.WriteLine(String_Array_Program.TruncateSentence("Hello how are you Contestant", 4));
    String_Array_Program.SecondLargestElement([1, 2, 4, 7, 7, 5]);
    Console.WriteLine($"PrintPrimeNumbers : " + String.Join(", ", String_Array_Program.PrintPrimeNumbers(100)));
    Console.WriteLine($"LeftRightDifference : " + String.Join(", ", String_Array_Program.LeftRightDifference([10, 4, 8, 3])));
    Console.WriteLine($"CheckPalindrome : " + Numbers.CheckPalindrome("radar"));
    Console.WriteLine($"GetArrayStringsAreEqual : " + String_Array_Program.GetArrayStringsAreEqual(["ab", "c"], ["a", "bc"]));
    Console.WriteLine($"GetBalancedStringSplit : " + String_Array_Program.GetBalancedStringSplit("RLRRRLLRLL"));

    ArrayLogics.DrawLine();
    Console.WriteLine($"GetInterpret : " + String_Array_Program.GetInterpret("G()(al)"));
    ArrayLogics.DrawLine();

    Console.WriteLine($"GetRotateString : " + String_Array_Program.GetRotateString("abcde", "cdeab"));
    ArrayLogics.DrawLine();

    Console.WriteLine($"GetNumJewelsInStones : " + String_Array_Program.GetNumJewelsInStones("aA", "aAAbbbb"));
    ArrayLogics.DrawLine();
    Console.WriteLine($"GetDefangIPaddr : " + String_Array_Program.GetDefangIPaddr("255.100.50.0"));
    ArrayLogics.DrawLine();
    Console.WriteLine("GetMostCommonWord : " + String_Array_Program.GetMostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", ["hit"]));
    ArrayLogics.DrawLine();
    int GetFinalValueAfterOperationsResult = ArrayLogics.GetFinalValueAfterOperations(["--X", "X++", "X++"]);
    Console.WriteLine($"GetFinalValueAfterOperationsResult) : " + GetFinalValueAfterOperationsResult);
    ArrayLogics.DrawLine();

    int[] GetBuildArrayResult = ArrayLogics.GetBuildArray([0, 2, 1, 5, 3, 4]);
    Console.WriteLine($"GetBuildArray) : " + string.Join(", ", GetBuildArrayResult));
    ArrayLogics.DrawLine();

    int GetMostWordsFoundResult = ArrayLogics.GetMostWordsFound(["alice and bob love programming", "i think so too", "this is great thanks very much"]);
    Console.WriteLine($"GetMostWordsFound) : " + GetMostWordsFoundResult);
    ArrayLogics.DrawLine();

    int[] GetRunningSumResult = ArrayLogics.GetRunningSum([1, 2, 3, 4]);
    Console.WriteLine($"GetRunningSum) : " + string.Join(", ", GetRunningSumResult));
    ArrayLogics.DrawLine();


    int[] GetSmallerNumbersThanCurrentResult = ArrayLogics.GetSmallerNumbersThanCurrent([6, 5, 4, 9]);
    Console.WriteLine($"GetSmallerNumbersThanCurrent) : " + string.Join(", ", GetSmallerNumbersThanCurrentResult));
    ArrayLogics.DrawLine();

    int GetCountPairs = ArrayLogics.GetCountPairs([-1, 1, 2, 3, 1], 2);
    Console.WriteLine($"GetCountPairs) : " + GetCountPairs);
    ArrayLogics.DrawLine();

    IList<bool> GetKidsWithCandiess = ArrayLogics.GetKidsWithCandiess([12, 1, 12], 10);
    Console.WriteLine($"GetKidsWithCandiess) : " + string.Join(", ", GetKidsWithCandiess));
    ArrayLogics.DrawLine();

    int GetNumberOfEmployeesWhoMetTargetResult = ArrayLogics.GetNumberOfEmployeesWhoMetTarget([5, 1, 4, 2, 2], 6);
    Console.WriteLine($"GetNumberOfEmployeesWhoMetTarget) : " + GetNumberOfEmployeesWhoMetTargetResult);

    ArrayLogics.DrawLine();



    int[] InterviewQuestionResult = ArrayLogics.InterviewQuestion([2, 4, 5, 6, 8, 9, 10], [6, 7, 8, 10, 12, 13, 14, 20]);
    Console.WriteLine($"InterviewQuestion) : " + string.Join(", ", InterviewQuestionResult));
    ArrayLogics.DrawLine();


    int getMaximumWealthResult = ArrayLogics.GetMaximumWealth([[1, 5], [7, 3], [3, 5]]);
    Console.WriteLine($"getMaximumWealth) : " + getMaximumWealthResult);
    Console.WriteLine("Option 2 :  return accounts.Select(x=>x.Sum()).Max();");
    ArrayLogics.DrawLine();


    IList<int> findWordsContainingResult = ArrayLogics.FindWordsContaining(["abc", "bcd", "aaaa", "cbc"], 'a');
    Console.WriteLine($"findWordsContainingResult) : " + string.Join(", ", findWordsContainingResult));
    ArrayLogics.DrawLine();
    int getNumIdenticalPairsResult = ArrayLogics.GetNumIdenticalPairs([1, 2, 3, 1, 1, 3]);
    Console.WriteLine($"getNumIdenticalPairsResult) : " + getNumIdenticalPairsResult);
    ArrayLogics.DrawLine();
    int[] getShuffleResult_Logic1 = ArrayLogics.GetShuffle_Logic1([2, 5, 1, 3, 4, 7], 3);
    Console.WriteLine($"getShuffleResult_Logic1): [{string.Join(", ", getShuffleResult_Logic1)}]");

    ArrayLogics.DrawLine();
    int[] getShuffleResult = ArrayLogics.GetShuffle([2, 5, 1, 3, 4, 7], 3);
    Console.WriteLine($"getShuffleResult): [{string.Join(", ", getShuffleResult)}]");
    ArrayLogics.DrawLine();


    int[] getConcatenationResult = ArrayLogics.GetConcatenation([1, 2, 1]);
    Console.WriteLine($"getConcatenationResult): [{string.Join(", ", getConcatenationResult)}]");

    ArrayLogics.DrawLine();

    int[] result = ArrayLogics.FindSumPositions([3, 2, 4], 6);
    Console.WriteLine($"Indices of elements that sum up to the target: [{result[0]}, {result[1]}]");

    ArrayLogics.DrawLine();

}
Console.ReadLine();
*/