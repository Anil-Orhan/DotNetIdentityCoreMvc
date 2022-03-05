using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer.Abstract;


namespace BusinessLayer.Concrete
{
    public class CalculatorManager : ICalculatorService
    {
        public string Calculation(string calculationString)
        {
            Console.Write(calculationString);
            return "BUSSINES RESULT";
        }

        public decimal Addition(params int[] numbers)
        {
            return numbers.Sum();
        }

        public decimal Subtraction(params int[] numbers)
        {
            var result = numbers[0];
            foreach (var item in numbers)
            {
                result -= item;
            }

            return result + numbers[0];
        }

        public decimal Multiplication(params int[] numbers)
        {
            var result = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            return result;
        }

        public decimal Division(params int[] numbers)
        {


            var result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result /= numbers[i];
            }

            return result;
        }
    }
}
