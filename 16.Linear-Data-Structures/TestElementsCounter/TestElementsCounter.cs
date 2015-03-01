using _7.CountElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestElementsCounter
{
    
    
    /// <summary>
    ///This is a test class for TestElementsCounter and is intended
    ///to contain all TestElementsCounter Unit Tests
    ///</summary>
    [TestClass()]
    public class TestElementsCounter
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
        ///A test for CountElements
        ///</summary>
        //[TestMethod()]
        //[DeploymentItem("7.CountElements.exe")]
        //public void TestNormalCase()
        //{
        //    List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
        //    sequence.AddRange(new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 });
        //    Dictionary<int, int> expected = new Dictionary<int,int>(); // TODO: Initialize to an appropriate value
        //    expected.Add(2, 2);
        //    expected.Add(3, 4);
        //    expected.Add(4, 3);
        //    Dictionary<int, int> actual;
        //    //actual = Count_Elements_Accessor.CountElements(sequence);
        //    bool areEqual = true;
        //    foreach (var item in expected)
        //    {
        //        if (actual[item.Key]!=item.Value)
        //        {
        //            areEqual = false; break;
        //        }
        //    }
        //    Assert.IsTrue(areEqual);
        //}

        ///// <summary>
        /////A test for CountElements
        /////</summary>
        //[TestMethod()]
        //[DeploymentItem("7.CountElements.exe")]
        //public void LoadTest()
        //{
        //    List<int> sequence = new List<int>(); // TODO: Initialize to an appropriate value
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        sequence.Add(1);
        //    }

        //    Dictionary<int, int> expected = new Dictionary<int, int>(); // TODO: Initialize to an appropriate value
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        sequence.Add(1);
        //    }

        //    Dictionary<int, int> actual;

        //    System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        //    timer.Start();
        //    //actual = Count_Elements_Accessor.CountElements(sequence);
        //    timer.Stop();

        //    bool areEqual = true;
        //    foreach (var item in expected)
        //    {
        //        if (actual[item.Key] != item.Value)
        //        {
        //            areEqual = false; break;
        //        }
        //    }
        //    Assert.IsTrue(areEqual && timer.Elapsed.Milliseconds<50);
        //}
    }
}
