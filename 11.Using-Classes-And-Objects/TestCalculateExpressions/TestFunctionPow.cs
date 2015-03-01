using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculateExpressions
{
    public partial class TestCalculateExpressionInRPN
    {
        

        /// <summary>
        ///A test for FunctionPow
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestFunctionPowInMiddle1()
        {
            List<object> list = new List<object>() { 2.0, 4.0, 5.0,"pow", "-", "ln" }; // TODO: Initialize to an appropriate value
            int index = 3; // TODO: Initialize to an appropriate value
            int indexExpected = 1; // TODO: Initialize to an appropriate value
            double expected = 1024D; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.FunctionPow(list, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }
}
}
