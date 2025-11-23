using _1.TransportPrice;
using NUnit.Framework.Internal;

namespace TransportTest
{
    public class Tests
    {
        ViewTransport view;
        [SetUp]
        public void Setup()
        {
            view = new ViewTransport();
        }

        [TestCase("-5", "day")]
        [TestCase("-1", "dadd")]
        public void Test_TrowsExeptionNegativeNumber(string num, string dayOrNight)
        {
            var ex = Assert.Throws<Exception>(() =>
             {
                 view.ThrowException(num, dayOrNight);
             });
            Assert.That(ex.Message, Is.EqualTo("Negative distance"));
        }

        [TestCase("5", "a")]

        public void Test_TrowsExeptionNoDayOrNight(string num, string dayOrNight)
        {
            var ex = Assert.Throws<Exception>(() =>
             {
                 view.ThrowException(num, dayOrNight);
             });
            Assert.That(ex.Message, Is.EqualTo("No day or night"));
        }

        [TestCase("a", "day")]

        public void Test_TrowsFormatExceptionNumber(string num, string dayOrNight)
        {
            var ex = Assert.Throws<FormatException>(() =>
            {
                view.ThrowException(num, dayOrNight);
            });

            Assert.That(ex.Message, Is.EqualTo($"The input string '{num}' was not in a correct format."));
        }

    }
}
