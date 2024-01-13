using NUnit.Framework;
using batung_2._4_Assignment;
namespace batung_Ilteration1
{
    public class Tests
    {
        [TestFixture]
        public class IdentifiableObjectTest
        {
            [Test]
            public void TestAreYou()
            {
                var id = new IdentifiableObject(new string[] { "fred", "bob" });
                Assert.IsTrue(id.AreYou("bob"));
            }

            [Test]
            public void NotAreYou()
            {
                var id = new IdentifiableObject(new string[] { "fred", "bob" });
                Assert.IsFalse(id.AreYou("wilma"));
            }

            [Test]
            public void TestCaseSensitive()
            {
                var id = new IdentifiableObject(new string[] { "fred", "bob" });
                Assert.IsTrue(id.AreYou("FRED"));
            }

            [Test]
            public void TestFirstId()
            {
                var id = new IdentifiableObject(new string[] { "fred", "bob" });
                Assert.That(id.FirstId, Is.EqualTo("fred"));
            }

            [Test]
            public void TestFirstIdWithNoIds()
            {
                var id1 = new IdentifiableObject(new string[] { "", "bob" });
                Assert.That(id1.FirstId, Is.EqualTo(""));
            }

            [Test]
            public void TestAddID()
            {
                var id = new IdentifiableObject(new string[] { "fred", "bob" });
                id.AddIdentifier("wilma");
                Assert.IsTrue(id.AreYou("fred"));
                Assert.IsTrue(id.AreYou("bob"));
                Assert.IsTrue(id.AreYou("wilma"));
            }
        }
    }

}
