using Mathematical_MathExpression;
using Calculate_Expression;
using System.Linq.Expressions;
using System.Globalization;

namespace Mathamatical_Expression_Test
{
    [TestClass]
    public class MathExpression_Test
    {
        [TestMethod]
        public void Calculated_SingleExpression_Add()
        {
            //Arrange
            string strExpressions = "10 + 5";

            //Act
            double bResult = MathExpressions.ValidatedExpressions(strExpressions);

            //Assert
            Assert.AreEqual(15, bResult);
        }

        [TestMethod]
        public void Calculated_SingleExpression_Sub()
        {
            //Arrange
            string strExpression = "10 - 5";
            
            //Act
            double dResult = MathExpressions.ValidatedExpressions(strExpression);

            //Assert
            Assert.AreEqual(5, dResult);
        }

        public void Calculated_SingleExpression_Mul()
        {
            //Arrange
            string strExpression = "10 * 5";

            //Act
            double dResult = MathExpressions.ValidatedExpressions(strExpression);

            //Assert
            Assert.AreEqual(50, dResult);
        }

        public void Calculated_SingleExpression_Div()
        {
            //Arrange
            string strExpression = "10 / 5";

            //Act
            double dResult = MathExpressions.ValidatedExpressions(strExpression);

            //Assert
            Assert.AreEqual(2, dResult);
        }

        public void Calculated_SingleExpression_Not_Div()
        {
            //Arrange
            string strExpression = "0 / 5";

            //Act
            double dResult = MathExpressions.ValidatedExpressions(strExpression);

            //Assert
            Assert.IsTrue(double.IsNaN(dResult));
        }

        public void Calculated_SingleExpression_Root()
        {
            //Arrange
            string strExpression = "10 ^ 5";

            //Act
            double dResult = MathExpressions.ValidatedExpressions(strExpression);

            //Assert
            Assert.AreEqual(100000, dResult);
        }

        public void Calculated_SingleExpression_decimalValues()
        {
            //Arrange
            string strExpression = "3.1+(6*2)+1+2";

            //Act
            double dResult = MathExpressions.ValidatedExpressions(strExpression);

            //Assert
            Assert.AreEqual(18.1, dResult);
        }

        [TestMethod]
        public void Calculated_MultipleEXpression_True()
        {
            //Arrange
            string strExpression = "3 + (2 * 4) - 5 / (1 + 1)"
;
            //Act
            double dResult = MathExpressions.ValidatedExpressions(strExpression);

            //Assert
            Assert.AreEqual(8.5, dResult);
        }

        [TestMethod]
        public void Calculated_MultipleExpression_False()
        {
            //Assert
            String strExpression = "3 + (2 * 4) - 5 / (1 + 1)";

            //Act
            double dResult = MathExpressions.ValidatedExpressions(strExpression);

            //Assert
            Assert.AreNotEqual(9.0, dResult);
        }
    }
}
