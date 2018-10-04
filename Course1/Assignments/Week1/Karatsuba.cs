using System.Numerics;

namespace Stanford.Algorithms.Course1
{
    class Karatsuba
    {
        public BigInteger Multiply(BigInteger x, BigInteger y)
        {

            string xString = x.ToString();
            string yString = y.ToString();
            int xMid = xString.Length / 2;
            int yMid = yString.Length / 2;

            if (xString.Length == 1 || yString.Length == 1)
            {
                return BigInteger.Multiply(x, y);
            }
            else
            {
                BigInteger a = BigInteger.Parse(xString.Substring(0, xMid));
                BigInteger b = BigInteger.Parse(xString.Substring(xMid, xString.Length - xMid));
                BigInteger c = BigInteger.Parse(yString.Substring(0, yMid));
                BigInteger d = BigInteger.Parse(yString.Substring(yMid, yString.Length - yMid));

                BigInteger ac = Multiply(a, c);
                BigInteger bd = Multiply(b, d);
                BigInteger aPlusB = BigInteger.Add(a, b);
                BigInteger cPlusD = BigInteger.Add(c, d);
                BigInteger gauss = BigInteger.Subtract(Multiply(aPlusB, cPlusD), BigInteger.Add(ac, bd));
                BigInteger termOne = BigInteger.Multiply(BigInteger.Pow(10, xString.Length), ac);
                BigInteger termTwo = BigInteger.Multiply(BigInteger.Pow(10, xMid), gauss);
                return BigInteger.Add(BigInteger.Add(termOne,termTwo),bd);
            }


        }
    }
}
