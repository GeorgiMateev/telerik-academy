using _19.ExtractDates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestExtractDates
{
    
    
    /// <summary>
    ///This is a test class for TestExtractDates and is intended
    ///to contain all TestExtractDates Unit Tests
    ///</summary>
    [TestClass()]
    public class TestExtractDates
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
        ///A test for ExtractDates
        ///</summary>
        [TestMethod()]
        public void NormalTest()
        {
            string text = "asadad 14.12.2010. Test this date 34.02.2010 and 23.09.1000"; // TODO: Initialize to an appropriate value
            DateTime[] expected = new DateTime[]{new DateTime(2010,12,14), new DateTime(1000,09,23)}; // TODO: Initialize to an appropriate value
            DateTime[] actual;
            actual = Extract_Dates.ExtractDates(text);

            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (!expected[i].Equals(actual[i]))
                {
                    areEqual = false; break;
                }
            }

            Assert.IsTrue(areEqual);
        }
    }
}
