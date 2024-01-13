using CaseStudy_Iteration3;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace Iteration2Test
{
    [TestFixture]
    public class TestPlayer
    {
        private bool result;
        private Player Oplayer;
        private Item Oitem1;
        private Item Oitem2;

        [SetUp]
        public void Setup()
        {
            Oplayer = new Player("Tung","professional");
            Oitem1 = new Item(new String[] { "akm", "m24" }, "gun", "This is power gun");
            Oitem2 = new Item(new String[] { "silver", "dark" }, "sword", "This is a beautiful sword");
        }
        [Test]
        public void TestIdentifiale()
        {
            Assert.IsTrue(Oplayer.AreYou("me"));
            Assert.IsTrue(Oplayer.AreYou("inventory"));
        }
        [Test]
        public void TestLocatesItem()
        {
            Oplayer.Inventory.Put(Oitem1);
            Assert.That(Oplayer.Located("akm"), Is.EqualTo(Oitem1));
            Oplayer.Inventory.Put(Oitem2);
            Assert.That(Oplayer.Located("dark"), Is.EqualTo(Oitem2));
        }
        [Test]
        public void TestLocatesItself()
        {
            Assert.That(Oplayer.Located("me"), Is.EqualTo(Oplayer));
        }
        [Test]
        public void TestLocateNothing()
        {
            
            Oplayer.Inventory.Put(Oitem1);
            Oplayer.Inventory.Put(Oitem2);
            if (Oplayer.Located("Nam") != Oitem1 || Oplayer.Located("Nam") != Oitem2)
            {
                result = false;
            }
            Assert.False(result);
        }
        [Test]
        public void TestDescription()
        {
            string text = "You are Tung professional\nYou are carrying:\n\tgun(m24)\n\tsword(silver) ";
            StringAssert.Contains(Oplayer.FullDescription,text);
        }
    }
}
