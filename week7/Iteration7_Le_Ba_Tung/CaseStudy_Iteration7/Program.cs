using CaseStudy_Iteration5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Casestudy_Iteration5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zombie War III");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "." + " Welcome to our game");
            Console.WriteLine("Let's me take some description about your:");
            string description = Console.ReadLine();
            Player player = new Player(name, description);

            Location location = new Location("military training grounds", "Military area");
            player.Location = location;
            Location loc = new Location("military base", "this is a large military area and you just see a gun in the table ");
            Path path = new Path(new string[] { "downstair" }, "stair ", "go to the stair", location, loc);
            Path path2 = new Path(new string[] { "west" }, "f22", "go to f22 to find the military airbase", loc, location);
            Location loc2 = new Location("airbase", "this is a lot of war plane in here");
            Path path3 = new Path(new string[] { "north" }, "b52", "go to the b52", location, loc2);
            Path path4 = new Path(new string[] { "south" }, "door", "go to the door to move the next area", loc2, location);
            Location loc3 = new Location("billet", "this is a place solidiers live");
            Path path5 = new Path(new string[] { "upstair" }, "stair", "go upstair to find the map", location, loc3);
            Path path6 = new Path(new string[] { "west" }, "red house", "go to red house to find the billet", loc3, location);
            location.AddPath(path);
            loc.AddPath(path2);
            location.AddPath(path3);
            loc2.AddPath(path4);
            location.AddPath(path5);
            loc3.AddPath(path6);
            Item item1 = new Item(new string[] { "b52" }, "warplane", "this is the biggest plane");
            player.Inventory.Put(item1);
            Item item2 = new Item(new string[] { "m4a1" }, "auto", "this is a powerful gun");
            player.Inventory.Put(item2);
            Item item3 = new Item(new string[] { "gold" }, "knife", "this is a sharp knife");
            player.Inventory.Put(item3);
            Item item4 = new Item(new string[] { "compass" }, "mititary map", "this is a useful thing");
            player.Inventory.Put(item4);
            Bag bag = new Bag(new string[] { "huron" }, "Military airbase", "this is a big plane");

            player.Inventory.Put(bag);
            bag.Inventory.Put(item1);
            location.Inventory.Put(item1);
            loc2.Inventory.Put(item2);
            loc.Inventory.Put(item3);
            loc3.Inventory.Put(item4);

            string text;
            //    do
            //    {
            //        Console.WriteLine("Put your command here:  ");
            //        text = Console.ReadLine();

            //        Console.WriteLine(lk.Execute(player, text));
            //    } while (text != "out");
            //}
            var lk = new CommandProcessor();

            do
            {
                Console.WriteLine("Put your command here: ");
                text = Console.ReadLine();
                Console.WriteLine(lk.Execute(text, player));
            } while (text != "out");

        }
    }
}
