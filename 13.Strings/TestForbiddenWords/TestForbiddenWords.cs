using _9.ReplaceForbiddenWords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestForbiddenWords
{
    
    
    /// <summary>
    ///This is a test class for TestForbiddenWords and is intended
    ///to contain all TestForbiddenWords Unit Tests
    ///</summary>
    [TestClass()]
    public class TestForbiddenWords
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
        ///A test for ReplaceForbiddenWords
        ///</summary>
        [TestMethod()]
        public void NormalTest()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] words = new string[] { "PHP", "CLR", "Microsoft" }; // TODO: Initialize to an appropriate value
            char symbol = '*'; // TODO: Initialize to an appropriate value
            string expected = "********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.";
            string actual;
            actual = ForbiddenWords.ReplaceForbiddenWords(text, words, symbol);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReplaceForbiddenWords
        ///</summary>
        [TestMethod()]
        public void NormalTestManyWords()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] words = new string[] { "PHP", "CLR", "Microsoft","NET", "Framework", "4.0" }; // TODO: Initialize to an appropriate value
            char symbol = '*'; // TODO: Initialize to an appropriate value
            string expected = "********* announced its next generation *** compiler today. It is based on .*** ********* *** and is implemented as a dynamic language in ***.";
            string actual;
            actual = ForbiddenWords.ReplaceForbiddenWords(text, words, symbol);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReplaceForbiddenWords
        ///</summary>
        [TestMethod()]
        public void TestNoWords()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] words = new string[] { "microsoft" }; // TODO: Initialize to an appropriate value
            char symbol = '*'; // TODO: Initialize to an appropriate value
            string expected = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string actual;
            actual = ForbiddenWords.ReplaceForbiddenWords(text, words, symbol);
            Assert.AreEqual(expected, actual);
        }
    }
}
