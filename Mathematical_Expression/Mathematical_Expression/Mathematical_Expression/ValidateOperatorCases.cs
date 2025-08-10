using System;
using System.Collections.Generic;
using Mathematical_MathExpression;

namespace ValidateOperators
{
    public class ValidateOperatorCases
    {
        public static double ValidateOperator(char charOperator, double dB, double dA)
        {
            switch (charOperator)
            {
                case '+':
                    return dA + dB;
                case '-':
                    return dA - dB;
                case '*':
                    return dA * dB;
                case '/':
                    if (dB == 0)
                    {
                        Console.WriteLine("Invaild Expressions");
                        return double.NaN;
                    }
                    else
                    {
                        return dA / dB;
                    }
                case '^':
                    return Math.Pow(dA, dB);
                default:
                    Console.WriteLine("Invaild Expressions");
                    return double.NaN;
            }
        }
    }
}
