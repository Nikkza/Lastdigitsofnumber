using System.Collections.Generic;
using System.Numerics;

namespace Lastdigitsofnumber
{
    public class Logic
    {
        public char[] LastDigitsOfaNumber(BigInteger number, long lastdigits)
        {
            char[] numberAsCharArray;
            if (lastdigits <= 0) return new char[] { };
            else if (number.ToString().Length > lastdigits)
            {
                numberAsCharArray = number.ToString()
                .Substring(number.ToString()
                .Length - (int)lastdigits).ToCharArray();
            }
            else
                return new char[] { };

            return numberAsCharArray;
        }

        public List<BigInteger> GetNumberDigiAsList(string value)
        {
            List<BigInteger> listBigInt = new List<BigInteger>();
            var split = value.Split(',');
            if (split.Length == 2)
            {
                foreach (var item in split)
                {
                    if (BigInteger.TryParse(item, out BigInteger bigint))
                        listBigInt.Add(bigint);
                    else
                        return new List<BigInteger> { };
                }
            }
            else
                return new List<BigInteger> { };

            return listBigInt;
        }
    }
}
