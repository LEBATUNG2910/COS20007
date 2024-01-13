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
    public class InventoryUnitTest
    {
        private Inventory inventory;
        private Item oitm1, oitm2;
        [SetUp]
        public void Setup()
        {
            inventory = new Inventory();
            oitm1 = new Item(new string[] { "lavender", "rose" }, "flowers", "This is a beautiful flower");
            oitm2 = new Item(new string[] { "carnation" }, "flower", "This is a special flower");
        }
        [Test]
        public void TestFindItem()
        {
            inventory.Put(oitm2);
            Assert.IsTrue(inventory.HasItem("carnation"));
        }
        [Test]
        public void TestNoItemFind()
        {
            inventory.Put(oitm1);
            Assert.IsFalse(inventory.HasItem("carnation"));
        }
        [Test]
        public void TestFetchItem()
        {
            inventory.Put(oitm1);
            Assert.That(inventory.Fetch("lavender"), Is.EqualTo(oitm1));
        }
        [Test]
        public void TestTakeItem()
        {
            inventory.Put(oitm2);
            inventory.Take("lavender");
            Assert.IsFalse(inventory.HasItem("lavender"));
        }
        [Test]
        public void TestListItem()
        {
            string list = "flowers(lavender)\n" + "flowers(rose)\n";
            StringAssert.Contains(inventory.Itemlist, list);
        }
    }
}
