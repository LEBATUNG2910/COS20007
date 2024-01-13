using CaseStudy_Iteration5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = CaseStudy_Iteration5.Path;

namespace Iteration4Test
{
    public class MoveCommandTest
    {
        private Player oplayer;
        private Location oloc1;
        private Location oloc2;
        private Path path;
        private MoveCommand omove;


        [SetUp]
        public void SetUp()
        {
            oplayer = new Player("Tung", "best player");

            oloc1 = new Location("military base", "this is a large military area and you just see a gun in the table ");
            oloc2 = new Location("airbase", "this is a lot of war plane in here");



            oplayer.Location = oloc1;
            path = new Path(new string[] { "north" }, "b52", "go to the b52", oloc1, oloc2);

            oloc1.AddPath(path);
            omove = new MoveCommand();
        }

        [Test]
        public void TestPlayer()
        {
            omove.Execute(oplayer, new string[] { "move", "west" });
            Assert.That(actual: oplayer.Location.Name, Is.EqualTo(oloc1.Name));

        }

        [Test]
        public void TestCommand()
        {
            omove.Execute(oplayer, new string[] { "su30", "south" });
            Assert.That(actual: oplayer.Location.Name, Is.EqualTo(oloc1.Name));
        }

        [Test]
        public void TestPlayerInvalidPath()
        {
            omove.Execute(oplayer, new string[] { "move", "south" });
            Assert.That(oplayer.Location, Is.EqualTo(oloc1));
        }

        [Test]
        public void InvalidMoved()
        {

            Assert.That(actual: omove.Execute(oplayer, new string[] { "go", "to", "the", "south", "side" }), Is.EqualTo("Cannot know location you want to go "));


            Assert.That(actual: omove.Execute(oplayer, new string[] { "move" }), Is.EqualTo("What do you want to go"));


            Assert.That(actual: omove.Execute(oplayer, new string[] { "go to", "south" }), Is.EqualTo("Cannot know location you want to go "), "only recognize {head, go, move, leave}");
        }
    }
}
