using Machine.Specifications;
using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKataTests
{
    [Subject("Given a number over 1000 should return smaller number")]
    public class GivenANumberOver1000
    {
        //Arrange
        static string numbers = "1,1002";

        static StringCalculator sut;

        Establish context = () =>
            sut = new StringCalculator();

        //Act
        static int actual;

        Because of = () =>
            actual = sut.Add(numbers);

        //Assert
        static int expected = 1;

        It Should_Return_The_Sum = () =>
            actual.ShouldEqual(expected);
    }
}
