using _4.TriangleArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestTriangleArea
{
    
    
    /// <summary>
    ///This is a test class for TestTriangleArea and is intended
    ///to contain all TestTriangleArea Unit Tests
    ///</summary>
    [TestClass()]
    public class TestTriangleArea
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
        ///A test for FindArea
        ///</summary>
        [TestMethod()]
        public void TestTriangleAreaOrdinary()
        {
            double a = 3F; // TODO: Initialize to an appropriate value
            double b = 1.5F; // TODO: Initialize to an appropriate value
            Decimal angle = new Decimal(30); // TODO: Initialize to an appropriate value
            double expected = 1.125; // TODO: Initialize to an appropriate value
            double actual;
            actual = Triangle.FindArea(a, b, angle);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FindArea
        ///</summary>
        [TestMethod()]
        public void TestTriangleAreaOrdinary1()
        {
            double a = 0F; // TODO: Initialize to an appropriate value
            double b = 0F; // TODO: Initialize to an appropriate value
            double c = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = Triangle.FindArea(a, b, c);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindArea
        ///</summary>
        [TestMethod()]
        public void TestTriangleAreaOrdinary2()
        {
            double side = 0F; // TODO: Initialize to an appropriate value
            double altitude = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = Triangle.FindArea(side, altitude);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
