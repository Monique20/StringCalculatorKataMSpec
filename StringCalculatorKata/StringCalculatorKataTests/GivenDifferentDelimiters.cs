using Machine.Specifications;
using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKataTests
{
    [Subject("Given different delimiters should return the sum")]
    public class GivenDifferentDelimiters
    {
        //Arrange
        static string numbers = "1\n2,3;6/4(6)6*5#4";

        static StringCalculator sut;

        Establish context = () =>
            sut = new StringCalculator();

        //Act
        static int actual;

        Because of = () =>
            actual = sut.Add(numbers);

        //Assert
        static int expected = 37;

        It Should_Return_The_Sum = () =>
            actual.ShouldEqual(expected);
    }
}
