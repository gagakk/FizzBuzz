using System.Collections.Generic;

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