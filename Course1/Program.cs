using System.Numerics;

namespace Stanford.Algorithms.Course1
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatsuba k = new Karatsuba();
            BigInteger x = BigInteger.Parse("31412718");
            BigInteger y = BigInteger.Parse("27182718");
            BigInteger result = k.Multiply(x, y);
            System.Console.WriteLine("        result:" + result);
            System.Console.WriteLine("correct result:" + BigInteger.Multiply(x,y));
        }
    }
}
