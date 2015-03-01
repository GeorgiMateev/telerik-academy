using _10.Factorials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_10.Factorial
{
    
    
    /// <summary>
    ///This is a test class for FactorialTestMultiplication and is intended
    ///to contain all FactorialTestMultiplication Unit Tests
    ///</summary>
    [TestClass()]
    public class FactorialTestMultiplication
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
        ///A test for MultiplyNumbersAsArrays
        ///</summary>
        [TestMethod()]
        [DeploymentItem("10.Factorial.exe")]
        public void MultiplyNumbersAsArraysOrdinaryTest()
        {
            sbyte[] number1 = new sbyte[] {5,2,3}; // TODO: Initialize to an appropriate value
            sbyte[] number2 = new sbyte[] {7,5,1}; // TODO: Initialize to an appropriate value
            sbyte[] expected = new sbyte[] {5,2,0,1,5}; // TODO: Initialize to an appropriate value
            sbyte[] actual;
            actual = Factorial_Accessor.MultiplyNumbersAsArrays(number1, number2);
            bool isEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (actual[i]!=expected[i])
                {
                    isEqual = false; break;
                }
            }
            Assert.IsTrue(isEqual);
        }
    }
}
