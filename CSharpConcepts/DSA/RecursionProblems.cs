namespace CSharpConcepts.DSA
{
    public class RecursionProblems
    {
        public static int returnFibonacciofGivenNumber(int n) {
            if(n<=1) {
                return n;
            }
            int last = returnFibonacciofGivenNumber(n-1);
            int sLast= returnFibonacciofGivenNumber(n-2);
            return last + sLast;
        }
        public static bool checkStringisPalindrome(string s, int l)
        {
            if (s == null) { return false; }
            int n = s.Length;
            if (l == n / 2)
            {
                return true;
            }
            else
            {
                if (s[l] == s[n - l - 1])
                {
                    return checkStringisPalindrome(s, l + 1);
                }
            }
            return false;
        }
        public static int[] swapArray(int[] array, int l, int[] swapResult)
        {
            int n = swapResult.Length;
            if (l == n/2)
            {
                swapResult[l] = array[l];
                return swapResult;
            }
            else
            {
                swapResult[l] = array[n-l-1];
                swapResult[n - l - 1] = array[l];
                swapArray(array, l+1, swapResult);
            }
            return swapResult;
        }
        public static int returnMultiplyofN_Numbers(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * returnMultiplyofN_Numbers(n - 1);
        }
        public static void printSumofN_Numbers(int i, int n, int sum)
        {
            if (i > n)
            {
                Console.WriteLine("Sum is " + sum);
                return;
            }
            printSumofN_Numbers(i + 1, n, sum + i);
        }
        public static void printNumberBackTracking1TON(int i, int n)
        {
            if (i < 1) { return; }
            printNumberBackTracking1TON(i - 1, n);
            Console.WriteLine(i);
        }
        public static void printNumberBackTrackingNTO1(int i, int n)
        {
            if (i > n) { return; }
            printNumberBackTrackingNTO1(i + 1, n);
            Console.WriteLine(i);
        }
        public static void printNumberReverse(int i, int n)
        {
            if (n == 0) { return; }
            Console.WriteLine(n);
            n--;
            printNumberReverse(i, n);
        }
        public static void printNumber(int i, int n)
        {
            if (i > n) { return; }
            Console.WriteLine(i);
            i++;
            printNumber(i, n);
        }
        public static void printName(int i, int n)
        {
            if (i > n) { return; }
            Console.WriteLine("Saleem");
            i = i + 1;
            printName(i, n);
        }
    }
}
