/*
* Using Test-driven development (TDD) approach
* Numbers need to be passed to method as parameter (type of parameter is not specified).
* But for multiples of three print "Fizz" instead of the number
* and for the multiples of five print "Buzz".
* For numbers which are multiples of both three and five print "FizzBuzz".
*/

namespace consoleTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class FizzBuzz
    {
        public string[] GenerateFizzBuzz(params int[] numbers)
        {
            string[] retVal = new string[numbers.Length];
            int iterator = 0;
            foreach (var number in numbers)
            {
                string numberString = "";
                if (number % 3 == 0)
                    numberString += "Fizz";

                if (number % 5 == 0)
                    numberString += "Buzz";

                if (numberString == "")
                    numberString = number.ToString();

                retVal[iterator] = numberString;
                iterator++;
            }

            return retVal;
        }
    }
}
