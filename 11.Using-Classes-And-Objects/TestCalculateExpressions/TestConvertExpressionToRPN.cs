using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculateExpressions
{
    public partial class TestConvertExpressionToRPN
    {

        /// <summary>
        ///A test for ConvertExpressionToRPN
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestConvertExpressionToRPN1()
        {
            string str = "ln(3+(8+10.14)/2)-pow(3.4*0.1,sqrt(4))"; // TODO: Initialize to an appropriate value
            object[] expected = 
                new object[] { 3.0, 8.0, 10.14, "+", 2.0, "/", "+", "ln", 3.4, 0.1, "*", 4.0, "sqrt", "pow", "-" }; // TODO: Initialize to an appropriate value
            object[] actual;
            actual = CalculateExpressions_Accessor.ConvertExpressionToRPN(str).ToArray();

            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i].ToString()!=actual[i].ToString())
                {
                    areEqual = false;
                    break;
                }
            }

            Assert.IsTrue(areEqual);
        }

        /// <summary>
        ///A test for ConvertExpressionToRPN when there are intervals in the string
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestConvertExpressionToRPNWithIntervals()
        {
            string str = "ln(3 + ( 8+10.14 ) /  2) - pow(3.4*0.1,sqrt(4))"; // TODO: Initialize to an appropriate value
            object[] expected =
                new object[] { 3.0, 8.0, 10.14, "+", 2.0, "/", "+", "ln", 3.4, 0.1, "*", 4.0, "sqrt", "pow", "-" }; // TODO: Initialize to an appropriate value
            object[] actual;
            actual = CalculateExpressions_Accessor.ConvertExpressionToRPN(str).ToArray();

            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i].ToString() != actual[i].ToString())
                {
                    areEqual = false;
                    break;
                }
            }

            Assert.IsTrue(areEqual);
        }
    }
}
