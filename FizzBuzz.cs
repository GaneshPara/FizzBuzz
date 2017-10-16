using System;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {

        /// <summary>
        /// To Validate the given Method Input
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        private static double ValidateValue(string strValue)
        {
            double val;
            try
            {
                while (!double.TryParse(strValue, out val) || (strValue.Trim() == "0"))
                {
                    if (strValue.Trim() == "0")
                        Console.WriteLine("Zero is invalid input. Please enter a valid number.");
                    else
                        Console.WriteLine("Given input is invalid. Please enter a valid number.");

                    strValue = Console.ReadLine();
                }
                return val;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Compute FizzBuzz
        /// </summary>
        public void ComputeFizzBuzz()
        {
            try
            {
                string strCheck;
                do
                {
                    Console.WriteLine("Please enter a valid number, except zero.");
                    string strVal = Console.ReadLine();
                    double number = ValidateValue(strVal);
                    Console.WriteLine("Result Is: " + CheckFizzBuzz(number));

                    Console.WriteLine("Press 1 to continue or press any other key to exit.");
                    strCheck = Console.ReadLine();
                    Console.WriteLine("**************");
                } while (strCheck.Trim() == "1");
                Console.WriteLine("Thank you");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured " + e.Message);
            }
        }

        /// <summary>
        /// Check FizzBuzz
        /// </summary>
        /// <param name="number"></param>
        public string CheckFizzBuzz(double number)
        {
            int fizz = 3, buzz = 5;

            if (number % fizz == 0 && number % buzz == 0)
                return "FizzBuzz";
            else if (number % fizz == 0)
                return "Fizz";
            else if (number % buzz == 0)
                return "Buzz";
            else
                return Convert.ToString(number);
        }
    }
}
