using CaseStudy_Iteration3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration3Test
{
    public class BagTest
    {
        private Inventory oinvetory;
        private Item oitem, oitem1;
        private Bag obag1, obag2;
        [SetUp]
        public void Setup()
        {
            obag1 = new Bag(new string[] { "sultan", "scimitar" }, "armored vehicle", "This is a strong vehicle");
            obag2 = new Bag(new string[] { "fv622" }, "military transport vehicles", "This is a useful vehice");
            oinvetory = new Inventory();
            oitem = new Item(new string[] { "glock", "eagle" }, "short gun", "This is a power gun");
            oitem1 = new Item(new string[] { "su27" }, "military", "This is fast plane");
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
            Assert.That(obag1, Is.EqualTo(obag1.Locate("sultan")));
        }
        [Test]
        public void TestBagLocateNothing()
        {
            Assert.That(obag2.Locate("sultan"), Is.EqualTo(null));

        }
        [Test]
        public void TestBagFullDescription()
        {
            obag1.Inventory.Put(oitem);
            string text = "In the armored vehicle you can see \tshort gun(glock)\n";
            StringAssert.Contains(obag1.FullDescription, text);

        }
        [Test]
        public void Baginbag()
        {

            obag2.Inventory.Put(oitem);
            obag1.Inventory.Put(oitem1);
            obag1.Inventory.Put(obag2);
            Assert.That(obag1.Locate("su27"), Is.EqualTo(oitem1));
            Assert.That(obag1.Locate("fv622"), Is.EqualTo(obag2));
            Assert.That(obag1.Locate("glock"), Is.EqualTo(null));

        }
    }
}
