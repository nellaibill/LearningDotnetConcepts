using DSA;


int getMaximumWealthResult = ArrayLogics.GetMaximumWealth([[1, 5], [7, 3], [3, 5]]);
Console.WriteLine($"Array Elements(getMaximumWealth) : " + getMaximumWealthResult);
ArrayLogics.DrawLine();

IList<int> findWordsContainingResult=ArrayLogics.FindWordsContaining(["abc", "bcd", "aaaa", "cbc"], 'a');
Console.WriteLine($"Array Elements(findWordsContainingResult) : " + string.Join(", ", findWordsContainingResult));
ArrayLogics.DrawLine();
int getNumIdenticalPairsResult = ArrayLogics.GetNumIdenticalPairs([1, 2, 3, 1, 1, 3]);
Console.WriteLine($"Array Elements(getNumIdenticalPairsResult) : " + getNumIdenticalPairsResult);
ArrayLogics.DrawLine();
int[] getShuffleResult_Logic1 = ArrayLogics.GetShuffle_Logic1([2, 5, 1, 3, 4, 7], 3);
Console.WriteLine($"Array Elements(getShuffleResult_Logic1): [{string.Join(", ", getShuffleResult_Logic1)}]");

ArrayLogics.DrawLine();
int[] getShuffleResult = ArrayLogics.GetShuffle([2, 5, 1, 3, 4, 7], 3);
Console.WriteLine($"Array Elements(getShuffleResult): [{string.Join(", ", getShuffleResult)}]");
ArrayLogics.DrawLine();


int[] getConcatenationResult = DSA.ArrayLogics.GetConcatenation([1, 2, 1]);
Console.WriteLine($"Array Elements(getConcatenationResult): [{string.Join(", ", getConcatenationResult)}]");

ArrayLogics.DrawLine();

int[] result = DSA.ArrayLogics.FindSumPositions([3, 2, 4], 6);
Console.WriteLine($"Indices of elements that sum up to the target: [{result[0]}, {result[1]}]");

ArrayLogics.DrawLine();