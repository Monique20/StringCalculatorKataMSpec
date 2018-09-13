using Machine.Specifications;
using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKataTests
{
    [Subject("Given multiple numbers should return the sum")]
    public class GivenMultipleNumbers
    {
        //Arrange
        static string numbers = "1,2,3,6";

        static StringCalculator sut;

        Establish context = () =>
            sut = new StringCalculator();

        //Act
        static int actual;

        Because of = () =>
            actual = sut.Add(numbers);

        //Assert
        static int expected = 12;

        It Should_Return_The_Sum = () =>
            actual.ShouldEqual(expected);
    }
}
