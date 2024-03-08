namespace FizzBuzz.Utilities
{
    public static class DivisionLogger
    {
        public static void LogDivision(int number, int divisor)
        {
            Console.WriteLine($"Divided {number} by {divisor}");
        }

        public static void LogInvalidItem()
        {
            Console.WriteLine("Invalid Item");
        }
    }
}