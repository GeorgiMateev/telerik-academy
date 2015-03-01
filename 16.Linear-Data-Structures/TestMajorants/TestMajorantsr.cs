using _8.Majorants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestMajorants
{
    
    
    /// <summary>
    ///This is a test class for TestMajorants and is intended
    ///to contain all TestMajorants Unit Tests
    ///</summary>
    [TestClass()]
    public class TestMajorants
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
        ///A test for FindMajorant
        ///</summary>
        [TestMethod()]
        [DeploymentItem("8.Majorants.exe")]
        public void TestNormalCaseWith()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 });
            int majorant = 0; // TODO: Initialize to an appropriate value
            int majorantExpected = 3; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Majorants_Accessor.FindMajorant(sequence, out majorant);
            Assert.AreEqual(majorantExpected, majorant);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FindMajorant
        ///</summary>
        [TestMethod()]
        [DeploymentItem("8.Majorants.exe")]
        public void TestNormalCaseWithout()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] { 2, 2, 3, 2, 3, 4, 3, 3 });
            int majorant = 0; // TODO: Initialize to an appropriate value
            int majorantExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Majorants_Accessor.FindMajorant(sequence, out majorant);
            Assert.AreEqual(majorantExpected, majorant);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FindMajorant
        ///</summary>
        [TestMethod()]
        [DeploymentItem("8.Majorants.exe")]
        public void LoadTestWithout()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            for (int i = 0; i < 67000000; i++)
            {
                sequence.Add(i);
            }
            int majorant = 0; // TODO: Initialize to an appropriate value
            int majorantExpected = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            actual = Majorants_Accessor.FindMajorant(sequence, out majorant);
            timer.Stop();
            Assert.AreEqual(majorantExpected, majorant);
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(timer.Elapsed.Milliseconds < 900);
        }

        /// <summary>
        ///A test for FindMajorant
        ///</summary>
        [TestMethod()]
        [DeploymentItem("8.Majorants.exe")]
        public void LoadTestWith()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            for (int i = 0; i < 67000000; i++)
            {
                sequence.Add(int.MaxValue);
            }
            int majorant = 0; // TODO: Initialize to an appropriate value
            int majorantExpected = int.MaxValue; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            actual = Majorants_Accessor.FindMajorant(sequence, out majorant);
            timer.Stop();
            Assert.AreEqual(majorantExpected, majorant);
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(timer.Elapsed.Milliseconds < 600);
        }
    }
}
