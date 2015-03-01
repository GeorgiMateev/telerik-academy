using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculateExpressions
{
    
    
    /// <summary>
    ///This is a test class for TestCalculateExpressionInRPN and is intended
    ///to contain all TestCalculateExpressionInRPN Unit Tests
    ///</summary>
    [TestClass()]
    public partial class TestCalculateExpressionInRPN
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
        ///A test for OperatorAdd
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestOperatorAddInMiddle()
        {
            List<object> list = new List<object>() {2.0, 4.3, 5.0, "+","ln" }; ; // TODO: Initialize to an appropriate value
            int index = 3; // TODO: Initialize to an appropriate value
            int indexExpected = 1; // TODO: Initialize to an appropriate value
            double expected = 9.3D; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.OperatorAdd(list, ref index);
            Assert.AreEqual(indexExpected, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
