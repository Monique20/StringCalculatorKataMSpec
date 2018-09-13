using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using Machine.Specifications.Model;
using StringCalculatorKata;

namespace StringCalculatorKataTests
{
    [Subject("Given a single number should return that number")]
    public class GivenASingleNumber
    {
        //Arrange
        static string numbers = "1";

        static StringCalculator sut;

        Establish context = () =>
            sut = new StringCalculator();

        //Act
        static int actual;

        Because of = () =>
            actual = sut.Add(numbers);

        //Assert
        static int expected = 1;

        It Should_Return_That_Number = () =>
            actual.ShouldEqual(expected);
    }
}
