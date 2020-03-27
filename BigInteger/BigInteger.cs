using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BigInteger
{
    public class BigInteger
    {
        private static readonly Regex NumberRegex = new Regex(@"^(?:\+|-)?[0-9]+$");

        public BigInteger(string number)
        {
            if (!NumberRegex.IsMatch(number))
                throw new ArgumentException();


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
