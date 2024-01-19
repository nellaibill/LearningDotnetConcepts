using System.Text;

namespace DSA
{
    public static class String_Array_Program
    {
        public static int GetBalancedStringSplit(string s)
        {
            Console.WriteLine("Input: s = \"RLRRRLLRLL\"\r\nOutput: 2\r\nExplanation: s can be split into \"RL\", \"RRRLLRLL\", each substring contains same number of 'L' and 'R'.\r\nNote that s cannot be split into \"RL\", \"RR\", \"RL\", \"LR\", \"LL\", because the 2nd and 5th substrings are not balanced.");
            int result = 0;
            int balancedCount = 0;
            foreach(char c in s)
            {
                if (c == 'R')
                {
                    balancedCount++;
                }
                else
                {
                    balancedCount--;
                }
                if(balancedCount == 0 )
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

