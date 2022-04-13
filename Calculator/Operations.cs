using System.Collections.Generic;
namespace Calculator
{
    internal class Operations
    {

        public static double defaultValue = 0;
        public const string plusOperation = "+";
        public const string minusOperation = "-";
        public const string orOperation = "*";
        public const string equalOperation = "/";

        public static double Sum (List<int> numberList)
        {
            double sum = 0;
            foreach (var number in numberList)
            {
                sum += number;
            }
            return sum;
        }
        public static double Subtract(List<int> numberList)
        {
            double subtract = 0;
            byte index = 0;
            foreach (var number in numberList)
            {
                if(index == 0)
                {
                    subtract = number;
                    index++;
                    continue;
                }
                if(index > 0)
                {
                    subtract -= number;
                }

            }
            return subtract;
        }

        public static double Multiplication(List<int> numberList)
        {
            double multiplication = 1;
            foreach (var number in numberList)
            {
                multiplication *= number;
            }
            return multiplication;
        }

        public static double Division(List<int> numberList)
        {
            double division = 1;
            byte index = 0;
            foreach (var number in numberList)
            {
                if (index == 0)
                {
                    division = number;
                    index++;
                    continue;
                }
                if (index > 0)
                {
                    division /= number;
                }
            }
            return division;
        }
    }
}