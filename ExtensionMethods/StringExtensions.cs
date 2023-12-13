namespace ExtensionMethods
{
    public static class StringExtensions
    {

        public static string Shorten(this string str,int numberOfWords)
        {
            var words = str.Split(' ');
            return string.Join(" ", words.Take(numberOfWords)) + " ....";
        }
    }
}
