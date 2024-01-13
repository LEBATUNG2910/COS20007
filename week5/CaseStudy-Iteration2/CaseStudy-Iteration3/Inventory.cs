using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration3
{
    public class Inventory
    {
        private List<Item> items = new List<Item>();

        public Inventory()
        {

        }
        public bool HasItem(string id)
        {
            foreach (var item in items)
            {
                if (item.AreYou(id) == true)
                    return true;
            }
            return false;
        }
        public void Put(Item itm)
        {
            items.Add(itm);
        }
        public Item Fetch(string id)
        {
            foreach (var item in items)
            {
                if (item.AreYou(id) == true)
                {
                    return item;
                }
            }
                    return null;

        }
        public Item Take(string id)
        {
            foreach(var item in items)
            {
                if(item.AreYou(id) == true)
                {
                    items.Remove(item);
                }
            }
            return null;
        }
        public string Itemlist
        {
            get
            {
                string list = string.Empty;
                foreach (var item in items)
                {
                    list += "\t" + item.ShortDescription + "\n";
                }
                return list;
            }
        }
    }
}
