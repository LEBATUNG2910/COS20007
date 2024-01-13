using NUnit.Framework;
using Casestudy_Iteration4;
using CaseStudy_Iteration4;

namespace CaseStudy_Iteration4
{
    public class Tests
    {
        private Player p, oplayer;
        private Bag obag;
        private Command ocommand;

        private Item oitem;

        [SetUp]
        public void Setup()
        {
            oitem = new Item(new string[] { "b52" }, "a b52", "This is a good plane");
            ocommand = new LookCommand();
            oplayer = new Player("Tung", "best player");
            p = new Player("Tung", "professional");
            obag = new Bag(new string[] { "bag" }, "backpack", $"This is {p.FirstId} backpack");
            p.Inventory.Put(obag);
        }

        [Test]
        public void TestLookAtMe()
        {
            string outputc = ocommand.Execute(p, new string[] { "look", "at", "inventory" });
            string desc = $"{p.FullDescription}";
            Assert.AreEqual(desc, outputc);
        }

        [Test]
        public void TestLookAtGem()
        {
            p.Inventory.Put(oitem);

            string outputc = ocommand.Execute(p, new string[] { "look", "at", "b52" });
            string desc = $"{oitem.FullDescription}";
            Assert.AreEqual(desc, outputc);
        }

        [Test]
        public void TestLookAtUnk()
        {
            string outputc = ocommand.Execute(p, new string[] { "look", "at", "b52" });
            string desc = "I cannot find the b52";
            Assert.AreEqual(desc, outputc);
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            p.Inventory.Put(oitem);
            string outputc = ocommand.Execute(p, new string[] { "look", "at", "b52", "in", "me" });
            string desc = $"{oitem.FullDescription}";
            Assert.AreEqual(desc, outputc);
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            obag.Inventory.Put(oitem);
            string outputc = ocommand.Execute(p, new string[] { "look", "at", "b52", "in", "bag" });
            string desc = $"{oitem.FullDescription}";
            Assert.AreEqual(desc, outputc);
        }


        [Test]
        public void TestLookAtGemInNoBag()
        {
            obag.Inventory.Put(oitem);
            oplayer.Inventory.Put(obag);
            string outputc = ocommand.Execute(oplayer, new string[] { "look", "at", "b52", "in", $"{p.FirstId}" });
            string desc = $"I cannot find the b52";
            Assert.AreEqual(desc, outputc);
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            obag.Inventory.Put(oitem);
            string outputc = ocommand.Execute(p, new string[] { "look", "at", "bag", "in", "b52" });
            string desc = "I cannot find the b52";
            Assert.AreEqual(desc, outputc);
        }
    }
}