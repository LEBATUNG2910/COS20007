using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseStudy_Iteration5
{
    public class Player : GameObject, IHaveInventory
    {
        private Location olocation;
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
            GameObject ob = oinventory.Fetch(id);
            if (ob != null)
            {
                return ob;
            }
            if (olocation != null)
            {
                ob = olocation.Locate(id);
                return ob;
            }
            else
            {
                return null;
            }

            //{
            //    if (AreYou(id) == true)

            //    {
            //        return this;
            //    }
            //    if (oinventory.HasItem(id))
            //    {
            //        return oinventory.Fetch(id);
            //    }
            //    dmm = oinventory.Fetch(id);
            //    if (olocation != null)
            //    {
            //        dmm = olocation.Locate(id);
            //        return dmm;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
        }
        public override string FullDescription
        {
            get { return $"You are {Name} {base.FullDescription}\nYou are carrying:\n{oinventory.Itemlist}"; }
        }
        public Inventory Inventory
        {
            get { return oinventory; }
        }
        public Location Location
        {
            get => olocation;
            set => olocation = value;
        }
        public void Move_Player(Path path)
        {
            if (path.Destination != null)
            {
                Location = path.Destination;
            }

        }
    }
}

