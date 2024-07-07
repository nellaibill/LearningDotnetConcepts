using System.Threading.Channels;

namespace CSharpConcepts.DSA
{
    public class BasicMaths
    {
        public static int countDigits(int number)
        {
            int x = number;
            int result = 0;
            while (x > 0)
            {
                x = x / 10;
                result++;
            }
            return result;
        }
        public static string reverseNumber(int number)
        {
            string result = "";
            int remainder = 0;
            while (number > 0)
            {
                remainder = number % 10;
                number = number / 10;
                result = result + remainder;
            }
            return result;
        }

        public static int GCD(int num1, int num2)
        {
            int result = 0;
            int largestNumber = num1 > num2 ? num1 : num2;
            //var sqrt = Math.Sqrt(largestNumber);
            for (int i = 1; i < largestNumber; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    result = i;
                }
            }
            return result;
        }
        public static void PrintAllDivisors(int num)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    result.Add(i);
                    if(i != Math.Sqrt(num))
                        result.Add(num/i);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(" , ",result));
        }
    }
}
