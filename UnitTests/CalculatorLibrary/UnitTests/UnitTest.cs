using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTest
    {
        public int testResult;

        [TestCase]
        public void StringCalculator_EmptyString_ReturnZero()
        {
            testResult = CalculatorLibrary.StringCalculator.Add("");

            Assert.AreEqual(0, testResult);
        }

        [TestCase]
        public void StringCalculator_One_ReturnsOne()
        {
            testResult = CalculatorLibrary.StringCalculator.Add("1");

            Assert.AreEqual(1, testResult);
        }

        [TestCase]
        public void StringCalculator_OneAndTwo_ReturnsThree()
        {
            testResult = CalculatorLibrary.StringCalculator.Add("1,2");

            Assert.AreEqual(3, testResult);
        }

        [TestCase]
        public void StringCalculator_MoreNumbers()
        {
            testResult = CalculatorLibrary.StringCalculator.Add("1,3,5,7,9,12,15");

            Assert.AreEqual(52, testResult);
        }

        [TestCase]
        public void StringCalculator_NewLine()
        {
            testResult = CalculatorLibrary.StringCalculator.Add("1,2\n3");

            Assert.AreEqual(6, testResult);
        }

        [TestCase]
        public void StringCalculator_CustomDelimiter()
        {
            testResult = CalculatorLibrary.StringCalculator.Add("//;\n1;2");

            Assert.AreEqual(3, testResult);
        }

        [TestCase]
        public void StringCalculator_NegativeNumber_Throws_Exception()
        {
            try
            {
                testResult = CalculatorLibrary.StringCalculator.Add("//;\n1;-2");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Don't use negative numbers -2", e.Message);
            }
        }

        [TestCase]
        public void StringCalculator_IgnoreBigValues()
        {
            testResult = CalculatorLibrary.StringCalculator.Add("1001");

            Assert.AreEqual(0, testResult);
        }

        [TestCase]
        public void StringCalculator_IgnoreBigValues_InSum()
        {
            testResult = CalculatorLibrary.StringCalculator.Add("2,1001");

            Assert.AreEqual(2, testResult);
        }
    }
}
