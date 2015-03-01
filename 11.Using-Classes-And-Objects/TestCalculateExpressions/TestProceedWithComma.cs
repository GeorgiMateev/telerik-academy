using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculateExpressions
{
    public partial class TestConvertExpressionToRPN
    {


        /// <summary>
        ///A test for ProceedWithComma
        ///</summary>
        [TestMethod()]
        [DeploymentItem("7.CalculateExpressions.exe")]
        public void TestProceedWithComma()
        {
            Stack<string> stack = new Stack<string>(); // TODO: Initialize to an appropriate value
            stack.Push("pow");
            stack.Push("(");
            stack.Push("*");

            Queue<object> queue = new Queue<object>(); // TODO: Initialize to an appropriate value
            queue.Enqueue(3);
            queue.Enqueue(5);

            Queue<object> expectedQueue = new Queue<object>();
            expectedQueue.Enqueue(3);
            expectedQueue.Enqueue(5);
            expectedQueue.Enqueue("*");

            Stack<string> expectedStack = new Stack<string>();
            expectedStack.Push("pow");
            expectedStack.Push("(");

            CalculateExpressions_Accessor.ProceedWithComma(stack, queue);

            bool isEqualStack = true;
            while (stack.Count>0)
            {
                if (stack.Pop() != expectedStack.Pop())
                {
                    isEqualStack = false;
                    break;
                }
            }

            bool isEqualQueue = true;
            while (queue.Count>0)
            {
                if ( queue.Dequeue().ToString() != expectedQueue.Dequeue().ToString() )
                {
                    isEqualQueue = false;
                    break;
                }
            }

            Assert.IsTrue(isEqualStack);
            Assert.IsTrue(isEqualQueue);
        }
    }
}
