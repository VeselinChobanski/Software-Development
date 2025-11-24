namespace HistogramTest;

using _3.Histogram;
using _3.Histogram.View;

public class Tests
{
    ServiceHistogram service;
    ViewHistogram view;
    ControllerHistogram controller;

    [SetUp]
    public void Setup()
    {
        service = new ServiceHistogram();
        controller = new ControllerHistogram(service);
        view = new ViewHistogram(controller);
        
    }

    [TestCase("-5")]
    public void Test_ThrowsExeptionsN(string n)
    {
       var ex =  Assert.Throws<Exception>(() =>
        {
            view.ThrowsExeptionsN(n);
        });

        Assert.That(ex.Message, Is.EqualTo("Negative N"));
    }

    [TestCase ("a")]
    public void Tes_Test_ThrowsExeptionsN2(string n)
    {
        var ex = Assert.Throws<FormatException>(() =>
        {
            view.ThrowsExeptionsN(n);
        });

        Assert.That(ex.Message, Is.EqualTo($"The input string '{n}' was not in a correct format."));
    }

    [Test]
    public void Tes_Test_ThrowsExeptionsList()
    {
        List<string> n = new List<string> { "a", "b" };

        var ex = Assert.Throws<FormatException>(() =>
        {
            view.ThrowsExeptionsList(n);
        });

        
        Assert.That(ex, Is.TypeOf<FormatException>());

      
        Assert.That(ex.Message, Does.Contain("not in a correct format"));
    }



}
