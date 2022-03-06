using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BusinessLayer.Abstract;


namespace BusinessLayer.Concrete
{
    public class CalculatorManager : ICalculatorService
    {
        public string Calculation(string calculationString)
        {
            if (!char.IsDigit(calculationString[0]))
                calculationString = calculationString.PadLeft(calculationString.Length + 1, Convert.ToChar("0"));


            if (!char.IsDigit(calculationString[calculationString.Length - 1]))
            {
                calculationString = calculationString + "0";
                return Evaluate(calculationString).ToString();
            }


            return Evaluate(calculationString).ToString();
        }

        public static double Evaluate(string expression)
        {
            try
            {
                var table = new DataTable();
                table.Columns.Add("expression", typeof(string), expression);
                var row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string) row["expression"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public decimal Addition(params int[] numbers)
        {
            return numbers.Sum();
        }

        public decimal Subtraction(params int[] numbers)
        {
            var result = numbers[0];
            foreach (var item in numbers) result -= item;

            return result + numbers[0];
        }

        public decimal Multiplication(params int[] numbers)
        {
            var result = 1;
            for (var i = 0; i < numbers.Length; i++) result *= numbers[i];
            return result;
        }

        public decimal Division(params int[] numbers)
        {
            var result = numbers[0];
            for (var i = 1; i < numbers.Length; i++) result /= numbers[i];

            return result;
        }
    }
}