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
    public class LocationTest
    {
        private Location _nam;
        private Item oitem1, oitem2;
        private Player oplayer;
        [SetUp]
        public void Setup()
        {
            oitem1 = new Item(new string[] { "tank", "canon" }, "unbreak vehicle", "This is a strong vehicle");
            oitem2 = new Item(new string[] { "b52" }, "warplane", "this is plane is so powerful");
            oplayer = new Player("Tung", "bad boy");
            _nam = new Location("tunnel", "US army");

        }
        [Test]
        public void TestLocationIdentifiers()
        {
            Assert.True(_nam.AreYou("location"));
        }
        [Test]
        public void TestLocateItemHave()
        {
            _nam.Inventory.Put(oitem2);
            Assert.That(_nam.Locate("b52"), Is.EqualTo(oitem2));
        }
        [Test]
        public void TestPlayerLocateIteminLocation()
        {
            _nam.Inventory.Put(oitem1);
            _nam.Inventory.Put(oitem2);
            oplayer.Inventory.Put(oitem1);
            oplayer.Inventory.Put(oitem2);
            oplayer.Location = _nam;
            Assert.That(oplayer.Locate("tank"), Is.EqualTo(oitem1));

        }

    }
}
