using _6.SumTheNumbersInString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSumNumbersInString
{
    
    
    /// <summary>
    ///This is a test class for TestSumNumbersInString and is intended
    ///to contain all TestSumNumbersInString Unit Tests
    ///</summary>
    [TestClass()]
    public class TestSumNumbersInString
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
        ///A test for SumNumbersInString
        ///</summary>
        [TestMethod()]
        public void TestSumInNumbersOrdinary()
        {
            string str = "45 23 1 0 34 1345"; // TODO: Initialize to an appropriate value
            int expected = 1448; // TODO: Initialize to an appropriate value
            int actual;
            actual = SumTheNumbersInString.SumNumbersInString(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SumNumbersInString
        ///</summary>
        [TestMethod()]
        public void TestSumInNumbersEmptyString()
        {
            string str = ""; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = SumTheNumbersInString.SumNumbersInString(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SumNumbersInString
        ///</summary>
        [TestMethod()]
        public void TestSumInNumbersOnlyOneNumber()
        {
            string str = "12312"; // TODO: Initialize to an appropriate value
            int expected = 12312; // TODO: Initialize to an appropriate value
            int actual;
            actual = SumTheNumbersInString.SumNumbersInString(str);
            Assert.AreEqual(expected, actual);
        }

        
    }
}
