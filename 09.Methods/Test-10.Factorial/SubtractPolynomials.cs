using _11.Polynomials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_10.Factorial
{
    
    
    /// <summary>
    ///This is a test class for SubtractPolynomials and is intended
    ///to contain all SubtractPolynomials Unit Tests
    ///</summary>
    [TestClass()]
    public class SubtractPolynomials
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
        ///A test for SubtractPolynomials
        ///</summary>
        [TestMethod()]
        public void TestOrdinarySubtract()
        {
            int[] p1 = {3,5,0,9}; // TODO: Initialize to an appropriate value
            int[] p2 = {5,6}; // TODO: Initialize to an appropriate value
            int[] expected = {3,5,-5,3}; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = Polynomial.SubtractPolynomials(p1, p2);
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
