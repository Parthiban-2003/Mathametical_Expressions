using Operator_Expressions;
using System;
using System.Collections;
using System.Collections.Generic;
using ValidateOperators;

namespace Mathematical_MathExpression
{
    public class MathExpressions
    {
         public static double ValidatedExpressions(string strMathExpression)
         {
            Stack<double> dValues = new Stack<double>();
            Stack<char> charOperators = new Stack<char>();

            int nI = 0;
            while (nI < strMathExpression.Length)
            {
                char charCalculated = strMathExpression[nI];
                if (char.IsDigit(charCalculated) || charCalculated == '.')
                {
                    string StrStringExpressions = "";
                    while (nI < strMathExpression.Length && (char.IsDigit(strMathExpression[nI]) || strMathExpression[nI] == '.'))
                    {
                        StrStringExpressions += strMathExpression[nI];
                        nI++;
                    }
                    dValues.Push(double.Parse(StrStringExpressions));
                }
                else if (charCalculated == '(')
                {
                    charOperators.Push(charCalculated);
                    nI++;
                }
                else if (charCalculated == ')')
                {
                    while (charOperators.Peek() != '(')
                    {
                        dValues.Push(ValidateOperatorCases.ValidateOperator(charOperators.Pop(), dValues.Pop(), dValues.Pop()));
                    }
                    charOperators.Pop();
                    nI++;
                }
                else if (charCalculated == '+' || charCalculated == '-' || charCalculated == '*' || charCalculated == '/' || charCalculated == '^')
                {
                    while (charOperators.Count > 0 && OperatorChecks.CheckOperators(charOperators.Peek()) >= OperatorChecks.CheckOperators(charCalculated))
                    {
                        dValues.Push(ValidateOperatorCases.ValidateOperator(charOperators.Pop(), dValues.Pop(), dValues.Pop()));
                    }
                    charOperators.Push(charCalculated);
                    nI++;
                }
                else
                {
                    Console.WriteLine("InValid Math Expressions..!!");
                }
            }

            while (charOperators.Count > 0)
            {
                dValues.Push(ValidateOperatorCases.ValidateOperator(charOperators.Pop(), dValues.Pop(), dValues.Pop()));
            }
            return dValues.Pop();
        }
    }
}
