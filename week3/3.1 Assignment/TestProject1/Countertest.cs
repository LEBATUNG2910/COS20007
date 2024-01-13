using NUnit.Framework;
using System.Diagnostics.Metrics;
using Clockclass;
namespace Countertest;

[TestFixture]
public class Tests
{
    private Counterclass _counter;
    [SetUp]
    public void Setup()
    {
        _counter = new Counterclass("hour");
    }

    [Test]
    public void TestTicks()
    {
        Assert.That(_counter.Ticks, Is.EqualTo(0));
    }
    [Test()]
    public void TestIncrement()
    {
        _counter.Increment();
        Assert.That(_counter.Ticks, Is.EqualTo(1));
    }
    [Test]
    public void TestIncrementMutiple()
    {
        for (int i = 0; i < 3; i++)
        {
            _counter.Increment();

        }
        Assert.That(_counter.Ticks, Is.EqualTo(3));
    }
    [Test]
    public void TestReset()
    {
        for (int i = 0; i < 8; i++)
        {
            _counter.Increment();
        }
        _counter.Reset();

        Assert.That(_counter.Ticks, Is.EqualTo(0));
    }
}