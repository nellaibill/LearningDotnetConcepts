namespace Generics
{

    public class ConstraintToADictionary<Tkey, Tvalue>
    {
        public void Add(Tkey key, Tvalue value) { }
    }
    public class ConstraintToAvalueType<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
    public class ConstraintsComparable<T> where T : IComparable
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new ConstraintToADictionary<string, string>();
            test.Add("A", "B");
            test.Add("B", "C");
            test.Add("C", "D");

            var test1 = new ConstraintToADictionary<string, int>();
            test1.Add("A", 1);
            test1.Add("B", 2);
            test1.Add("C", 3);

        }
    }
}