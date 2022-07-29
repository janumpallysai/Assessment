using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b) { return a + b; }
    }

    public class Logger
    {
        public void Log(string message) { Console.WriteLine(message); }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            var logger = new Logger();
            var calculator = new Calculator();

            try
            {
                logger.Log("Please enter the first Integer here: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                logger.Log("Please enter the second Integer here: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                logger.Log("Invalid input");
                return;
            }

            var result = calculator.Add(num1, num2);
            logger.Log($"Result is {result}");
        }
    }
}
