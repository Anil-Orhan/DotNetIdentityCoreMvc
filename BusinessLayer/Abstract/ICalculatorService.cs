using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICalculatorService
    {
        string Calculation(string calculationString);
        decimal Addition(params int[] numbers);
        decimal Subtraction(params int[] numbers);

        decimal Multiplication(params int[] numbers);

        decimal Division(params int[] numbers);




    }
}
