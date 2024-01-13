using CaseStudy_Iteration3;
using NUnit.Framework;

namespace TestItems
{
    [TestFixture]
    public class ItemTests
    {
        private Item Oitem;
        
        [SetUp]
        public void Setup()
        {
             Oitem = new Item(new String[] { "lavender", "rose" },"flowers","This is a beautiful flower");
        }

        [Test]
        public void TestIndentifiabel()
        {
            Assert.IsTrue(Oitem.AreYou("lavender"));
        }
        [Test]
        public void TestShortDescription()
        {
            Assert.That(Oitem.ShortDescription, Is.EqualTo("flowers(lavender)"));
        }
        [Test]
        public void TestFullDescription()
        {
            Assert.That(Oitem.FullDescription, Is.EqualTo("This is a beautiful flower"));
        }

    }
}