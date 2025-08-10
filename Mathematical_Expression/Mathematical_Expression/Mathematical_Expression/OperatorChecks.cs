using System;
using System.Collections.Generic;
using Mathematical_MathExpression;

namespace Operator_Expressions
{
    public class OperatorChecks
    {
        public static int CheckOperators(char charOperater)
        {
            if(charOperater == '+' || charOperater == '-')
            {
                return 1;
            }
            if(charOperater == '*' || charOperater == '/' || charOperater == '^')
            {
                return 2;
            }
            return 0;
        }
    }
}
