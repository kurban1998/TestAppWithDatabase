using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Design;

namespace CircleAreaCalculator.UnitTests
{
    [TestClass]
    public class AreaCalculatorTest
    {
        private CircleAreaCalculator.AreaCalculator circle;
        private CircleAreaCalculator.AreaCalculator trapeze;
        [TestInitialize] // перед каждым запуском теста выполняем код ниже.
        public void TestInit()
        { // новый экзмепляр класса 
            circle = new CircleAreaCalculator.AreaCalculator();
            trapeze = new CircleAreaCalculator.AreaCalculator();
        }

        [TestMethod]
        public void CircleSquareResSuccsess()
        {

            //Arrange - берем условное число и проверяем результат. 
            double r = 2;
            double expected = Math.PI * Math.Pow(r, 2);

            //Act - факт. объект тестирования 
            
            double actual = circle.CircleSquare(r);

            //Assert - сравнение результатов (True, False)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CircleSquareResZero()
        {
            //Arrange - берем условное число и проверяем результат. 
            double r = 0;

            //Act - факт. объект тестировния 
            double actual = circle.CircleSquare(r);
            
            //Assert - сравнение результатов (True, False)
            Assert.AreEqual(0, actual);
        }
        [TestMethod]
        public void CircleSquareResNegative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => circle.CircleSquare(-2));
        }

        [TestMethod]
        public void TrapezeSquareResSuccsess()
        {
            //Arrange - берем условное число и проверяем результат. 
            double sizeA = 1;
            double sizeB = 2;
            double height = 3;
            double expected = (sizeA + sizeB) / 2 * height;

            //Act - факт. объект тестирования 

            double actual = trapeze.TrapezeSquare(sizeA,sizeB,height);

            //Assert - сравнение результатов (True, False)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TrapezeSquareResNegative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trapeze.TrapezeSquare(1,0,-1));
        }
    }
}
