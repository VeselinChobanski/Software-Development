namespace MagicTests;

using _9.MagicNumber;

public class Tests
{
    ServicesMagic services;
    ControllerMagic controller;
    ViewMagic view;
    [SetUp]
    public void Setup()
    {
        services = new ServicesMagic();
        controller = new ControllerMagic(services);
        view = new ViewMagic(controller);
    }

    [TestCase("a")]
    public void Test_FormatExeption(string input)
    {
        var ex = Assert.Throws<FormatException>(() =>
        {
            view.ThrowsExeptionsMagic(input);
        });

        Assert.That(ex.Message, Is.EqualTo($"The input string '{input}' was not in a correct format."));
    }
}
