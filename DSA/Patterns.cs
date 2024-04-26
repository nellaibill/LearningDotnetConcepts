using System.Text;
using System.Threading.Channels;

namespace DSA
{
    public class Patterns
    {
        public static void PrintStarPattern1(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern1");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern2(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern2");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern3(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern3");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern4(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern4");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }
        }

        public static void PrintStarPattern5(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern5");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern6(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern6");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern7(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern7");
            for (int i = 0; i <= n; i++)
            {
                //Space
                for (int j = 0; j <= n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                //Star
                for (int j = 0; j <= i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                //Space
                for (int j = 0; j <= n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintStarPattern8(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern8");
            for (int i = 0; i < n; i++)
            {
                //Space
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                //Star
                for (int j = n * 2 - 1 - i * 2; j >= 1; j--)
                {
                    Console.Write("*");
                }
                //Space
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        //39:02
        public static void PrintStarPattern10(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern10");
            for (int i = 0; i <= 2 * n - 1; i++)
            {
                int stars = i;
                if (i > n) { stars = 2 * n - i; }
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern11(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern11");
            int start = 1;
            for (int i = 0; i < n; i++)
            {

                if (i % 2 == 0) start = 1;
                else start = 0;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(start);
                    start = 1 - start;
                }
                Console.WriteLine();
            }
        }

        public static void PrintStarPattern12(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern12");
            int space = 2 * (n - 1);
            for (int i = 1; i <= n; i++)
            {
                //number
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                //space
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                //number
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                space = space - 2;
            }
        }
        public static void PrintStarPattern13(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern13");
            int printingNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                //number
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(printingNumber + " ");
                    printingNumber++;
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern14(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern14");
            for (int i = 1; i <= n; i++)
            {
                for (char ch = 'A'; ch <= 'A' + i; ch++)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintStarPattern15(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern15");
            for (int i = 0; i <= n; i++)
            {
                for (char ch = 'A'; ch <= 'A' + (n - i - 1); ch++)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintStarPattern16(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern16");
        
            for (int i = 0; i < n; i++)
            {
                char ch = (char)('A' + i);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern17(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern17");
            for (int i = 0; i <=n; i++)
            {
                //Space
                for (int j = 0; j <= n - i - 1; j++)
                {
                    Console.Write('-');
                }
                //Print Character
                char ch = 'A';
                int albhabets = i * 2 + 1;
                int breakpoint = albhabets / 2 + 1;
                for (int j = 1; j <= albhabets; j++)
                {
                    Console.Write(ch);
                    if (j < breakpoint)
                        ch++;
                    else
                        ch--;
                   
                }
                //Space
                for (int j = 0; j <= n - i - 1; j++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }
        }
        public static void PrintStarPattern18(int n)
        {
            DrawLineAndPrintMethod("PrintStarPattern18");
            char initialCharacter = (char)('A' + n - 1);
            //for (char ch = initialCharacter; ch >='A'; ch--)
            for(int i= 1; i <=n;i++)
            {
                //Character
                for (int j = 0; j <i; j++)
                {
                    Console.Write((char)(initialCharacter-j));
                }
                
                //Space
                for (int j = 0; j <= n - i - 1; j++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }
        }
        public static void DrawLineAndPrintMethod(string methodname)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(methodname);
        }
    }
}
