using ExtensionMethods;

class Program
{
    static void Main(string[] args)
    {
        string post = "This is suppose to be a very long post";
        var shortenPost = post.Shorten(5);
        Console.WriteLine(shortenPost);
    }
}

