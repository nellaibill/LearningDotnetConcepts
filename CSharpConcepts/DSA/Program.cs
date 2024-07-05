using DSA;
using System.Collections;


int test = 12345;
Console.WriteLine(test.ToString().Sum(x => x - '0'));

/* 
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
/*


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


*/

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


    int[] getConcatenationResult = DSA.ArrayLogics.GetConcatenation([1, 2, 1]);
    Console.WriteLine($"getConcatenationResult): [{string.Join(", ", getConcatenationResult)}]");

    ArrayLogics.DrawLine();

    int[] result = DSA.ArrayLogics.FindSumPositions([3, 2, 4], 6);
    Console.WriteLine($"Indices of elements that sum up to the target: [{result[0]}, {result[1]}]");

    ArrayLogics.DrawLine();

}
Console.ReadLine();