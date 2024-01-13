using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CaseStudy_Iteration5;
using System.Threading.Tasks;

namespace Iteration4Test
{
    [TestFixture]
    public class ItemTests
    {
        private Item oitem;

        [SetUp]
        public void Setup()
        {
            oitem = new Item(new String[] { "lavender", "rose" }, "flowers", "This is a beautiful flower");
        }

        [Test]
        public void TestIndentifiabel()
        {
            Assert.IsTrue(oitem.AreYou("lavender"));
        }
        [Test]
        public void TestShortDescription()
        {
            Assert.That(oitem.ShortDescription, Is.EqualTo("flowers(lavender)"));
        }
        [Test]
        public void TestFullDescription()
        {
            Assert.That(oitem.FullDescription, Is.EqualTo("This is a beautiful flower"));
        }

    }
}

