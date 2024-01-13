using CaseStudy_Iteration3;
using NUnit.Framework;


namespace Iteration2Test
{
        [TestFixture]
        public class IdentifiableObjectTest
        {
            private IdentifiableObject Oid;
            private IdentifiableObject Oid1;
            [SetUp]
            public void Setup()
            {
                Oid = new IdentifiableObject(new string[] { "fred", "bob" });
                Oid1 = new IdentifiableObject(new string[] { "", "bob" });
            }

            [Test]
            public void TestAreYou()
            {
                Assert.IsTrue(Oid.AreYou("bob"));
            }
            [Test]
            public void NotAreYou()
            {
                Assert.IsFalse(Oid.AreYou("wilma"));
            }
            [Test]
            public void TestCaseSensitive()
            {
                Assert.IsTrue(Oid.AreYou("FRED"));
            }
            [Test]
            public void TestFirstId()
            {

                Assert.That(Oid.FirstId, Is.EqualTo("fred"));
            }
            [Test]
            public void TestFirstIdWithNoIds()
            {

                Assert.That(Oid1.FirstId, Is.EqualTo(""));
            }
            [Test]
            public void TestAddID()
            {

                Oid.AddIdentifier("wilma");
                Assert.IsTrue(Oid.AreYou("fred"));
                Assert.IsTrue(Oid.AreYou("bob"));
                Assert.IsTrue(Oid.AreYou("wilma"));
            }
        }
    }

