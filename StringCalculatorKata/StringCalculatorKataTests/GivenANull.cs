using Machine.Specifications;
using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKataTests
{
    [Subject("Given a null should return 0")]
    public class GivenANull
    {
        //Arrange
        static string numbers = null;

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
