using NUnit.Framework;
using Clockclass;

namespace CLockTest
{
    [TestFixture]
    public class Clocktest
    {
        private Clock _clockName;
        [SetUp]
        public void Setup()
        {
            _clockName = new Clock();

        }

        [Test]
        public void TestFormat()
        {

            Assert.That(_clockName.displayTime(), Is.EqualTo("00:00:00"));
        }
        [Test()]
        public void TestClockTicks()
        {
            for (int i = 0; i < 12; i++)
            {
                _clockName.Time();
            }
            Assert.That(_clockName.displayTime(), Is.EqualTo("00:00:12"));
        }
        [Test]
        public void TestSecond()
        {
            _clockName.Time();
            Assert.That(_clockName.displayTime(), Is.EqualTo("00:00:01"));
        }
        [Test]
        public void TestMinute()
        {
            for (int i = 0; i < 60; i++)
            {
                _clockName.Time();
            }
            Assert.That(_clockName.displayTime(), Is.EqualTo("00:01:00"));
        }
        [Test]
        public void TestHour()
        {
            for (int i = 0; i < 3600; i++)
            {
                _clockName.Time();
            }
            Assert.That(_clockName.displayTime(), Is.EqualTo("01:00:00"));
        }
        [Test]
        public void TestRest()
        {
            for (int i = 0; i == 3600; i++)
            {
                _clockName.Time();
            }
            _clockName.Reset();
            Assert.That(_clockName.displayTime(), Is.EqualTo("00:00:00"));
        }
    }
}