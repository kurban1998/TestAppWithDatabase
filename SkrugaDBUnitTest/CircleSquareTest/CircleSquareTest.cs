using System;
using Xunit;

namespace CircleSquareTest
{//xUnit
    
    public class CircleSquareTest
    {
        
        [Fact]
        public void SquareRes()
        {
            
            //Arrange - берем условное число и проверяем результат. 
            double r = 2;
            double expected = Math.PI * Math.Pow(r, 2);

            //Act - факт. объект тестировния 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - сравнение результатов (True, False)
            Assert.Equal(expected, actual);
        }
    }
}
