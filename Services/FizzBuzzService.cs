using System.Collections.Generic;
using FizzBuzz.Logic;
using FizzBuzz.Utilities;

namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> CalculateFizzBuzz(List<object> inputArray)
        {
            var results = new List<string>();

            foreach (var item in inputArray)
            {
                if (item is int number)
                {
                    results.Add(FizzBuzzLogic.CalculateResult(number));
                }
                else if (int.TryParse(item.ToString(), out int parsedNumber))
                {
                    string outputString = FizzBuzzLogic.CalculateResult(parsedNumber);
                    if (outputString.Contains('\n'))
                    {
                        // Split the string at '\n'
                        string[] lines = outputString.Split('\n');

                        // Add each line to the results list
                        foreach (var line in lines)
                        {
                            results.Add(line);
                        }
                    }
                    else
                    {
                        results.Add(outputString);
                    }
                }
                else
                {
                    DivisionLogger.LogInvalidItem();
                    results.Add("Invalid Item");
                }
            }

            return results;
        }
    }
}