using System.Collections.Generic;
namespace Calculator
{
    internal class Operations
    {

        public static int Sum (List<int> numberList)
        {
            int sum = 0;
            foreach (var number in numberList)
            {
                sum += number;
            }
            return sum;
        }
        public static int Subtract(List<int> numberList)
        {
            int subtract = 0;
            int substractTmp;
            foreach (var number in numberList)
            {
                substractTmp = number;

            }
            return subtract;
        }

        public static int Multiplication(List<int> numberList)
        {
            int multiplication = 1;
            foreach (var number in numberList)
            {
                multiplication *= number;
            }
            return multiplication;
        }
    }
}