using System;
using Xunit;
using testPjt;
namespace unitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4,2,6)]  // 순서대로 x값 ,y 값, 예상 값
        public void AddTest(double x, double y, double expected)
        {
            //arrange
            Calculator cal = new Calculator(); // cal 이라는 Calculator 객체를 생성한다.

            //Act
            double actual = cal.Add(x, y); // cal.add는 x+y를 리턴

            //Assert
            Assert.Equal(expected, actual); // 결과 값과 예상 값이 맞으면 통과
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
