using Calculator.Services;
using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            double addResult = calculate.Add(10, 7);
            calculate.DisplayResults(addResult);


            double secondResult = calculate.Minus(10, 7);
            calculate.DisplayResults(secondResult);

            double multipicationResult = calculate.Multipilation(10, 7);
            calculate.DisplayResults(multipicationResult);

            Console.ReadLine();
        }
    }
}
