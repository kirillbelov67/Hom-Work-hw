using System;

namespace MyLibrary
{
   
    public class BasicMath
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Деление на ноль невозможно.");
            return a / b;
        }
    }
}