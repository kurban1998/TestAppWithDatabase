using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CircleSquare.UnitTest
{
    [TestClass]
    public class CircleSquareUnitTest
    {
        [TestMethod]
        public void TestSuccsessValue()
        {
            //Arrange - берем условное число и проверяем результат. 
            double r = 2;
            double expected = Math.PI * Math.Pow(r, 2);

            //Act - факт. объект тестировния 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - сравнение результатов (True, False)
            Assert.Equals(expected, actual);
        }
        [TestMethod]
        public void TestNegativeValue()
        {
            //Arrange - берем условное число и проверяем результат. 
            double r = -2;

            //Act - факт. объект тестировния 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - сравнение результатов (True, False)
            Assert.Equals(0, actual);
        }
        [TestMethod]
        public void TestZeroValue()
        {
            //Arrange - берем условное число и проверяем результат. 
            double r = 0;

            //Act - факт. объект тестировния 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - сравнение результатов (True, False)
            Assert.Equals(0, 0);
        }
    }
}
