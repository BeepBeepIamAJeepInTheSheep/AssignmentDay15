using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AssignmentDay15
{
    class Program
    {
        delegate double dlg(double a, double b);
        public class ArithmeticOperation
        {
            public double AddNumbers(double a, double b) => a + b;
            public double SubtractNumbers(double a, double b) => a - b;
            public double MultiplyNumbers(double a, double b) => a * b;
            public double DivideNumbers(double a, double b) => a / b;
            public double FindMaxNumber(double a, double b) => a >= b ? a : b;
        }



        private static void Main(string[] args)
        {
            WriteLine("Enter First number : ");
            double a = double.Parse(ReadLine());

            WriteLine("Enter Second number : ");
            double b = double.Parse(ReadLine());

            WriteLine("1. Addition \n2. Substract \n3. Multiply \n4. Divide \n5. Max Value");

            string ch = ReadLine();


            ArithmeticOperation ar = new ArithmeticOperation();
            dlg calculation;
            switch (ch)
            {
                case "1":
                    calculation = ar.AddNumbers;
                    break;




                case "2":
                    calculation = ar.SubtractNumbers;
                    break;




                case "3":
                    calculation = ar.MultiplyNumbers;
                    break;




                case "4":
                    calculation = ar.DivideNumbers;
                    break;




                case "5":
                    calculation = ar.FindMaxNumber;
                    break;




                default:
                    Console.WriteLine("Wrong input");
                    return;
            }




            double value = calculation(a, b);
            WriteLine($"Value : {value}");
            ReadLine();
        }
    }


}
