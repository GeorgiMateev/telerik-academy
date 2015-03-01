using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculateExpressions
{
    public partial class TestCalculateExpressionInRPN
    {

        /// <summary>
        ///A test for OperatorSubtract
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestOperatorSubtractInMiddle()
        {
            List<object> list = new List<object>() { 2.0, 4.3, 5.0, "-", "ln" }; // TODO: Initialize to an appropriate value
            int index = 3; // TODO: Initialize to an appropriate value
            int indexExpected = 1; // TODO: Initialize to an appropriate value
            double expected = -0.7d; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.OperatorSubtract(list, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, Math.Round(actual,1));
        }
    }
}
