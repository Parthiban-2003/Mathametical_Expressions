using Mathematical_MathExpression;
using System;

namespace Calculate_Expression
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Enter a MataheMatical Expression:");
            string strMathExpression = Console.ReadLine();

            double dResult = MathExpressions.ValidatedExpressions(strMathExpression);
            Console.WriteLine("MathExpressions Values: " + dResult);
        }
    }
}
