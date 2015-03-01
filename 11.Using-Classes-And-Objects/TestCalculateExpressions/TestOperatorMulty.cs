using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculateExpressions
{
    public partial class TestCalculateExpressionInRPN
    {

        /// <summary>
        ///A test for OperatorMulty
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestOperatorMultiplyInMiddle()
        {
            List<object> list = new List<object>() { 2.0, 4.3, 5.0, "-", "ln" }; // TODO: Initialize to an appropriate value
            int index = 3; // TODO: Initialize to an appropriate value
            int indexExpected = 1; // TODO: Initialize to an appropriate value
            double expected = 21.5; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.OperatorMulty(list, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
