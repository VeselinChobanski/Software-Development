namespace Password;

using _4.PasswordGenerator;
public class Tests
{
    ServicesPassword services;
    ControllerPassword controller;
    ViewPassword view;
    [SetUp]
    public void Setup()
    {
        services = new ServicesPassword();
        controller = new ControllerPassword(services);
        view = new ViewPassword(controller);
    }

    [TestCase("a", "5")]
    [TestCase("5", "a")]
    public void Test_ThowsEx(string n, string l)
    {
        var ex = Assert.Throws<FormatException>(() =>
        {
            view.ThowsEx(n,l);
        });

    }
}
