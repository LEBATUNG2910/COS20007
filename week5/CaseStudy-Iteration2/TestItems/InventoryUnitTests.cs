using CaseStudy_Iteration3;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using TestItems;


namespace Iteration2Test
{
    [TestFixture]
   public class InventoryUnitTest
    {
        private Inventory inventory;
        private Item Oitm1 , Oitm2 ;
        [SetUp]
        public void Setup()
        {
            inventory = new Inventory();
            Oitm1 = new Item(new string[] { "lavender", "rose" }, "flowers", "This is a beautiful flower");
            Oitm2 = new Item(new string[] {"carnation"},"flower","This is a special flower");
        }
        [Test]
        public void TestFindItem()
        {
            inventory.Put(Oitm2);
            Assert.IsTrue(inventory.HasItem("carnation"));
        }
        [Test]
        public void TestNoItemFind()
        {
            inventory.Put(Oitm1);
            Assert.IsFalse(inventory.HasItem("carnation"));
        }
        [Test]
        public void TestFetchItem()
        {
            inventory.Put(Oitm1);
            Assert.That(inventory.Fetch("lavender"), Is.EqualTo(Oitm1));
        }
        [Test]
        public void TestTakeItem()
        {
            inventory.Put(Oitm2);
            inventory.Take("lavender");
            Assert.IsFalse(inventory.HasItem("lavender"));
        }
        [Test]
        public void TestListItem()
        {
            string list = "flowers(lavender)\n"+ "flowers(rose)\n";
            StringAssert.Contains(inventory.Itemlist,list);
        }
    }
   
}
