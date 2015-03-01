using _5.ReplaceUpCaseTags;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUpCaseReplacement
{
    
    
    /// <summary>
    ///This is a test class for TestUpCaseReplacement and is intended
    ///to contain all TestUpCaseReplacement Unit Tests
    ///</summary>
    [TestClass()]
    public class TestUpCaseReplacement
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
        ///A test for ReplaceUpperCaseTags with only words to replace
        ///</summary>
        [TestMethod()]
        public void TestOnlyWords()
        {
            string str = @"We are living in a <upcase>submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string expected = @"We are living in a SUBMARINE. We don't have ANYTHING else.";
            
            string actual;
            actual = UpCaseTags.ReplaceUpperCaseTags(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReplaceUpperCaseTags with intervals between the words
        ///</summary>
        [TestMethod()]
        public void TestWordsWithIntervals()
        {
            string str = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string expected = @"We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.";

            string actual;
            actual = UpCaseTags.ReplaceUpperCaseTags(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReplaceUpperCaseTags with intervals between the words and item in the end
        ///</summary>
        [TestMethod()]
        public void TestWordsWithIntervalsInTheEnd()
        {
            string str = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything else</upcase>";
            string expected = @"We are living in a YELLOW SUBMARINE. We don't have ANYTHING ELSE";

            string actual;
            actual = UpCaseTags.ReplaceUpperCaseTags(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReplaceUpperCaseTags with intervals between the words and item in the beginning
        ///</summary>
        [TestMethod()]
        public void TestWordsWithIntervalsInTheBeginning()
        {
            string str = @"<upcase>We are</upcase> living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything else</upcase>";
            string expected = @"WE ARE living in a YELLOW SUBMARINE. We don't have ANYTHING ELSE";

            string actual;
            actual = UpCaseTags.ReplaceUpperCaseTags(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReplaceUpperCaseTags no items to replace
        ///</summary>
        [TestMethod()]
        public void TestWordsNoReplace()
        {
            string str = @"We are living in a yellow submarine. We don't have anything else.";
            string expected = @"We are living in a yellow submarine. We don't have anything else.";

            string actual;
            actual = UpCaseTags.ReplaceUpperCaseTags(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
