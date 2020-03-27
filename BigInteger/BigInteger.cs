using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BigInteger
{
    public class BigInteger
    {
        private static readonly Regex NumberRegex = new Regex(@"^(\+|-)?[0-9]+$");


        private List<uint> _digits;
        private bool _isPositive;

        public BigInteger(string number)
        {
            if (!NumberRegex.IsMatch(number))
                throw new ArgumentException();

            if (0 == NumberRegex.Matches(number)[0].Groups.Count ||
                "+" == NumberRegex.Matches(number)[0].Groups[1].Value)
                _isPositive = true;

            
            _digits = new List<uint>();
            
            _digits.Add(0);

            for (var i = number.Length - 1; i >= 0; ++i)
            {
                
            }
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
