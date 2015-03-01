using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculateExpressions
{
    
    
    /// <summary>
    ///This is a test class for TestConvertExpressionToRPN and is intended
    ///to contain all TestConvertExpressionToRPN Unit Tests
    ///</summary>
    [TestClass()]
    public partial class TestConvertExpressionToRPN
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test when the is floating point number in the middle.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("7.CalculateExpressions.exe")]
        public void TestGetNumberFromStringDoubleNumberInMiddle()
        {
            string str = "12+8*pow(134.23,2)-23"; // TODO: Initialize to an appropriate value
            int index = 9; // TODO: Initialize to an appropriate value
            int indexExpected = 15; // TODO: Initialize to an appropriate value
            double expected = 134.23d; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.GetNumber(str, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test when the is floating point number in the end.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("7.CalculateExpressions.exe")]
        public void TestGetNumberFromStringDoubleNumberInTheEnd()
        {
            string str = "pow(134.23,2)-23.9"; // TODO: Initialize to an appropriate value
            int index = 14; // TODO: Initialize to an appropriate value
            int indexExpected = 18; // TODO: Initialize to an appropriate value
            double expected = 23.9d; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.GetNumber(str, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test when there is integer number in the end.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("7.CalculateExpressions.exe")]
        public void TestGetNumberFromStringInteger()
        {
            string str = "pow(134.23,2)-23.9"; // TODO: Initialize to an appropriate value
            int index = 11; // TODO: Initialize to an appropriate value
            int indexExpected = 12; // TODO: Initialize to an appropriate value
            double expected = 2; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.GetNumber(str, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
