using _20.ExtractPalindroms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestExtractPalindroms
{
    
    
    /// <summary>
    ///This is a test class for TestExtractPalindroms and is intended
    ///to contain all TestExtractPalindroms Unit Tests
    ///</summary>
    [TestClass()]
    public class TestExtractPalindroms
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
        ///A test for ExtractPalindroms
        ///</summary>
        [TestMethod()]
        public void NormalTest()
        {
            string text = "Test string for palindroms like thissiht and 123321 "; // TODO: Initialize to an appropriate value
            string[] expected = new string[]{"thissiht","123321"}; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = Extract_Palindroms.ExtractPalindroms(text);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i]!=actual[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }
    }
}
