using _7.StringEncoding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestStringEncoding
{
    
    
    /// <summary>
    ///This is a test class for TestStringEncoding and is intended
    ///to contain all TestStringEncoding Unit Tests
    ///</summary>
    [TestClass()]
    public class TestStringEncoding
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
        ///A test for EncodeString
        ///</summary>
        [TestMethod()]
        public void NormalTest()
        {
            string str = "programirane"; // TODO: Initialize to an appropriate value
            string key = "xaxo"; // TODO: Initialize to an appropriate value
            string expected = "programirane"; // TODO: Initialize to an appropriate value
            string actual;
            string encoded = StringEncoding.EncodeString(str, key);
            actual = StringEncoding.EncodeString(encoded, key);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EncodeString
        ///</summary>
        [TestMethod()]
        public void TestLongerKey()
        {
            string str = "programirane"; // TODO: Initialize to an appropriate value
            string key = "xaxoabcdeefghw"; // TODO: Initialize to an appropriate value
            string expected = "programirane"; // TODO: Initialize to an appropriate value
            string actual;
            string encoded = StringEncoding.EncodeString(str, key);
            actual = StringEncoding.EncodeString(encoded, key);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EncodeString
        ///</summary>
        [TestMethod()]
        public void TestOneCharKey()
        {
            string str = "programirane"; // TODO: Initialize to an appropriate value
            string key = "f"; // TODO: Initialize to an appropriate value
            string expected = "programirane"; // TODO: Initialize to an appropriate value
            string actual;
            string encoded = StringEncoding.EncodeString(str, key);
            actual = StringEncoding.EncodeString(encoded, key);
            Assert.AreEqual(expected, actual);
        }

       
    }
}
