using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using StringCalculatorKata;

namespace StringCalculatorKataTests
{
    [Subject("Given an empty string should return 0")]
    public class GivenAWhitespace
    {
        //Arrange
        static string numbers = " ";

        static StringCalculator sut;

        Establish context = () =>
           sut = new StringCalculator();

        //Act
        static int actual;
        Because of = () =>
           actual = sut.Add(numbers);

        //Assert
        static int expected = 0;

        It Should_Return_0 = () =>
           actual.ShouldEqual(expected);
    }
}
