using _5.RemoveNegativeNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestRemoveNegative
{
/// <summary>
///This is a test class for TestNegativeRemoveLinq and is intended
///to contain all TestNegativeRemoveLinq Unit Tests
///</summary>
    [TestClass()]
    public class TestNegativeRemoveLinq
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
        ///A test for RemoveNegativeNumbersLINQ
        ///</summary>
        [TestMethod()]
        [DeploymentItem("5.RemoveNegativeNumbers.exe")]
        public void TestNormalCase()
        {
            RemoveNegative_Accessor target = new RemoveNegative_Accessor(); // TODO: Initialize to an appropriate value
            List<int> sequence = null; // TODO: Initialize to an appropriate value
            target.RemoveNegativeNumbersLINQ(sequence);
        }
    }
    
    
    /// <summary>
    ///This is a test class for TestNegativeRemoveIterative and is intended
    ///to contain all TestNegativeRemoveIterative Unit Tests
    ///</summary>
    [TestClass()]
    public class TestNegativeRemoveIterative
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
        ///A test for RemoveNegativeNumbers
        ///</summary>
        [TestMethod()]
        [DeploymentItem("5.RemoveNegativeNumbers.exe")]
        public void TestNormalCase()
        {
            RemoveNegative_Accessor target = new RemoveNegative_Accessor(); // TODO: Initialize to an appropriate value
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] { 3, 5, -4, -5, 4, 3, -5, -5, 3 - 3, -4, 0, 3, 0 });
            target.RemoveNegativeNumbers(sequence);

            bool isCorrect = true;
            foreach (var item in sequence)
            {
                if (item<0)
                {
                    isCorrect = false; break;
                }
            }

            Assert.IsTrue(isCorrect);
        }

        /// <summary>
        ///A test for RemoveNegativeNumbers
        ///</summary>
        [TestMethod()]
        [DeploymentItem("5.RemoveNegativeNumbers.exe")]
        public void TestOnlyNegative()
        {
            RemoveNegative_Accessor target = new RemoveNegative_Accessor(); // TODO: Initialize to an appropriate value
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] { -3, -5, -4, -5, -4, -3, -5, -5, -3, -3, -4, -3, });
            target.RemoveNegativeNumbers(sequence);

            bool isCorrect = false;
            if (sequence.Count==0)
            {
                isCorrect = true;
            }           

            Assert.IsTrue(isCorrect);
        }

        /// <summary>
        ///A test for RemoveNegativeNumbers
        ///</summary>
        [TestMethod()]
        [DeploymentItem("5.RemoveNegativeNumbers.exe")]
        public void TestOnlyPositive()
        {
            RemoveNegative_Accessor target = new RemoveNegative_Accessor(); // TODO: Initialize to an appropriate value
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] { 3, 5, 4, 5, 4, 3, 5, 0, 5, 3, 3, 4, 3, });
            target.RemoveNegativeNumbers(sequence);

            bool isCorrect = false;
            if (sequence.Count == 13)
            {
                isCorrect = true;
            }

            Assert.IsTrue(isCorrect);
        }
    }
}
