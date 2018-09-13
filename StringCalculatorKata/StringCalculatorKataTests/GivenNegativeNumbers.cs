using Machine.Specifications;
using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKataTests
{
    [Subject(typeof(Exception))]
    public class GivenNegativeNumbers
    {
        //Arrange
        static string expected = "negatives not allowed:-1";

        static Exception exception;

        static string numbers = "-1";

        static StringCalculator sut;

        Establish context = () =>
            sut = new StringCalculator();
        //Act
        static int actual = sut.Add(numbers);

        Because of = () =>
           exception = Catch.Exception((() => actual));


        //Assert
        It should_throw_same_exception = () =>
           exception.Message.ShouldEqual(expected);
    }
}
