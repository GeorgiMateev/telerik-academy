using _3.ChechForCorrectBrackets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBracketsInExpression
{
    
    
    /// <summary>
    ///This is a test class for TestBracketsInExpression and is intended
    ///to contain all TestBracketsInExpression Unit Tests
    ///</summary>
    [TestClass()]
    public class TestBracketsInExpression
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
        ///A test for CheckCorrectBrackets with one more open
        ///</summary>
        [TestMethod()]
        [DeploymentItem("3.ChechForCorrectBrackets.exe")]
        public void TestBracketsOneOpenLeft()
        {
            string expression = "(aa(s))("; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CheckBrackets_Accessor.CheckCorrectBrackets(expression);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CheckCorrectBrackets with one more closing
        ///</summary>
        [TestMethod()]
        [DeploymentItem("3.ChechForCorrectBrackets.exe")]
        public void TestBracketsOneClosingLeft()
        {
            string expression = "(aa(s))(f)2+4)"; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CheckBrackets_Accessor.CheckCorrectBrackets(expression);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CheckCorrectBrackets with misplaced
        ///</summary>
        [TestMethod()]
        [DeploymentItem("3.ChechForCorrectBrackets.exe")]
        public void TestBracketsMisplacedt()
        {
            string expression = "aa(s))((f)(2+4)"; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CheckBrackets_Accessor.CheckCorrectBrackets(expression);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CheckCorrectBrackets when they are correct
        ///</summary>
        [TestMethod()]
        [DeploymentItem("3.ChechForCorrectBrackets.exe")]
        public void TestBracketsCorrect()
        {
            string expression = "(())(()())"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CheckBrackets_Accessor.CheckCorrectBrackets(expression);
            Assert.AreEqual(expected, actual);
        }
    }
}
