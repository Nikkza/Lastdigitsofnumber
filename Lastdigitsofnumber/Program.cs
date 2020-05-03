using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lastdigitsofnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            while (true)
            {
                string numberAndDigits = Console.ReadLine();
                var getNummbersAsList = logic.GetNumberDigiAsList(numberAndDigits);
                if (getNummbersAsList.Count > 0)
                {
                    var results = logic.LastDigitsOfaNumber(getNummbersAsList[0], (long)getNummbersAsList[1]);
                    if (!(results.Length <= 0))
                        Console.WriteLine($"{string.Join(",", results)}");
                    else
                        Console.WriteLine($"null {0}");
                }
                Console.ReadLine();
            }
        }
    }
}
