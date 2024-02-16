namespace Delegate
{
    delegate int calculator(int a, int b);
    public class Delegate
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        static void Main(String[] args)
        {
            calculator calculator = new calculator(Add);
            Console.WriteLine(calculator(10, 20));

            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            var cheapBooks = GetBooks().FindAll(book => book.Price <= 50);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Name);
            }
        }
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Name = "Java", Price = 30 },
                new Book { Name = "Dotnet", Price = 50 },
                new Book { Name = "C", Price = 100 }
            };
        }
    }
}