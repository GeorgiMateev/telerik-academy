using _18.ExtractEmails;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestExtractEmail
{
    
    
    /// <summary>
    ///This is a test class for TestExtractEmail and is intended
    ///to contain all TestExtractEmail Unit Tests
    ///</summary>
    [TestClass()]
    public class TestExtractEmail
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
        ///A test for ExtractEmails
        ///</summary>
        [TestMethod()]
        public void TestOneEmail()
        {
            string text = "asdafsa fadas a==asd a poshta@abv.bg xxaxax"; // TODO: Initialize to an appropriate value
            string[] expected = new string[]{"poshta@abv.bg"};; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = Extract_Emails.ExtractEmails(text);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (actual[i]!=expected[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);

        }

        /// <summary>
        ///A test for ExtractEmails
        ///</summary>
        [TestMethod()]
        public void TestManyEmails()
        {
            string text = @"asdafsa fadas a==asd a poshta@abv.bg xxaxax
assdadsv joro-maila@gmail.com   
email@abv.bg"; // TODO: Initialize to an appropriate value
            string[] expected = new string[] { "poshta@abv.bg", "joro-maila@gmail.com", "email@abv.bg" }; ; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = Extract_Emails.ExtractEmails(text);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (actual[i] != expected[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }

        
    }
}

