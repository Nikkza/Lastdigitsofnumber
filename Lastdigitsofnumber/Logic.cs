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
            List<ulong> listBigInt = new List<ulong>();
            var split = value.Split(',');
            if (split.Length == 2)
            {
                foreach (var item in split)
                {
                    if (ulong.TryParse(item.ToString(), out ulong bigint))
                        listBigInt.Add(bigint);
                    else
                        return new List<ulong> { };
                }
            }
            else
                return new List<ulong> { };

            return listBigInt;
        }
    }
}
