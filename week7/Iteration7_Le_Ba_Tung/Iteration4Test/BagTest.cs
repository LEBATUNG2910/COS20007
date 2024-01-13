using System;
using NUnit.Framework;
using CaseStudy_Iteration5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration4Test
{
    [TestFixture]
    public class BagTest
    {
        private Inventory oinvetory;
        private Item oitem, oitem1;
        private Bag obag1, obag2;
        [SetUp]
        public void Setup()
        {
            obag1 = new Bag(new string[] { "leopard2", "canon" }, "armored vehicle", "This vehicle is unbreakable");
            obag2 = new Bag(new string[] { "fv105" }, "military transport vehicles", "This vehicle is not useless");
            oinvetory = new Inventory();
            oitem = new Item(new string[] { "glock", "eagle" }, "short gun", "This is a power gun");
            oitem1 = new Item(new string[] { "f22" }, "military", "This plane is so fast");
        }
        [Test]
        public void BagLocateItem()
        {
            obag1.Inventory.Put(oitem);
            Assert.That(obag1.Locate("glock"), Is.EqualTo(oitem));
            Assert.IsTrue(obag1.Inventory.HasItem("glock"));

        }
        [Test]
        public void TestBagLocateItself()
        {
            Assert.That(obag1, Is.EqualTo(obag1.Locate("leopard2")));
        }
        [Test]
        public void TestBagLocateNothing()
        {
            Assert.That(obag2.Locate("leopard2"), Is.EqualTo(null));

        }
        [Test]
        public void TestBagFullDescription()
        {
            obag1.Inventory.Put(oitem);
            string text = "In the armored vehicle you can see short gun(glock)\n";
            StringAssert.Contains(obag1.FullDescription, text);

        }
        [Test]
        public void Baginbag()
        {

            obag2.Inventory.Put(oitem);
            obag1.Inventory.Put(oitem1);
            obag1.Inventory.Put(obag2);
            Assert.That(obag1.Locate("f22"), Is.EqualTo(oitem1));
            Assert.That(obag1.Locate("fv105"), Is.EqualTo(obag2));
            Assert.That(obag1.Locate("glock"), Is.EqualTo(null));

        }
    }


}
