using Casestudy_Iteration4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CaseStudy_Iteration4
{
    internal class Program
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

                Item item1 = new Item(new string[] { "b52" }, "jet fighter", "this is the strongest plane");
                player.Inventory.Put(item1);
                Item item2 = new Item(new string[] { "m4a1" }, "auto", "this is a powerfull gun");
                player.Inventory.Put(item2);
                Item item3 = new Item(new string[] { "gold" }, "knife", "this is a sharp knife");
                player.Inventory.Put(item3);
                Bag bag = new Bag(new string[] { "helicopter" }, "transfer-plane", "this is the biggest plane");
                LookCommand lk = new LookCommand();
                string text = "";
                do
                {
                    Console.WriteLine("Put your command here:  ");
                    text = Console.ReadLine();
                    string[] array = Regex.Split(text, @"\s+");
                    Console.WriteLine(lk.Execute(player, array));
                } while (text != "out");
            }
        }
    }