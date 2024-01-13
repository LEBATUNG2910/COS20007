using CaseStudy_Iteration5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Path = CaseStudy_Iteration5.Path;
using System.Threading.Tasks;

namespace Iteration4Test
{
    [TestFixture]
    public class TestCommandProcessor
    {
        private CommandProcessor ocp;
        private Player oplayer;
        private Location olocation, olocation1;
        private Item item;
        private Path path;

        [SetUp]
        public void SetUp()
        {
            ocp = new CommandProcessor();
            oplayer = new Player("Tung", "best player");
            item = new Item(new string[] { "su30" }, "warplane", "this is power plane");
            oplayer.Inventory.Put(item);

            olocation1 = new Location("military training grounds", "Military area");
            olocation = new Location("airbase", "this is a lot of war plane in here");
            path = new Path(new string[] { "north" }, "b52", "go to the b52", olocation1, olocation);

            olocation.AddPath(path);
            oplayer.Location = olocation;

        }

        [Test]
        public void TestLookCommand()
        {
            Assert.That(ocp.Execute("look at su30", oplayer), Is.EqualTo("this is power plane"));
        }

        [Test]
        public void TestMoveCommand()
        {
            string result = ocp.Execute("move north", oplayer);
            Assert.AreEqual("If you want to go to north " + "going to " + path.Name + " and reached the " + oplayer.Location.Name + "\n\n" + oplayer.Location.FullDescription, result);
            Assert.AreEqual(olocation, oplayer.Location);
            Assert.That(oplayer.Location, Is.EqualTo(olocation));
        }




    }
}


