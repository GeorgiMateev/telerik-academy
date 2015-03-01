using _14.TranslateWord;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestTranslateWord
{
    
    
    /// <summary>
    ///This is a test class for TestTranslateWord and is intended
    ///to contain all TestTranslateWord Unit Tests
    ///</summary>
    [TestClass()]
    public class TestTranslateWord
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
        ///A test for TranslateWord
        ///</summary>
        [TestMethod()]
        public void NormalTest()
        {
            string dictionary = 
@".NET – platform for applications from Microsoft
CLR - managed execution environment for .NET
namespace – hierarchical organization of classes"; // TODO: Initialize to an appropriate value
            string word = "CLR"; // TODO: Initialize to an appropriate value
            string expected = "CLR - managed execution environment for .NET"; // TODO: Initialize to an appropriate value
            string actual;
            actual = Translate_Word.TranslateWord(dictionary, word);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TranslateWord
        ///</summary>
        [TestMethod()]
        public void NormalTest2()
        {
            string dictionary =
@".NET – platform for applications from Microsoft
CLR - managed execution environment for .NET
namespace – hierarchical organization of classes"; // TODO: Initialize to an appropriate value
            string word = ".NET"; // TODO: Initialize to an appropriate value
            string expected = ".NET – platform for applications from Microsoft"; // TODO: Initialize to an appropriate value
            string actual;
            actual = Translate_Word.TranslateWord(dictionary, word);
            Assert.AreEqual(expected, actual);
        }
    }
}
