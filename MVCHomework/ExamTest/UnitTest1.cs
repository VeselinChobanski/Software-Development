using _2.OnTimeExam;
using _2.OnTimeExam.View;
namespace ExamTest;

public class Tests
{
    ViewExam view;
    ControllerExam controller;
    ServiceExam service;
    [SetUp]
    public void Setup()
    {
       view = new ViewExam(controller); 
    }

    [TestCase ("-5","8", "6", "4")]
    [TestCase("5", "-8", "6", "4")]
    [TestCase("5", "8", "-6", "4")]
    [TestCase("5", "8", "6", "-4")]

    public void Test_ThowsExeptionNegativeNumber(string num1, string num2, string num3, string num4)
    {
       var ex = Assert.Throws<Exception>(() =>
        {
            view.ThrowsExeption(num1, num2, num3, num4);
        });

        Assert.That(ex.Message, Is.EqualTo("Negative input"));
    }

    [TestCase("a", "8", "6", "4")]

    public void Test_ThrowsExeptionInvalidFormat(string num1, string num2, string num3, string num4)
    {
        var ex = Assert.Throws<FormatException>(() =>
        {
            view.ThrowsExeption(num1, num2, num3, num4);
        });

        Assert.That(ex.Message, Is.EqualTo($"The input string '{num1}' was not in a correct format."));
    }
}
