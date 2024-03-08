using FizzBuzz.Utilities;

namespace FizzBuzz.Logic
{
    public static class FizzBuzzLogic
    {
        public static string CalculateResult(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                DivisionLogger.LogDivision(number, 3);
                DivisionLogger.LogDivision(number, 5);
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                DivisionLogger.LogDivision(number, 3);
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                DivisionLogger.LogDivision(number, 5);
                return "Buzz";
            }
            else
            {
                return $"Divided {number} by 3\nDivided {number} by 5";
            }
        }
    }

}
