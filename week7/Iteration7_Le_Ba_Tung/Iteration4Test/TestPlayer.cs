using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CaseStudy_Iteration5;
using System.Text;
using System.Threading.Tasks;

namespace Iteration4Test
{
    [TestFixture]
    public class TestPlayer
    {
        private bool result;
        private Player oplayer;
        private Item oitem1;
        private Item oitem2;

        [SetUp]
        public void Setup()
        {
            oplayer = new Player("Tung", "professional");
            oitem1 = new Item(new String[] { "m4a1", "kar98" }, "gun", "This is power gun");
            oitem2 = new Item(new String[] { "gold", "light" }, "sword", "This is a beautiful sword");
        }
        [Test]
        public void TestIdentifiale()
        {
            Assert.IsTrue(oplayer.AreYou("me"));
            Assert.IsTrue(oplayer.AreYou("inventory"));
        }
        [Test]
        public void TestLocatesItem()
        {
            oplayer.Inventory.Put(oitem1);
            Assert.That(oplayer.Locate("m4a1"), Is.EqualTo(oitem1));
            oplayer.Inventory.Put(oitem2);
            Assert.That(oplayer.Locate("light"), Is.EqualTo(oitem2));
        }
        [Test]
        public void TestLocatesItself()
        {
            Assert.That(oplayer.Locate("me"), Is.EqualTo(oplayer));
        }
        [Test]
        public void TestLocateNothing()
        {

            oplayer.Inventory.Put(oitem1);
            oplayer.Inventory.Put(oitem2);
            if (oplayer.Locate("nam") != oitem1 || oplayer.Locate("nam") != oitem2)
            {
                result = false;
            }
            Assert.False(result);
        }
        [Test]
        public void TestDescription()
        {
            string text = "You are Tung professional\nYou are carrying:\n\tgun(kar98)\n\tsword(light) ";
            StringAssert.Contains(oplayer.FullDescription, text);
        }
    }
}