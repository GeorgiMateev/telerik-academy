using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculateExpressions
{
    public partial class TestCalculateExpressionInRPN
    {
        /// <summary>
        ///A test for FunctionSqrt
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestFunctionSqrtInMiddle()
        {
            List<object> list = new List<object>() { 2.0, 4.0, "sqrt", "-", "ln" }; // TODO: Initialize to an appropriate value
            int index = 2; // TODO: Initialize to an appropriate value
            int indexExpected = 1; // TODO: Initialize to an appropriate value
            double expected = 2; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.FunctionSqrt(list, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }
}
}
