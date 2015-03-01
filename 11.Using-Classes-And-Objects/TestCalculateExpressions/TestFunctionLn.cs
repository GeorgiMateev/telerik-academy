using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculateExpressions
{
    public partial class TestCalculateExpressionInRPN
    {

        /// <summary>
        ///A test for FunctionLn
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestFunctionLnInMiddle()
        {
            List<object> list = new List<object>() { 2.0, 4.0, "sqrt", "-",1.0, "ln" }; // TODO: Initialize to an appropriate value
            int index = 5; // TODO: Initialize to an appropriate value
            int indexExpected = 4; // TODO: Initialize to an appropriate value
            double expected = 0; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.FunctionLn(list, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
