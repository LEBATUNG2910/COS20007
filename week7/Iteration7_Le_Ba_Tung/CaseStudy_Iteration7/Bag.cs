using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseStudy_Iteration5
{
    public class Bag : Item, IHaveInventory
    {
        private Inventory oinventory;

        public Bag(string[] id, string name, string desc) : base(id, name, desc)
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
        public override string FullDescription
        {
            get
            {
                return "In the " + Name + " you can see " + oinventory.Itemlist;
            }
        }
        public Inventory Inventory
        {
            get { return oinventory; }
        }
    }
}
