using _4.CountSubstrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSubstringCount
{
    
    
    /// <summary>
    ///This is a test class for TestSubstringCount and is intended
    ///to contain all TestSubstringCount Unit Tests
    ///</summary>
    [TestClass()]
    public class TestSubstringCount
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
        ///A test for CountSubstrings in the normal case with some substrings.
        ///</summary>
        [TestMethod()]
        public void TestNormalCase()
        {
            string str =
                @"We are living in an yellow submarine. We don't have anything else.
            Inside the submarine is very tight.
            So we are drinking all the day. We will move out of it in 5 days."; // TODO: Initialize to an appropriate value
            string substr = "in"; // TODO: Initialize to an appropriate value
            int expected = 9; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CountSubstrings(str, substr);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CountSubstrings in the normal case with two substrings.
        ///</summary>
        [TestMethod()]
        public void TestTwoSubstrings()
        {
            string str =
                @"We are living in an yellow submarine. We don't have anything else.
            Inside the submarine is very tight.
            So we are drinking all the day. We will move out of it in 5 days."; // TODO: Initialize to an appropriate value
            string substr = "We are"; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CountSubstrings(str, substr);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CountSubstrings when the substring is equal to the string
        ///</summary>
        [TestMethod()]
        public void TestEquals()
        {
            string str =
                @"We are living in an yellow submarine. We don't have anything else.
            Inside the submarine is very tight.
            So we are drinking all the day. We will move out of it in 5 days."; // TODO: Initialize to an appropriate value
            string substr = @"We are living in an yellow submarine. We don't have anything else.
            Inside the submarine is very tight.
            So we are drinking all the day. We will move out of it in 5 days."; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CountSubstrings(str, substr);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CountSubstrings with one letter
        ///</summary>
        [TestMethod()]
        public void TestOneLetter()
        {
            string str =
                @"We are living in an yellow submarine. We don't have anything else.
            Inside the submarine is very tight.
            So we are drinking all the day. We will move out of it in 5 days."; // TODO: Initialize to an appropriate value
            string substr = "a"; // TODO: Initialize to an appropriate value
            int expected = 10; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CountSubstrings(str, substr);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CountSubstrings when there is no substring
        ///</summary>
        [TestMethod()]
        public void TestNoSubstrings()
        {
            string str =
                @"We are living in an yellow submarine. We don't have anything else.
            Inside the submarine is very tight.
            So we are drinking all the day. We will move out of it in 5 days."; // TODO: Initialize to an appropriate value
            string substr = "xx"; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CountSubstrings(str, substr);
            Assert.AreEqual(expected, actual);
        }
    }
}
