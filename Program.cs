using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the FizzBuzz Wolrd!!");
                FizzBuzz fb = new FizzBuzz();
                fb.ComputeFizzBuzz();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured due to "+ex.Message);
            }
        }
    }
}
