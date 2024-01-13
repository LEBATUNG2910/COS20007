using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration3
{
    public class Player:GameObject
    {
        private Inventory Oinventory;
        public Player(string name, string desc):base(new string[] { "me", "inventory" }, name, desc)
        {
            Oinventory = new Inventory();
        }
        public GameObject Located(string id)
        {
            if (AreYou(id) == true)
            
            {
                return this ; 
            }
            return Oinventory.Fetch(id);
        }
        public  override string FullDescription
        {
            get { return $"You are {Name} {base.FullDescription}\nYou are carrying:\n{Oinventory.Itemlist}"; }
        }
        public Inventory Inventory
        {
            get { return Oinventory; }
        }
    }
}
