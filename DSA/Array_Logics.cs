namespace DSA
{
    public static class ArrayLogics
    {
        public static int GetMaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;
            Console.WriteLine("Input: accounts = [[1,5],[7,3],[3,5]]");
            Console.WriteLine("Output: 10");
            int[] array = new int[accounts.Length];
            foreach (var account in accounts)
            {
                array.Append(account[0] + account[1]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        maxWealth = array[i];
                    }
                }
            }
            return maxWealth;
        }

        public static IList<int> FindWordsContaining(string[] words, char x)
        {
            Console.WriteLine("Input : [\"abc\",\"bcd\",\"aaaa\",\"cbc\"], x = \"a\"");
            Console.WriteLine("Expected Output:  [0,2]");
            List<int> result = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                char[] test = words[i].ToCharArray();
                foreach (char c in test)
                {
                    if (c == x)
                    {
                        result.Add(i);
                        break;
                    }
                }
                //if(words[i].Contains(x))
                // result.Add(i);
            }
            return result;
        }
        public static int GetNumIdenticalPairs(int[] nums)
        {
            Console.WriteLine("Input : [1,2,3,1,1,3]");
            Console.WriteLine("Expected Output: 4 ");
            Console.WriteLine("Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.");
            int result = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        public static int[] FindSumPositions(int[] nums, int target)
        {
            Console.WriteLine("Input: [3, 2, 4], 6 ");
            Console.WriteLine("Expected Output: [1,2]");
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }

        public static int[] GetConcatenation(int[] nums)
        {
            Console.WriteLine("Input: [1, 2, 1] ");
            Console.WriteLine("Expected Output: [1,2,1,1,2,1]");
            int n = nums.Length;
            int[] ans = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[i];
                ans[i + n] = nums[i];
            }
            return ans;
        }

        public static int[] GetShuffle_Logic1(int[] nums, int n)
        {
            Console.WriteLine("Input: nums = [2, 5, 1, 3, 4, 7], n = 3");
            Console.WriteLine("Expected Output: [2,3,5,4,1,7]");

            int[] result = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                result[2 * i] = nums[i];
                result[2 * i + 1] = nums[i + n];
            }
            return result;
        }
        public static int[] GetShuffle(int[] nums, int n)
        {
            Console.WriteLine("Input: nums = [2, 5, 1, 3, 4, 7], n = 3");
            Console.WriteLine("Expected Output: [2,3,5,4,1,7]");
            int[] result = new int[n * 2];
            int j = 0;
            for (int i = 0; i < result.Length;)
            {
                if (i % 2 == 0 || i == 0)
                {
                    result[i] = nums[j];
                    j++;
                }
                else
                {
                    result[i] = nums[n];
                    n++;
                }
                i++;
            }
            return result;
        }

        public static void DrawLine()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }
}
