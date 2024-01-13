using CaseStudy_Iteration5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = CaseStudy_Iteration5.Path;

namespace Iteration4Test
{
    [TestFixture]
    public class PathTest
    {
        private Player player;
        private Location loc1;
        private Location loc2;
        private Path path;

        [SetUp]
        public void Setup()
        {
            loc1 = new Location("military base", "this is a large military area and you just see a gun on the table");
            loc2 = new Location("airbase", "this is a lot of war plane in here");

            player = new Player("Tung", "best player");
            path = new Path(new string[] { "north" }, "b52", "go to the b52", loc1, loc2);
        }

        [Test]
        public void Player_Move_To_Path_Destination()
        {
            player.Location = loc1;
            loc1.AddPath(path);
            player.Move_Player(path);
            Location exp = loc2;
            Location real = player.Location;
            Assert.That(real, Is.EqualTo(exp));
        }

        [Test]
        public void Player_Leave_Location()
        {
            player.Location = loc1;
            loc1.AddPath(path);
            player.Move_Player(path);


            Assert.That(player.Location, Is.EqualTo(loc2));
        }

        [Test]
        public void Player_Remain_Same_Location_Invalid()
        {
            player.Location = loc1;
            loc1.AddPath(path);
            Path error = loc1.Locate("west") as Path;
            Location _loc = player.Location;

            if (error != null)
            {
                player.Move_Player(error);
            }
            ;
            Assert.That(player.Location, Is.EqualTo(_loc));
        }

        [Test]
        public void Find_Path()
        {
            player.Location = loc1;
            path = new Path(new string[] { "south" }, "door", "go to the door to move the next area", loc1, loc2);
            loc1.AddPath(path);



            Assert.That(loc1.Locate("south"), Is.EqualTo(path));
        }
    }
}

