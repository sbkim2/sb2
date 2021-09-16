using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using testPjt;
namespace ClassLibrary1
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(4, 2, 6)]
        public void TestAdd(double x, double y, double expected)
        {
            // Arrange
            Calculator cal = new Calculator();

            //Act
            double actual = cal.Add(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
    }

   
}
