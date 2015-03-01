using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCalculateExpressions
{

    public partial class TestConvertExpressionToRPN
    {


        /// <summary>
        ///A test for ProceedWithOperator when the operator is with high priority and there is one operator in the stack.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestProceedWithOperatorHighPriorOne()
        {
            Stack<string> stack = new Stack<string>(); // TODO: Initialize to an appropriate value
            stack.Push("pow");
            stack.Push("(");
            stack.Push("+");
            stack.Push("/");

            Queue<object> queue = new Queue<object>(); // TODO: Initialize to an appropriate value
            queue.Enqueue(3);
            queue.Enqueue(5);

            char symbol = '*'; // TODO: Initialize to an appropriate value

            Queue<object> expectedQueue = new Queue<object>();
            expectedQueue.Enqueue(3);
            expectedQueue.Enqueue(5);
            expectedQueue.Enqueue("/");

            Stack<string> expectedStack = new Stack<string>();
            expectedStack.Push("pow");
            expectedStack.Push("(");
            expectedStack.Push("+");
            expectedStack.Push("*");


            CalculateExpressions_Accessor.ProceedWithOperator(stack, queue, symbol);

            bool isEqualStack = true;
            while (stack.Count > 0)
            {
                if (stack.Pop() != expectedStack.Pop())
                {
                    isEqualStack = false;
                    break;
                }
            }

            bool isEqualQueue = true;
            while (queue.Count > 0)
            {
                if (queue.Dequeue().ToString() != expectedQueue.Dequeue().ToString())
                {
                    isEqualQueue = false;
                    break;
                }
            }

            Assert.IsTrue(isEqualStack);
            Assert.IsTrue(isEqualQueue);
        }

        /// <summary>
        ///A test for ProceedWithOperator when the operator is with high priority and there is many operators in the stack.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestProceedWithOperatorHighPriorMany()
        {
            Stack<string> stack = new Stack<string>(); // TODO: Initialize to an appropriate value
            stack.Push("pow");
            stack.Push("(");
            stack.Push("+");
            stack.Push("*");
            stack.Push("/");
            stack.Push("*");

            Queue<object> queue = new Queue<object>(); // TODO: Initialize to an appropriate value
            queue.Enqueue(3);
            queue.Enqueue(5);

            char symbol = '*'; // TODO: Initialize to an appropriate value

            Queue<object> expectedQueue = new Queue<object>();
            expectedQueue.Enqueue(3);
            expectedQueue.Enqueue(5);
            expectedQueue.Enqueue("*");
            expectedQueue.Enqueue("/");
            expectedQueue.Enqueue("*");

            Stack<string> expectedStack = new Stack<string>();
            expectedStack.Push("pow");
            expectedStack.Push("(");
            expectedStack.Push("+");
            expectedStack.Push("*");


            CalculateExpressions_Accessor.ProceedWithOperator(stack, queue, symbol);

            bool isEqualStack = true;
            while (stack.Count > 0)
            {
                if (stack.Pop() != expectedStack.Pop())
                {
                    isEqualStack = false;
                    break;
                }
            }

            bool isEqualQueue = true;
            while (queue.Count > 0)
            {
                if (queue.Dequeue().ToString() != expectedQueue.Dequeue().ToString())
                {
                    isEqualQueue = false;
                    break;
                }
            }

            Assert.IsTrue(isEqualStack);
            Assert.IsTrue(isEqualQueue);
        }

        /// <summary>
        ///A test for ProceedWithOperator when the operator is with high priority and there is no operators in the stack.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestProceedWithOperatorHighPriorNo()
        {
            Stack<string> stack = new Stack<string>(); // TODO: Initialize to an appropriate value
            stack.Push("pow");
            stack.Push("(");
            stack.Push("+");

            Queue<object> queue = new Queue<object>(); // TODO: Initialize to an appropriate value
            queue.Enqueue(3);
            queue.Enqueue(5);

            char symbol = '*'; // TODO: Initialize to an appropriate value

            Queue<object> expectedQueue = new Queue<object>();
            expectedQueue.Enqueue(3);
            expectedQueue.Enqueue(5);

            Stack<string> expectedStack = new Stack<string>();
            expectedStack.Push("pow");
            expectedStack.Push("(");
            expectedStack.Push("+");
            expectedStack.Push("*");


            CalculateExpressions_Accessor.ProceedWithOperator(stack, queue, symbol);

            bool isEqualStack = true;
            while (stack.Count > 0)
            {
                if (stack.Pop() != expectedStack.Pop())
                {
                    isEqualStack = false;
                    break;
                }
            }

            bool isEqualQueue = true;
            while (queue.Count > 0)
            {
                if (queue.Dequeue().ToString() != expectedQueue.Dequeue().ToString())
                {
                    isEqualQueue = false;
                    break;
                }
            }

            Assert.IsTrue(isEqualStack);
            Assert.IsTrue(isEqualQueue);
        }

        /// <summary>
        ///A test for ProceedWithOperator when the operator is with high priority and there is one operator in the stack.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestProceedWithOperatorLowPriorMany()
        {
            Stack<string> stack = new Stack<string>(); // TODO: Initialize to an appropriate value
            stack.Push("pow");
            stack.Push("(");
            stack.Push("+");
            stack.Push("/");

            Queue<object> queue = new Queue<object>(); // TODO: Initialize to an appropriate value
            queue.Enqueue(3);
            queue.Enqueue(5);

            char symbol = '-'; // TODO: Initialize to an appropriate value

            Queue<object> expectedQueue = new Queue<object>();
            expectedQueue.Enqueue(3);
            expectedQueue.Enqueue(5);
            expectedQueue.Enqueue("/");
            expectedQueue.Enqueue("+");

            Stack<string> expectedStack = new Stack<string>();
            expectedStack.Push("pow");
            expectedStack.Push("(");
            expectedStack.Push("-");


            CalculateExpressions_Accessor.ProceedWithOperator(stack, queue, symbol);

            bool isEqualStack = true;
            while (stack.Count > 0)
            {
                if (stack.Pop() != expectedStack.Pop())
                {
                    isEqualStack = false;
                    break;
                }
            }

            bool isEqualQueue = true;
            while (queue.Count > 0)
            {
                if (queue.Dequeue().ToString() != expectedQueue.Dequeue().ToString())
                {
                    isEqualQueue = false;
                    break;
                }
            }

            Assert.IsTrue(isEqualStack);
            Assert.IsTrue(isEqualQueue);
        }

        /// <summary>
        ///A test for ProceedWithOperator when the operator is with low priority and there is no operators in the stack.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestProceedWithOperatorLowPriorNo()
        {
            Stack<string> stack = new Stack<string>(); // TODO: Initialize to an appropriate value
            stack.Push("pow");
            stack.Push("(");
           

            Queue<object> queue = new Queue<object>(); // TODO: Initialize to an appropriate value
            queue.Enqueue(3);
            queue.Enqueue(5);

            char symbol = '-'; // TODO: Initialize to an appropriate value

            Queue<object> expectedQueue = new Queue<object>();
            expectedQueue.Enqueue(3);
            expectedQueue.Enqueue(5);
            

            Stack<string> expectedStack = new Stack<string>();
            expectedStack.Push("pow");
            expectedStack.Push("(");
            expectedStack.Push("-");


            CalculateExpressions_Accessor.ProceedWithOperator(stack, queue, symbol);

            bool isEqualStack = true;
            while (stack.Count > 0)
            {
                if (stack.Pop() != expectedStack.Pop())
                {
                    isEqualStack = false;
                    break;
                }
            }

            bool isEqualQueue = true;
            while (queue.Count > 0)
            {
                if (queue.Dequeue().ToString() != expectedQueue.Dequeue().ToString())
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
