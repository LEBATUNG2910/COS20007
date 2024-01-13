using System;
using System.Collections.Generic;
using NUnit.Framework;
using CaseStudy_Iteration5;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration4Test
{
    [TestFixture]
    public class IdentifiableObjectTest
    {
        private IdentifiableObject oid;
        private IdentifiableObject oid1;
        [SetUp]
        public void Setup()
        {
            oid = new IdentifiableObject(new string[] { "fred", "bob" });
            oid1 = new IdentifiableObject(new string[] { "", "bob" });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(oid.AreYou("bob"));
        }
        [Test]
        public void NotAreYou()
        {
            Assert.IsFalse(oid.AreYou("wilma"));
        }
        [Test]
        public void TestCaseSensitive()
        {
            Assert.IsTrue(oid.AreYou("FRED"));
        }
        [Test]
        public void TestFirstId()
        {

            Assert.That(oid.FirstId, Is.EqualTo("fred"));
        }
        [Test]
        public void TestFirstIdWithNoIds()
        {

            Assert.That(oid1.FirstId, Is.EqualTo(""));
        }
        [Test]
        public void TestAddID()
        {

            oid.AddIdentifier("wilma");
            Assert.IsTrue(oid.AreYou("fred"));
            Assert.IsTrue(oid.AreYou("bob"));
            Assert.IsTrue(oid.AreYou("wilma"));
        }
    }
}