using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lastdigitsofnumber
{
    public class Logic
    {
        public char[] LastDigitsOfaNumber(ulong number, ulong lastdigits)
        {
            char[] numberAsCharArray;
            if (lastdigits <= 0) return new char[] { };
            else if (number.ToString().Length > lastdigits.ToString().Length)
            {
                numberAsCharArray = number.ToString()
                .Substring(number.ToString()
                .Length - (int)lastdigits).ToCharArray();
            }
            else
                return new char[] { };

            return numberAsCharArray;
        }

        public List<ulong> GetNumberDigiAsList(string value)
        {
            List<ulong> listNumbers = new List<ulong>();
            long biggestNumber = 10000000000;
            var split = value.Split(',');
            var largestNumberValid = long.Parse(split[0]);
            if (split.Length == 2 && largestNumberValid < biggestNumber)
            {
                foreach (var item in split)
                {
                    if (ulong.TryParse(item.ToString(), out ulong number))
                        listNumbers.Add(number);
                    else
                        return new List<ulong> { };
                }
            }
            else
                return new List<ulong> { };

            return listNumbers;
        }
    }
}
