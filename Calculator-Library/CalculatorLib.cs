using System;

namespace Calculator_Library
{
    public class CalculatorLib
    {

        // Method to add two numbers
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        //Method to subtract two numbers
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        //Method to return multiplication of two numbers
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        //Method to perform deivision of two numbers
        public decimal Division(decimal num1, decimal num2)
        {
            try
            {
                return decimal.Divide(num1, num2);
            }
            catch (DivideByZeroException ex)
            {
                throw;
            }
        }
    }
}
