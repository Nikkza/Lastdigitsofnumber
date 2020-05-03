using System;

namespace Lastdigitsofnumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Example for using this program, {Environment.NewLine}" +
                  $"You enter these parameters in the example below. Must also be number. {Environment.NewLine}" +
                  $" {Environment.NewLine}Ex: 23457,2 the result out is 5,7");

            while (true)
            {
                Logic logic = new Logic();
                string numberAndDigits = Console.ReadLine();
                var getNummbersAsList = logic.GetNumberDigiAsList(numberAndDigits);
                if (getNummbersAsList.Count > 0)
                {
                    var results = logic.LastDigitsOfaNumber(getNummbersAsList[0], getNummbersAsList[1]);
                    if (!(results.Length <= 0))
                        Console.WriteLine($"Results {string.Join(",", results)}");
                    else
                        Console.WriteLine($"null {0}");
                }
                else
                    Console.WriteLine($"Must enter 2 arguments, or must be numbers, or number must be < 10000000000");
            }
        }
    }
}
