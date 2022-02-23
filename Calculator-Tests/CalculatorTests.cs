using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Library;
using System;

namespace Calculator_Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly CalculatorLib _library;

        public CalculatorTests()
        {
            _library = new CalculatorLib();
        }

        //Added test cases for Addition method
        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 1, 3)]
        [DataRow(3, 1, 4)]
        [DataRow(0, 0, 0)]
        [DataRow(0, -1, -1)]
        [DataRow(-1000, -1, -1001)]
        [DataRow(100, 34, 134)]
        [DataRow(10, 1, 11)]
        [DataRow(21, 1, 22)]
        [DataRow(54, 1,55)]
        public void AdditionTest(int num1, int num2, int expected)
        {
            int result = _library.Addition(num1, num2);
            Assert.AreEqual(expected, result);
        }

        //Added test cases for Subtraction method
        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(2, 1, 1)]
        [DataRow(3, 1, 2)]
        [DataRow(0, 0, 0)]
        [DataRow(0, -1, 1)]
        [DataRow(-1000, -1, -999)]
        [DataRow(100, 34, 66)]
        [DataRow(10, 1, 9)]
        [DataRow(21, 1, 20)]
        [DataRow(54, 1, 53)]
        public void SubtractionTest(int num1, int num2, int expected)
        {
            int result = _library.Subtraction(num1, num2);
            Assert.AreEqual(expected, result);
        }


        //Added test cases for Multiplication method
        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 1, 2)]
        [DataRow(3, 1, 3)]
        [DataRow(0, 0, 0)]
        [DataRow(0, -1, 0)]
        [DataRow(-1000, -1, 1000)]
        [DataRow(100, 34, 3400)]
        [DataRow(10, 1,10)]
        [DataRow(21, 1, 21)]
        [DataRow(54, 1, 54)]
        public void MultiplicationTest(int num1, int num2, int expected)
        {
            int result = _library.Multiplication(num1, num2);
            Assert.AreEqual(expected, result);
        }

        //Added test cases for Division method
        [TestMethod]
        [DataRow(1,0)]
        public void DivisionTest_DivideByZero(int num1, int num2)
        {
            Assert.ThrowsException<DivideByZeroException>(() => _library.Division(num1, num2));
        }
        
        [TestMethod]
        public void DivisionTest2()
        {
            decimal result = _library.Division(1, 1);
            Assert.AreEqual((decimal)1, result);
        }

        [TestMethod]
        public void DivisionTest3()
        {
            decimal result = _library.Division(2, 3);
            Assert.AreEqual(0.6666666666666666666666666667m, result);
        }


        [TestMethod]
        public void DivisionTest4()
        {
            decimal result = _library.Division(2, 3);
            Assert.AreEqual(0.6666666666666666666666666667m, result);
        }

        [TestMethod]
        public void DivisionTest5()
        {
            decimal result = _library.Division(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivisionTest6()
        {
            decimal result = _library.Division(1, -1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void DivisionTest7()
        {
            decimal result = _library.Division(1000, 100);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void DivisionTest8()
        {
            decimal result = _library.Division(1000, 100);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void DivisionTest9()
        {
            decimal result = _library.Division(1.5m, 2.5m);
            Assert.AreEqual(0.6m, result);
        }
    }
}
