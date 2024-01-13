using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration5
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look ", "look" })
        {

        }
        public override string Execute(Player p, string[] text)
        {
            IHaveInventory container = null;

            if (text[0] == "out")
            {
                return "Do you want to out? ";
            }
            if (text.Count() != 3 && text.Count() != 5)
            {
                return "I don't know how to look like that.";
            }
            else if (text[0] != "look")
            {
                return "Error in look input.";
            }
            else if (text[1] != "at")
            {
                return "What do you want to look at.";
            }
            if (text.Length == 3)
            {
                container = p;
            }
            if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in";
                }
                else
                {
                    container = FetchContainer(p, text[4]);
                    if (container == null)
                    {
                        return $"I cannot find the {text[4]}";
                    }
                }
            }
            return LookAtln(text[2], container);
        }
        public IHaveInventory FetchContainer(Player p, string containerld)
        {
            return p.Locate(containerld) as IHaveInventory;
        }
        public string LookAtln(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                return container.Locate(thingId).FullDescription;
            }
            return $"I cannot find the {thingId}";
        }
    }
}
