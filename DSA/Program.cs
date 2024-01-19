using DSA;

Console.WriteLine($"GetBalancedStringSplit : " + String_Array_Program.GetBalancedStringSplit("RLRRRLLRLL"));

ArrayLogics.DrawLine();




//LoadArrayPrograms();

void LoadArrayPrograms()
{
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

    int GetMostWordsFoundResult = ArrayLogics.GetMostWordsFound(["alice and bob love leetcode", "i think so too", "this is great thanks very much"]);
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