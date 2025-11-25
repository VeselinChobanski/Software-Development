namespace PipeTest;

using _6.Pipe;
using System.ComponentModel.DataAnnotations;

public class Tests
{
    ServicesPipe services;
    ControllerPipe controller;
    ViewPipe view;
    [SetUp]
    public void Setup()
    {
        services = new ServicesPipe();
        controller = new ControllerPipe(services);
        view = new ViewPipe(controller);
    }

    [TestCase("-5", "7", "10", "77")]
    public void Test_ThrowsNegativeNumber(string num1, string num2, string num3, string num4)
    {
        var ex = Assert.Throws<Exception>(() =>
        {
            view.ThrowsExeptionsPipe( num1,  num2,  num3,  num4);
        });

        Assert.That(ex.Message, Is.EqualTo("Negative number"));
    }

    [TestCase("a", "7", "10", "77")]
    public void Test_ThrowsFormatExpetation(string num1, string num2, string num3, string num4)
    {
        var ex = Assert.Throws<FormatException>(() =>
        {
            view.ThrowsExeptionsPipe(num1, num2, num3, num4);
        });

        Assert.That(ex.Message, Is.EqualTo("The input string 'a' was not in a correct format."));
    }
}
