using System.Numerics;

namespace Stanford.Algorithms.Course1
{
    class Karatsuba
    {
        public string Multiply(string x, string y)
        {

            string xString = x.ToString();
            string yString = y.ToString();
            int xMid = xString.Length / 2;
            int yMid = yString.Length / 2;

            if (xString.Length == 1 || yString.Length == 1)
            {
                return MultiplyStrings(x, y);
            }
            else
            {
                string a = xString.Substring(0, xMid);
                string b = xString.Substring(xMid, xString.Length - xMid);
                string c = yString.Substring(0, yMid);
                string d = yString.Substring(yMid , yString.Length - yMid);

                string ac = Multiply(a, c);
                string bd = Multiply(b, d);
                string aPlusB = Add(a, b);
                string cPlusD = Add(c, d);
                string gauss = Subtract(MultiplyStrings(aPlusB, cPlusD), Add(ac, bd));
                string termOne = MultiplyStrings(Pow(xString.Length), ac);
                string termTwo = MultiplyStrings(Pow(xMid), gauss);
                return Add(Add(termOne,termTwo),bd);
            }


        }

        private string Add(string x, string y)
        {
            BigInteger xBi = BigInteger.Parse(x);
            BigInteger yBi = BigInteger.Parse(y);
            return BigInteger.Add(xBi, yBi).ToString();
        }

        private string Subtract(string x, string y)
        {
            BigInteger xBi = BigInteger.Parse(x);
            BigInteger yBi = BigInteger.Parse(y);
            return BigInteger.Subtract(xBi, yBi).ToString();
        }
        private string MultiplyStrings(string x, string y)
        {
            BigInteger xBi = BigInteger.Parse(x);
            BigInteger yBi = BigInteger.Parse(y);
            return BigInteger.Multiply(xBi, yBi).ToString();
        }

        private string Pow(int x)
        {
            return BigInteger.Pow(10, x).ToString();
        }
    }
}
