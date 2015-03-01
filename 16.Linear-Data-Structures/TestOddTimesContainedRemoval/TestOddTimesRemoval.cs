using _6.RemoveOddTimesContained;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestOddTimesContainedRemoval
{
    
    
    /// <summary>
    ///This is a test class for TestOddTimesRemoval and is intended
    ///to contain all TestOddTimesRemoval Unit Tests
    ///</summary>
    [TestClass()]
    public class TestOddTimesRemoval
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
        ///A test for RemoveOddTimesContained
        ///</summary>
        [TestMethod()]
        public void TestNormalCase()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 });
            List<int> expected = new List<int>(); // TODO: Initialize to an appropriate value
            expected.AddRange(new int[] { 5,3,3,5});
            List<int> actual;
            actual = Odds.RemoveOddTimesContained(sequence);
            bool isCorrect = true;
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i]!=actual[i])
                {
                    isCorrect = false; break;
                }
            }

            Assert.IsTrue(isCorrect);
        }

        /// <summary>
        ///A test for RemoveOddTimesContained
        ///</summary>
        [TestMethod()]
        public void TestOnlyOne()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] { 4});
            List<int> expected = new List<int>(); // TODO: Initialize to an appropriate value
            expected.AddRange(new int[] {  });
            List<int> actual;
            actual = Odds.RemoveOddTimesContained(sequence);
            bool isCorrect = true;
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i] != actual[i])
                {
                    isCorrect = false; break;
                }
            }

            Assert.IsTrue(isCorrect);
        }

        /// <summary>
        ///A test for RemoveOddTimesContained
        ///</summary>
        [TestMethod()]
        public void TestEmpty()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] {  });
            List<int> expected = new List<int>(); // TODO: Initialize to an appropriate value
            expected.AddRange(new int[] { });
            List<int> actual;
            actual = Odds.RemoveOddTimesContained(sequence);
            bool isCorrect = true;
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i] != actual[i])
                {
                    isCorrect = false; break;
                }
            }

            Assert.IsTrue(isCorrect);
        }

        /// <summary>
        ///A test for RemoveOddTimesContained
        ///</summary>
        [TestMethod()]
        public void TestOnlyEven()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] {3,3,3,6,6,3,3,3 });
            List<int> expected = new List<int>(); // TODO: Initialize to an appropriate value
            expected.AddRange(new int[] {3,3,3,6,6,3,3,3, });
            List<int> actual;
            actual = Odds.RemoveOddTimesContained(sequence);
            bool isCorrect = true;
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i] != actual[i])
                {
                    isCorrect = false; break;
                }
            }

            Assert.IsTrue(isCorrect);
        }

        /// <summary>
        ///A test for RemoveOddTimesContained
        ///</summary>
        [TestMethod()]
        public void TestOnlyOdd()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            sequence.AddRange(new int[] { 3,3, 3, 3, 6,6, 6, 3, 3, 3 });
            List<int> expected = new List<int>(); // TODO: Initialize to an appropriate value
            expected.AddRange(new int[] {  });
            List<int> actual;
            actual = Odds.RemoveOddTimesContained(sequence);
            bool isCorrect = true;
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i] != actual[i])
                {
                    isCorrect = false; break;
                }
            }

            Assert.IsTrue(isCorrect);
        }

        /// <summary>
        ///A test for RemoveOddTimesContained
        ///</summary>
        [TestMethod()]
        public void LoadTest()
        {
            List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
            for (int i = 0; i < 1000; i++)
            {
                sequence.Add(i);
            }
            List<int> expected = new List<int>(); // TODO: Initialize to an appropriate value
            expected.AddRange(new int[] { });
            List<int> actual;
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            actual = Odds.RemoveOddTimesContained(sequence);
            timer.Stop();
            bool isCorrect = false;
            if (actual.Count==0 && timer.ElapsedMilliseconds<2000)
            {
                isCorrect = true;
            }

            Assert.IsTrue(isCorrect);
        }
    }
}
