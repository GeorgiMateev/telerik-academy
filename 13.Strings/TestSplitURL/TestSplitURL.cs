using _12.SplitURL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSplitURL
{
    
    
    /// <summary>
    ///This is a test class for TestSplitURL and is intended
    ///to contain all TestSplitURL Unit Tests
    ///</summary>
    [TestClass()]
    public class TestSplitURL
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
        ///A test for SplitURL
        ///</summary>
        [TestMethod()]
        public void NormalTest()
        {
            string url = "http://www.devbg.org/forum/index.php"; // TODO: Initialize to an appropriate value
            string[] expected = new string[] { "http","www.devbg.org","/forum/index.php"}; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = Program.SplitURL(url);
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
        ///A test for SplitURL
        ///</summary>
        [TestMethod()]
        public void TestWithOutResources()
        {
            string url = "http://www.devbg.org"; // TODO: Initialize to an appropriate value
            string[] expected = new string[] { "http", "www.devbg.org" }; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = Program.SplitURL(url);
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
        ///A test for SplitURL
        ///</summary>
        [TestMethod()]
        public void LongURLTest()
        {
            string url = "http://www.youtube.com/results?search_query=zombie&oq=zombie&aq=0&aqi=g10&aql=&gs_sm=e&gs_upl=17835l18863l0l20630l6l6l0l1l1l0l302l1281l2-4.1l5l0"; // TODO: Initialize to an appropriate value
            string[] expected = new string[] { "http", "www.youtube.com", "/results?search_query=zombie&oq=zombie&aq=0&aqi=g10&aql=&gs_sm=e&gs_upl=17835l18863l0l20630l6l6l0l1l1l0l302l1281l2-4.1l5l0" }; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = Program.SplitURL(url);
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
        ///A test for SplitURL
        ///</summary>
        [TestMethod()]
        public void InvalidURLTest()
        {
            string url = "asdasd"; // TODO: Initialize to an appropriate value
            string expected = "Invalid url!"; // TODO: Initialize to an appropriate value
            string actual = "";
            try
            {
                Program.SplitURL(url);
            }
            catch (FormatException e)
            {
                actual = e.Message;
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
