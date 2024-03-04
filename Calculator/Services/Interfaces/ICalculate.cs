﻿namespace Calculator.Services.Interfaces
{
    internal interface ICalculate
    {
        void DisplayResults(double result);

        double Add(double firstNumber, double secondNumber);

        double Minus(double firstNumber, double secondNumber);

        double Multipilation(double firstNumber, double secondNumber);
    }
}
