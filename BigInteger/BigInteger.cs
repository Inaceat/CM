using System;

namespace BigInteger
{
    public struct BigInteger
    {
        public BigInteger(string number)
        {
            
        }

        public override string ToString()
        {
            return "42";
        }


        public static BigInteger operator + (BigInteger left, BigInteger right)
        {
            return left;
        }

        public static BigInteger operator - (BigInteger left, BigInteger right)
        {
            return left;
        }

        public static BigInteger operator * (BigInteger left, BigInteger right)
        {
            return left;
        }

        public bool IsComposite()
        {
            return new Random().Next(0, 2) == 0;
        }
    }
}
