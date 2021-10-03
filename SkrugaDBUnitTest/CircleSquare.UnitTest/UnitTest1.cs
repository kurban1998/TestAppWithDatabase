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
            //Arrange - ����� �������� ����� � ��������� ���������. 
            double r = 2;
            double expected = Math.PI * Math.Pow(r, 2);

            //Act - ����. ������ ����������� 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - ��������� ����������� (True, False)
            Assert.Equals(expected, actual);
        }
        [TestMethod]
        public void TestNegativeValue()
        {
            //Arrange - ����� �������� ����� � ��������� ���������. 
            double r = -2;

            //Act - ����. ������ ����������� 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - ��������� ����������� (True, False)
            Assert.Equals(0, actual);
        }
        [TestMethod]
        public void TestZeroValue()
        {
            //Arrange - ����� �������� ����� � ��������� ���������. 
            double r = 0;

            //Act - ����. ������ ����������� 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - ��������� ����������� (True, False)
            Assert.Equals(0, 0);
        }
    }
}
