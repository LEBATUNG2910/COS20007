using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseStudy_Iteration4
{
    public class Location : Item , IHaveInventory
    {
        private Inventory oinventory;
        public Location(string[] id, string name, string desc) : base(new string[] { "location" }, name, desc)
        {
            oinventory = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id) == true)
            {
                return this;
            }
            return oinventory.Fetch(id);
        }
        public Inventory Inventory
        {
            get
            {
                return oinventory;
            }
        }
        public override string FullDescription
        {
            get
            {
                return "You are in the " + Name + "\n" + "Room description: " + base.FullDescription + "\n And in this room have \n" + oinventory.Itemlist;
            }
        }

    }
}
