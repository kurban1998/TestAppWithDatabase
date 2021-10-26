﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CircleSquareTest
{
    [TestClass]
    public class AreaCalculatorTest
    {
        private CircleAreaCalculator.AreaCalculator circle;

        [TestInitialize] // перед каждым запуском теста выполняем код ниже.
        public void TestInit()
        { // новый экзмепляр класса 
            circle = new CircleAreaCalculator.AreaCalculator();
        }

        [TestMethod]
        public void SquareResSuccsess()
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
        public void SquareResZero()
        {
            //Arrange - берем условное число и проверяем результат. 
            double r = 0;

            //Act - факт. объект тестировния 
            double actual = circle.CircleSquare(r);
            
            //Assert - сравнение результатов (True, False)
            Assert.AreEqual(0, actual);
        }
        [TestMethod]
        public void SquareResNegative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => circle.CircleSquare(-2));
        }
    }
}