using _5.Workdays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestTriangleArea
{
    
    
    /// <summary>
    ///This is a test class for TestWorkdays and is intended
    ///to contain all TestWorkdays Unit Tests
    ///</summary>
    [TestClass()]
    public class TestWorkdays
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
        ///A test for CountWorkdays
        ///</summary>
        [TestMethod()]
        public void TestWorkdaysOrdinary()
        {
            DateTime date = new DateTime(2012,3,31); // TODO: Initialize to an appropriate value
            DateTime[] holydays = new DateTime[]{new DateTime(2012,1,25), new DateTime(2012,2,10),new DateTime(2012,3,13)}; // TODO: Initialize to an appropriate value
            int expected = 47; // TODO: Initialize to an appropriate value
            int actual;
            actual = Workdays.CountWorkdays(date, holydays);
            Assert.AreEqual(expected, actual);
        }
    }
}
