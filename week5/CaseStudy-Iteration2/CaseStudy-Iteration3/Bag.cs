using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration3
{
    public class Bag : Item
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
