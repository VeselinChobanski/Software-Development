namespace VegetableTest;

using _5.VegetablesShop;
using _5.VegetablesShop.View;

public class Tests
{
    ServicesShop services;
    ControllerShop controller;
    ViewShop view;
    [SetUp]
    public void Setup()
    {
        services = new ServicesShop();
        controller = new ControllerShop(services);
        view = new ViewShop(controller);
    }

    [TestCase("a", "1", "5", "8")]
    public void Test_TryCatchExeptions(string a, string b, string c, string t)
    {
        var ex = Assert.Throws<FormatException>(() =>
        {
            view.ThrowsExeptions(a, b, c, t);
        });
    }
}
