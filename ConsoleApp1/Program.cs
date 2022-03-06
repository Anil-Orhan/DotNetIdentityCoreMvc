using System;
using System.Data;
using BusinessLayer.Concrete;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorManager calculatorManger = new CalculatorManager();

            Console.WriteLine(calculatorManger.Calculation("38+85+4007/45*8901"));

            Console.WriteLine(Evaluate("3+7/2+10"));
            Console.ReadKey();


        }

       

        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
