namespace AdventureTest;

using _7.Adventure;

public class Tests
{
    ServicesAdv services;
    ControllerAdv controller;
    ViewAdv view;

    [SetUp]
    public void Setup()
    {
        services = new ServicesAdv();
        controller = new ControllerAdv(services);
        view = new ViewAdv(controller);
    }

    [TestCase("a", "summer")]
    public void Test_FormatExpectation(string n, string season)
    {
        var ex = Assert.Throws<FormatException>(() =>
        {
            view.ThrowsExeptionAdv(n, season);
        });

        Assert.That(ex.Message, Is.EqualTo($"The input string '{n}' was not in a correct format."));
    }


    [TestCase("5", "aa")]
    public void Test_Invalid(string n, string season)
    {
        var ex = Assert.Throws<Exception>(() =>
        {
            view.ThrowsExeptionAdv(n, season);
        });

        Assert.That(ex.Message, Is.EqualTo($"No valid season"));
    }

    [TestCase("-5", "summer")]
    public void Test_Negative(string n, string season)
    {
        var ex = Assert.Throws<Exception>(() =>
        {
            view.ThrowsExeptionAdv(n, season);
        });

        Assert.That(ex.Message, Is.EqualTo($"Negative budget"));
    }
}
