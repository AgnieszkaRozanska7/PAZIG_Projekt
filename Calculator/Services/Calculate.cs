using Calculator.Services.Interfaces;
using System;

namespace Calculator.Services
{
    internal class Calculate : ICalculate
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void DisplayResults(double result)
        {
           Console.WriteLine($"Result: {result}");
        }

        public double Minus(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
