using System;

namespace FizzBuzz
{
    public class Fizzbuzz
    {
        static void Main(string[] args)
        {
            Counter();
        }

        public static void Counter(int number = 100)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(NumberCheck(i));
            }
        }

        public static string NumberCheck(int number)
        {
            if (DivisibleBy(number, 15)) { return "FizzBuzz"; }
            if (DivisibleBy(number, 3)) { return "Fizz"; }
            if (DivisibleBy(number, 5)) { return "Buzz"; }
            return $"{number}";
        }

        public static bool DivisibleBy(int number, int dividedBy)
        {
            return number % dividedBy == 0;
        }
    }
}
