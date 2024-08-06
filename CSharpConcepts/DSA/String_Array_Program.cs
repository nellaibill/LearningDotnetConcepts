using System.Collections;
using System.Text;

namespace CSharpConcepts.DSA
{
    public static class String_Array_Program
    {


        public static string ReverseString(string s)
        {
            Console.WriteLine("Input: s = \"hello\"\r\nOutput: \"olleh\"");
     

            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);

        }

        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            Console.WriteLine("Example 1:\r\n\r\nInput: items = [[\"phone\",\"blue\",\"pixel\"],[\"computer\",\"silver\",\"lenovo\"],[\"phone\",\"gold\",\"iphone\"]], ruleKey = \"color\", ruleValue = \"silver\"\r\nOutput: 1\r\nExplanation: There is only one item matching the given rule, which is [\"computer\",\"silver\",\"lenovo\"].\r\nExample 2:\r\n\r\nInput: items = [[\"phone\",\"blue\",\"pixel\"],[\"computer\",\"silver\",\"phone\"],[\"phone\",\"gold\",\"iphone\"]], ruleKey = \"type\", ruleValue = \"phone\"\r\nOutput: 2\r\nExplanation: There are only two items matching the given rule, which are [\"phone\",\"blue\",\"pixel\"] and [\"phone\",\"gold\",\"iphone\"]. Note that the item [\"computer\",\"silver\",\"phone\"] does not match.");
            int ruleKeyIndex = 2;
            int result = 0;
            if (ruleKey == "type")
                ruleKeyIndex = 0;
            else if (ruleKey == "color")
                ruleKeyIndex = 1;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i][ruleKeyIndex] == ruleValue)
                {
                    result++;
                }
            }
            return result;
        }

        public static char firstNonRepeatedCharacter(string input)
        {
            if (input != null)
            {
                char[] chars = input.ToCharArray();

                foreach (char c in input)
                {
                    int count = 0;
                    for (int i = 0; i < chars.Length; i++)
                    {
                        if (chars[i] == c)
                        {
                            count++;
                        }
                        if (count == 1 && i == chars.Length - 1)
                        {
                            return c;
                        }
                    }
                }

            }
            return '\0';
        }
        public static bool IsPathCrossing(string path)
        {
            Console.WriteLine("Input: path = \"NESWW\"\r\nOutput: true\r\nExplanation: Notice that the path visits the origin twice.");
            bool result = false;
            char[] chars = path.ToCharArray();
            int latitude = 0;
            int longitude = 0;
            HashSet<string> valuePairs = new() { "0,0" };
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'N':
                        longitude += 1;
                        break;
                    case 'E':
                        latitude += 1;
                        break;
                    case 'W':
                        latitude -= 1;
                        break;
                    case 'S':
                        longitude -= 1;
                        break;
                }
                if (valuePairs.Contains($"{latitude},{longitude}")) return true;
                valuePairs.Add($"{latitude},{longitude}");
            }
            return result;

        }
        public static string TruncateSentence(string s, int k)
        {
            Console.WriteLine("Input: s = \"Hello how are you Contestant\", k = 4\r\nOutput: \"Hello how are you\"\r\nExplanation:\r\nThe words in s are [\"Hello\", \"how\" \"are\", \"you\", \"Contestant\"].\r\nThe first 4 words are [\"Hello\", \"how\", \"are\", \"you\"].\r\nHence, you should return \"Hello how are you\".");

            //Option 1
            var words = s.Split(" ").Take(k);
            return string.Join(" ", words);

            //Option 2 :
            //string result = "";
            //for (int i = 0; i < k; i++)
            //{
            //    result += words[i].Trim() + " ";
            //}
            //return result.TrimEnd();
        }
        public static void SecondLargestElement(int[] nums)
        {
            //{1,2,4,7,7,5}
            int largest = nums[0];
            int sLargest = -1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > largest)
                {
                    sLargest = largest;
                    largest = nums[i];
                }
                else if ((nums[i] > sLargest) && nums[i] != largest)
                {
                    sLargest = nums[i];
                }
            }
            Console.WriteLine("sLargest" + sLargest);
        }
        //public static string RestoreString(string s, int[] indices)
        //{
        //    Console.WriteLine("Input: s = \"codeleet\", indices = [4,5,6,7,0,2,1,3]\r\nOutput: \"leetcode\"\r\nExplanation: As shown, \"codeleet\" becomes \"leetcode\" after shuffling.");
        //    char[] chars = new char[s.Length];
        //   for(int i=0;i<indices.Length; i++)
        //    {
        //       // char[i]= s[indices[i]];


        //    }
        //}
        public static int[] PrintPrimeNumbers(int n)
        {
            List<int> result = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (i is 1 or 2)
                {
                    result.Add(i);
                    continue;
                }
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();

        }

        public static int[] LeftRightDifference(int[] nums)
        {
            Console.WriteLine("Input: nums = [10,4,8,3]\r\nOutput: [15,1,11,22]\r\n" +
                "Explanation: " +
                "The array leftSum is [0,10,14,22] and the array rightSum is [15,11,3,0]." +
                "\r\nThe array answer is [|0 - 15|,|10 - 11|,|14 - 3|,|22 - 0|] = [15,1,11,22].");

            int leftSum = 0;
            int rightSum = nums.Sum();
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                result[i] = Math.Abs(leftSum - rightSum);
                leftSum += nums[i];
            }
            return result;

            /*  int[] leftSum = new int[nums.Length];
             int[] rightSum = new int[nums.Length];
             int leftSumCount = 0, rightSumCount = 0;

             int[] result = new int[nums.Length];
             for (int i = 0; i < nums.Length; i++)
             {
                 if (i == 0)
                 {
                     leftSum[i] = leftSumCount;
                     rightSum[nums.Length - 1 - i] = rightSumCount;
                 }
                 else
                 {
                     leftSumCount += nums[i - 1];
                     leftSum[i] = leftSumCount;
                     rightSumCount += nums[nums.Length - i];
                     rightSum[nums.Length - 1 - i] = rightSumCount;
                 }
             }
             for(int i = 0; i < nums.Length; i++)
             {
                 result[i]= Math.Abs(leftSum[i] - rightSum[i]);
             }
             return result */
        }

        public static bool GetArrayStringsAreEqual(string[] word1, string[] word2)
        {
            ArrayLogics.DrawLine();

            return string.Concat(word1) == string.Concat(word2);


            bool result = false;
            StringBuilder stringBuilder1 = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            foreach (string word in word1) { stringBuilder1.Append(word); }
            foreach (string word in word2) { stringBuilder2.Append(word); }
            if (stringBuilder1.ToString() == stringBuilder2.ToString())
            {
                return true;
            }
            return result;
        }
        public static int GetBalancedStringSplit(string s)
        {
            Console.WriteLine("Input: s = \"RLRRRLLRLL\"\r\nOutput: 2\r\nExplanation: s can be split into \"RL\", \"RRRLLRLL\", each substring contains same number of 'L' and 'R'.\r\nNote that s cannot be split into \"RL\", \"RR\", \"RL\", \"LR\", \"LL\", because the 2nd and 5th substrings are not balanced.");
            int result = 0;
            int balancedCount = 0;
            foreach (char c in s)
            {
                if (c == 'R')
                {
                    balancedCount++;
                }
                else
                {
                    balancedCount--;
                }
                if (balancedCount == 0)
                {
                    result++;
                }
            }

            return result;
        }
        public static string GetInterpret(string command)
        {
            Console.WriteLine("Input: command = \"G()(al)\"\r\nOutput: \"Goal\"\r\nGoal Parser will interpret \"G\" as the string \"G\", \"()\" as the string \"o\", and \"(al)\" as the string \"al\".The interpreted strings are then concatenated in the original order");

            return command.Replace("()", "o").Replace("(al)", "al");

        }
        public static bool GetRotateString(string s, string goal)
        {
            if (s.Length != goal.Length) return false;
            string result = s + s;
            if (result.Contains(goal)) return true;

            StringBuilder rotatedString = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                rotatedString.Insert(0, rotatedString[s.Length - 1]);
                rotatedString.Remove(s.Length, 1);
                if (rotatedString.ToString() == goal)
                {
                    return true;
                }
                s = rotatedString.ToString();
            }
            return false;
        }


        public static int GetNumJewelsInStones(string jewels, string stones)
        {
            #region ForLoop
            Console.WriteLine("Input: jewels = \"aA\", stones = \"aAAbbbb\"\r\nOutput: 3");
            char[] charsJewels = jewels.ToCharArray();
            char[] charsStones = stones.ToCharArray();
            int forLoopresult = 0;
            for (int i = 0; i < charsJewels.Length; i++)
            {
                for (int j = 0; j < charsStones.Length; j++)
                {
                    if (charsJewels[i] == charsStones[j])
                    {
                        forLoopresult++;
                    }
                }
            }

            #endregion

            #region HashSet
            Console.WriteLine("Input: jewels = \"aA\", stones = \"aAAbbbb\"\r\nOutput: 3");
            int hashResult = 0;
            HashSet<char> jewelsHash = new HashSet<char>(jewels);
            foreach (char c in stones)
            {
                if (jewelsHash.Contains(c))
                {
                    hashResult++;
                }
            }

            #endregion
            #region foreach

            int forEachResult = 0;
            foreach (char c in stones)
            {
                if (jewels.Contains(c))
                {
                    forEachResult++;
                }

            }

            #endregion
            //return charsStones.Select(x => charsJewels.Contains(x)).Count();
            Console.WriteLine("forLoopresult : " + forLoopresult);
            Console.WriteLine("hashResult : " + hashResult);
            Console.WriteLine("forEachResult : " + forEachResult);
            return forEachResult;
        }

        public static string GetMostCommonWord(string paragraph, string[] banned)
        {
            Console.WriteLine("Input: paragraph = \"Bob hit a ball, the hit BALL flew far after it was hit.\", banned = [\"hit\"]\r\nOutput: \"ball\"");
            string[] words = paragraph.Replace("hit", String.Empty).Replace(",", "").Replace(".", "").Split(" ");
            string result = "";
            int max = 0;

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    int temp = 0;
                    for (int i = 0; i < words.Length; i++)
                    {

                        if (word.ToLower() == words[i].ToLower())
                        {
                            temp++;
                            if (temp > max)
                            {
                                result = word;
                                max = temp;
                            }
                        }
                    }
                }
            }
            return result;

        }

        public static string GetDefangIPaddr(string address)
        {
            Console.WriteLine("Input: address = \"255.100.50.0\"\r\nOutput: \"255[.]100[.]50[.]0\"");
            string[] test = address.Split('.');
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < test.Length; i++)
            {
                if (i == test.Length - 1)
                {
                    result = result.Append(test[i]);
                }
                else
                {
                    result = result.Append(test[i] + "[.]");
                }
            }

            //return result.ToString();
            return address.Replace(".", "[.]");
        }

    }
}

