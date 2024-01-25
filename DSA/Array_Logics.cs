namespace DSA
{
    public static class ArrayLogics
    {

        public static int GetFinalValueAfterOperations(string[] operations)
        {
            Console.WriteLine("Input: operations = [\"--X\",\"X++\",\"X++\"]\r\nOutput: 1 ");
            int x = 0;
            foreach (string operation in operations)
            {
                if (!operation.Contains("--"))
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
            return x;
        }

        public static int[] GetBuildArray(int[] nums)
        {
            Console.WriteLine("Input: nums = [0,2,1,5,3,4]\r\nOutput: [0,1,2,4,5,3]");
            Console.WriteLine("Explanation: The array ans is built as follows: \r\nans = [nums[nums[0]], nums[nums[1]], nums[nums[2]], nums[nums[3]], nums[nums[4]], nums[nums[5]]]\r\n    = [nums[0], nums[2], nums[1], nums[5], nums[3], nums[4]]\r\n    = [0,1,2,4,5,3]\r\nExample 2:");
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[nums[i]];
            }
           return  nums.Select(x => nums[x]).ToArray();
            // return result;
        }

        public static int GetMostWordsFound(string[] sentences)
        {
            Console.WriteLine("Input: sentences = [\"alice and bob love leetcode\", \"i think so too\", \"this is great thanks very much\"]\r\nOutput: 6");
            int max = 0;
            foreach (string sentence in sentences)
            {
                int temp = 0;

                foreach (string word in sentence.Split(" "))
                {
                    temp++;
                }
                if (temp > max) { max = temp; }
            }
            //sentences.Select(s => s.Count(c => c == '').ToString());
            return max;

        }
        public static int[] GetRunningSum(int[] nums)
        {
            Console.WriteLine("Input: nums = [1,2,3,4]\r\nOutput: [1,3,6,10]");
            //int[] result = new int[nums.Length];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        sum += nums[i];
            //        result[i] = sum;
            //    }
            //    else
            //    {
            //        sum += nums[i];
            //        result[i] = sum;
            //    }
            //}
            //return result;
            int sum = 0;
            return nums.Select(x => x += sum).ToArray();
        }
        public static int[] GetSmallerNumbersThanCurrent(int[] nums)
        {
            Console.WriteLine("Input: nums = [8,1,2,2,3]\r\nOutput: [4,0,1,1,3]");
            var list = nums.ToList();

            list.Sort();

            var res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = list.IndexOf(nums[i]);
            }

            return res;
        }

        public static int GetCountPairs(IList<int> nums, int target)
        {
            Console.WriteLine("Input: nums = [-1,1,2,3,1], target = 2\r\nOutput: 3");
            int count = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] + nums[j] < target)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
        public static IList<bool> GetKidsWithCandiess(int[] candies, int extraCandies)
        {
            IList<bool> result = new List<bool>();
            Console.WriteLine("Input: [12,1,12], extraCandies = 10");
            Console.WriteLine("Output: [true,true,true,false,true]");
            int maxCandies = candies.Select(x => x).Max();
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= maxCandies)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }
            return result;
        }
        public static int GetNumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {

            Console.WriteLine("Input: hours = [5,1,4,2,2], target = 6");
            Console.WriteLine("Output: 0");
            int result = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                if (hours[i] >= target)
                {
                    result++;
                }
            }
            return result;
        }

        public static int[] InterviewQuestion(int[] array1, int[] array2)
        {
            Console.WriteLine("Input: : { 2, 4, 5, 6, 8, 9, 10 } ,{ 6, 7, 8, 10, 12, 13, 14, 20 }");
            Console.WriteLine("Scenario: No Duplicates:");
            Console.WriteLine("Output: {2,4,5,6,7,8,9,10,12, 13, 14, 20}");

            int[] result = new int[array1.Length + array2.Length];
            int maxValueInTheResult = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] > array2[j])
                    {
                        continue;
                    }
                    if (array1[i] <= array2[j])
                    {
                        result[i] = array1[i];
                    }
                }

            }

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i];
            }
            for (int j = 0; j < array2.Length; j++)
            {

                result[j + array1.Length] = array2[j];
            }
            return result;

        }
        public static int GetMaximumWealth(int[][] accounts)
        {

            int maxWealth = 0;
            Console.WriteLine("Input: accounts = [[1,5],[7,3],[3,5]]");
            Console.WriteLine("Output: 10");
            foreach (var account in accounts)
            {
                int result = 0;
                for (int i = 0; i < account.Length; i++)
                {
                    result += account[i];
                }
                if (result > maxWealth)
                {
                    maxWealth = result;
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
