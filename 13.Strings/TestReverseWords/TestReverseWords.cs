using _13.ReverseWordsInSentence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestReverseWords
{
    
    
    /// <summary>
    ///This is a test class for TestReverseWords and is intended
    ///to contain all TestReverseWords Unit Tests
    ///</summary>
    [TestClass()]
    public class TestReverseWords
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
        ///A test for ReverseWords
        ///</summary>
        [TestMethod()]
        public void NormalTest()
        {
            string str = "C# is not C++, not PHP and not Delphi!"; // TODO: Initialize to an appropriate value
            string expected = "Delphi not and PHP not, C++ not is C#!"; // TODO: Initialize to an appropriate value
            string actual;
            actual = ReverseWordsInSentence.ReverseWords(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReverseWords
        ///</summary>
        [TestMethod()]
        public void TestWithPunctuations()
        {
            string str = "Cars: bmw, mercedes, porshe."; // TODO: Initialize to an appropriate value
            string expected = "porshe, mercedes, bmw: Cars."; // TODO: Initialize to an appropriate value
            string actual;
            actual = ReverseWordsInSentence.ReverseWords(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
