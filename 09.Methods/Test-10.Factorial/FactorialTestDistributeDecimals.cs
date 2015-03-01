using _10.Factorials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Test_10.Factorial
{
    
    
    /// <summary>
    ///This is a test class for FactorialTestDistributeDecimals and is intended
    ///to contain all FactorialTestDistributeDecimals Unit Tests
    ///</summary>
    [TestClass()]
    public class FactorialTestDistributeDecimals
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
        ///A test for DistributeDecimals
        ///</summary>
        [TestMethod()]
        public void DistributeDecimalsTest()
        {
            List<sbyte> list = new List<sbyte> {35,14,21 }; // TODO: Initialize to an appropriate value
            List<sbyte> expected = new List<sbyte> {5,7,2,2 }; // TODO: Initialize to an appropriate value
            List<sbyte> actual;
            //actual = _10.Factorials.Factorial.DistributeDecimals(list);
           // Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
