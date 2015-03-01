using _11.Polynomials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_11_Polynomials
{
    
    
    /// <summary>
    ///This is a test class for PolynomialTestAddPolynomial and is intended
    ///to contain all PolynomialTestAddPolynomial Unit Tests
    ///</summary>
    [TestClass()]
    public class PolynomialTestAddPolynomial
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
        ///A test for AddPolynomials in ordinary case
        ///</summary>
        [TestMethod()]
        public void AddPolynomialsOrdinaryTest()
        {
            int[] p1 = new int[]{3,5,2,1,6,73,1,}; // TODO: Initialize to an appropriate value
            int[] p2 = new int[]{1,0,1}; // TODO: Initialize to an appropriate value
            int[] expected = new int[]{3,5,2,1,7,73,2}; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = Polynomial.AddPolynomials(p1, p2);
            bool isEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i]!=actual[i])
                {
                    isEqual = false; break;
                }
            }
            Assert.IsTrue(isEqual);
        }
        /// <summary>
        ///A test for AddPolynomials in ordinary case
        ///</summary>
        [TestMethod()]
        public void AddPolynomialsChangedParamsOrdinaryTest()
        {
            int[] p1 = new int[] { 1,0,1 }; // TODO: Initialize to an appropriate value
            int[] p2 = new int[] { 3, 5, 2, 1, 6, 73, 1, }; // TODO: Initialize to an appropriate value
            int[] expected = new int[] { 3, 5, 2, 1, 7, 73, 2 }; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = Polynomial.AddPolynomials(p1, p2);
            bool isEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    isEqual = false; break;
                }
            }
            Assert.IsTrue(isEqual);
        }

        /// <summary>
        ///A test for AddPolynomials when the parameters are with the same lenght
        ///</summary>
        [TestMethod()]
        public void AddPolynomialsSameSizeTest()
        {
            int[] p1 = new int[] { 3, 5, 2, 1,2,5,2,3,7,26,27,3 }; // TODO: Initialize to an appropriate value
            int[] p2 = new int[] { 1, 0, 1, 5,3,6,3,2,6,22,33,4 }; // TODO: Initialize to an appropriate value
            int[] expected = new int[] { 4,5,3,6,5,11,5,5,13,48,60,7 }; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = Polynomial.AddPolynomials(p1, p2);
            bool isEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    isEqual = false; break;
                }
            }
            Assert.IsTrue(isEqual);
        }

        /// <summary>
        ///A test for AddPolynomials when one parameter is zero
        ///</summary>
        [TestMethod()]
        public void AddPolynomialsOneZeroTest()
        {
            int[] p1 = new int[] { 3, 5, 2, 1, 2, 5, 2, 3, 7, 26, 27, 3 }; // TODO: Initialize to an appropriate value
            int[] p2 = new int[] {0 }; // TODO: Initialize to an appropriate value
            int[] expected = new int[] { 3, 5, 2, 1, 2, 5, 2, 3, 7, 26, 27, 3 }; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = Polynomial.AddPolynomials(p1, p2);
            bool isEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    isEqual = false; break;
                }
            }
            Assert.IsTrue(isEqual);
        }

        /// <summary>
        ///A test for AddPolynomials when two parameters are zero
        ///</summary>
        [TestMethod()]
        public void AddPolynomialsTwoZerosTest()
        {
            int[] p1 = new int[] { 0 }; // TODO: Initialize to an appropriate value
            int[] p2 = new int[] { 0 }; // TODO: Initialize to an appropriate value
            int[] expected = new int[] { 0 }; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = Polynomial.AddPolynomials(p1, p2);
            bool isEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    isEqual = false; break;
                }
            }
            Assert.IsTrue(isEqual);
        }
    }
}
