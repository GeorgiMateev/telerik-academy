using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculateExpressions
{
    /// <summary>
    ///This is a test class for TestConvertExpressionToRPN and is intended
    ///to contain all TestConvertExpressionToRPN Unit Tests
    ///</summary>

    public partial class TestConvertExpressionToRPN
    {
        /// <summary>
        ///A test for GetFunction int the middle of the string
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestGetFunctionInTheMiddle()
        {
            string str = "12+8*pow(134.23,2)-23"; // TODO: Initialize to an appropriate value
            int index = 5; // TODO: Initialize to an appropriate value
            int indexExpected = 8; // TODO: Initialize to an appropriate value
            string expected = "pow"; // TODO: Initialize to an appropriate value
            string actual;
            actual = CalculateExpressions_Accessor.GetFunction(str, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetFunction in the end of the string
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestGetFunctionInTheEnd()
        {
            string str = "12+8*pow(134.23,2)-23-sqrt(34)"; // TODO: Initialize to an appropriate value
            int index = 22; // TODO: Initialize to an appropriate value
            int indexExpected = 26; // TODO: Initialize to an appropriate value
            string expected = "sqrt"; // TODO: Initialize to an appropriate value
            string actual;
            actual = CalculateExpressions_Accessor.GetFunction(str, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetFunction in the beginning
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestGetFunctionInTheBeginning()
        {
            string str = "ln(12+8*pow(134.23,2)-23-sqrt(34))"; // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            int indexExpected = 2; // TODO: Initialize to an appropriate value
            string expected = "ln"; // TODO: Initialize to an appropriate value
            string actual;
            actual = CalculateExpressions_Accessor.GetFunction(str, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
