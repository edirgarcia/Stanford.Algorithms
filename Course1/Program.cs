using System.Numerics;

namespace Stanford.Algorithms.Course1
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatsuba k = new Karatsuba();
            string x = "3141592653589793238462643383279502884197169399375105820974944592";
            string y = "2718281828459045235360287471352662497757247093699959574966967627";
            string result = k.Multiply(x, y);
            System.Console.WriteLine("        result:" + result);
            System.Console.WriteLine("correct result:" + BigInteger.Multiply(BigInteger.Parse(x), BigInteger.Parse(y)));
        }
    }
}
