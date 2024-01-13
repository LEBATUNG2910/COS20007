using CaseStudy_Iteration5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseStudy_Iteration5
{
    public class Location : Item, IHaveInventory
    {
        private Inventory oinventory;
        private List<Path> opath = new List<Path>();
        public Location(string name, string desc) : base(new string[] { "location" }, name, desc)
        {
            oinventory = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id) == true)
            {
                return this;
            }
            foreach (Path p in opath)
            {
                if (p.AreYou(id))
                {
                    return p;
                }
            }
            return oinventory.Fetch(id);
        }
        public string ListPath
        {
            get
            {
                string list = string.Empty;
                if (opath.Count() == 1)
                {
                    return "The exit gate locate at " + opath[0].FirstId;
                }
                list += "The exit gate locate at ";
                int i = 0;
                do
                {
                    if (i == opath.Count() - 1)
                    {
                        list = "and " + opath[i].FirstId + ".";
                    }
                    else
                    {
                        list = opath[i].FirstId + ",";
                    }
                    i++;
                } while (i < opath.Count());
                return list;
            }
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
        public void AddPath(Path path)
        {
            opath.Add(path);
        }

    }
}
