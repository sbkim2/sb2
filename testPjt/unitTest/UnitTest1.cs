using System;
using Xunit;
using testPjt;
namespace unitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4,2,6)]  // ������� x�� ,y ��, ���� ��
        public void AddTest(double x, double y, double expected)
        {
            //arrange
            Calculator cal = new Calculator(); // cal �̶�� Calculator ��ü�� �����Ѵ�.

            //Act
            double actual = cal.Add(x, y); // cal.add�� x+y�� ����

            //Assert
            Assert.Equal(expected, actual); // ��� ���� ���� ���� ������ ���
        }

        [Theory]
        [InlineData(4, 2, 2)]
        public void divideTest(double x, double y, double expected)
        {
            //arrange
            Calculator cal = new Calculator();

            //Act
            double actual = cal.Divide(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 20, 0, 50, 30)]
        public void LimitTest(double x, double y, double minValue, double maxValue, double expected)
        {
            //arrange
            Calculator cal = new Calculator();

            //Act
            double actual = cal.LimitedAdd(x, y, minValue, maxValue);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
