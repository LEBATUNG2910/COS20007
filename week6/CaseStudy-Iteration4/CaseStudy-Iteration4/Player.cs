using CaseStudy_Iteration4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration4
{
    public class Player:GameObject , IHaveInventory
    {
        private Inventory oinventory;
        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
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
            get { return $"You are {Name} {base.FullDescription}\nYou are carrying:\n{oinventory.Itemlist}"; }
        }
        public Inventory Inventory
        {
            get { return oinventory; }
        }
    }
}