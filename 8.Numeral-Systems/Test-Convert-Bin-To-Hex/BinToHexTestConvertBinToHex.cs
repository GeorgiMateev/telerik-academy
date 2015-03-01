using _6.Convert_Bin_To_Hex;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Convert_Bin_To_Hex
{
    
    
    /// <summary>
    ///This is a test class for BinToHexTestConvertBinToHex and is intended
    ///to contain all BinToHexTestConvertBinToHex Unit Tests
    ///</summary>
    [TestClass()]
    public class BinToHexTestConvertBinToHex
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
        ///Ordinary number
        ///</summary>
        [TestMethod()]
        [DeploymentItem("6.Convert-Bin-To-Hex.exe")]
        public void ConvertBinToHexOrdinaryTest()
        {
            string number = "11101"; // TODO: Initialize to an appropriate value
            string expected = "1D"; // TODO: Initialize to an appropriate value
            string actual;
            actual = BinToHex_Accessor.ConvertBinToHex(number);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Empty Number
        ///</summary>
        [TestMethod()]
        public void ConvertBinToHexEmptyString()
        {
            string number = ""; // TODO: Initialize to an appropriate value
            string expected = ""; // TODO: Initialize to an appropriate value
            string actual;
            actual = BinToHex.ConvertBinToHex(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
