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
            BigInteger parsedValue;
            List<BigInteger> listBigInt = new List<BigInteger>();
            var split = value.Split(',');
            foreach (var item in split)
            {
                parsedValue = BigInteger.Parse(item);
                listBigInt.Add(parsedValue);
            }

            return listBigInt;
        }
    }
}
