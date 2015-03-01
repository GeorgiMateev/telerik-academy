using _8.ExtractSentences;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestExtractSentences
{
    
    
    /// <summary>
    ///This is a test class for TestExtractSenteces and is intended
    ///to contain all TestExtractSenteces Unit Tests
    ///</summary>
    [TestClass()]
    public class TestExtractSenteces
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
        ///A test for ExtractSentencesByWord
        ///</summary>
        [TestMethod()]
        public void NormalTest()
        {
            string text = @"We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            string word = "in"; // TODO: Initialize to an appropriate value
            string[] expected = new string[]
                {
                    "We are living in a yellow submarine.",
                    "We will move out of it in 5 days."
                }; 
            string[] actual;
            actual = ExtractSentences.ExtractSentencesByWord(text, word);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i]!=actual[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }

        /// <summary>
        ///A test for ExtractSentencesByWord
        ///</summary>
        [TestMethod()]
        public void TestWithWordOnEnd()
        {
            string text = @"We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            string word = "submarine"; // TODO: Initialize to an appropriate value
            string[] expected = new string[]
                {
                    "We are living in a yellow submarine.",
                    "Inside the submarine is very tight."
                };
            string[] actual;
            actual = ExtractSentences.ExtractSentencesByWord(text, word);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }

        /// <summary>
        ///A test for ExtractSentencesByWord
        ///</summary>
        [TestMethod()]
        public void TestWithWordOnBeginningWithUpCase()
        {
            string text = @"We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            string word = "We"; // TODO: Initialize to an appropriate value
            string[] expected = new string[]
                {
                    "We are living in a yellow submarine.",
                    "We don't have anything else.",
                    "We will move out of it in 5 days."
                };
            string[] actual;
            actual = ExtractSentences.ExtractSentencesByWord(text, word);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }

        /// <summary>
        ///A test for ExtractSentencesByWord
        ///</summary>
        [TestMethod()]
        public void TestWithNoUpCase()
        {
            string text = @"We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            string word = "we"; // TODO: Initialize to an appropriate value
            string[] expected = new string[]
                {
                    "So we are drinking all the day.",                    
                };
            string[] actual;
            actual = ExtractSentences.ExtractSentencesByWord(text, word);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }

        /// <summary>
        ///A test for ExtractSentencesByWord
        ///</summary>
        [TestMethod()]
        public void TestComplexWord()
        {
            string text = @"We are living in a yellow-submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            string word = "yellow-submarine"; // TODO: Initialize to an appropriate value
            string[] expected = new string[]
                {
                    "We are living in a yellow-submarine."                    
                };
            string[] actual;
            actual = ExtractSentences.ExtractSentencesByWord(text, word);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }

        /// <summary>
        ///A test for ExtractSentencesByWord
        ///</summary>
        [TestMethod()]
        public void TestNoMatch()
        {
            string text = @"We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            string word = "mar"; // TODO: Initialize to an appropriate value
            string[] expected = new string[]
                {
                    
                };
            string[] actual;
            actual = ExtractSentences.ExtractSentencesByWord(text, word);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }

        [TestMethod()]
        public void TestNoMatch2()
        {
            string text = @"We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            string word = "liv"; // TODO: Initialize to an appropriate value
            string[] expected = new string[]
                {
                    
                };
            string[] actual;
            actual = ExtractSentences.ExtractSentencesByWord(text, word);
            bool areEqual = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    areEqual = false; break;
                }
            }
            Assert.IsTrue(areEqual);
        }
    }
}
