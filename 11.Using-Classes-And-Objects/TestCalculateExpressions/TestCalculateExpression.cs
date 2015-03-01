using CalculateExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestCalculateExpressions
{
    public partial class TestCalculateExpressionInRPN
    {

        /// <summary>
        ///A test for CalculateExpressionInRPN
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestOrdinaryWithSmallCaps()
        {
            Queue<object> queue = new Queue<object>(); // TODO: Initialize to an appropriate value
            queue.Enqueue( 3.0);
            queue.Enqueue( 8.0);
            queue.Enqueue( 10.14);
            queue.Enqueue( "+");
            queue.Enqueue( 2.0);
            queue.Enqueue( "/");
            queue.Enqueue( "+");
            queue.Enqueue( "ln");
            queue.Enqueue( 3.4);
            queue.Enqueue( 0.1);
            queue.Enqueue("*" );
            queue.Enqueue( 4.0);
            queue.Enqueue( "sqrt");
            queue.Enqueue( "pow");
            queue.Enqueue( "-");

            double expected = 2.38; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions.CalculateExpressions.CalculateExpressionInRPN(queue);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }

        /// <summary>
        ///A test for CalculateExpressionInRPN
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestOrdinaryWithCapital()
        {
            Queue<object> queue = new Queue<object>(); // TODO: Initialize to an appropriate value
            queue.Enqueue(3.0);
            queue.Enqueue(8.0);
            queue.Enqueue(10.14);
            queue.Enqueue("+");
            queue.Enqueue(2.0);
            queue.Enqueue("/");
            queue.Enqueue("+");
            queue.Enqueue("LN");
            queue.Enqueue(3.4);
            queue.Enqueue(0.1);
            queue.Enqueue("*");
            queue.Enqueue(4.0);
            queue.Enqueue("sqrt");
            queue.Enqueue("pow");
            queue.Enqueue("-");

            double expected = 2.38; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions_Accessor.CalculateExpressionInRPN(queue);
            Assert.AreEqual(expected,Math.Round( actual,2));
        }

        /// <summary>
        ///A test for CalculateExpressionInRPN
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestOrdinaryGivenExample1()
        {
             Queue<object> queue = CalculateExpressions.CalculateExpressions.ConvertExpressionToRPN
                ("(3+5.3)*2.7-ln(22)/pow(2.2,-1.7)");         
            

            double expected = 10.6; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions.CalculateExpressions.CalculateExpressionInRPN(queue);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }

        /// <summary>
        ///A test for CalculateExpressionInRPN
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CalculateExpressions.exe")]
        public void TestOrdinaryGivenExample2()
        {
            Queue<object> queue = CalculateExpressions.CalculateExpressions.ConvertExpressionToRPN
               ("pow(2,3.14)*(3-(3*sqrt(2)-3.2)+1.5*0.3)");


            double expected = 21.22; // TODO: Initialize to an appropriate value
            double actual;
            actual = CalculateExpressions.CalculateExpressions.CalculateExpressionInRPN(queue);
            Assert.AreEqual(expected, Math.Round( actual,2));
        }
    }
}
