using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CaseStudy_Iteration5
{
    public class Path : GameObject
    {

        private Location odestination, oend;
        public Path(string[] id, string name, string desc, Location end, Location destination) : base(id, name, desc)
        {
            odestination = destination;


            AddIdentifier("Path");
            string[] namepart = Regex.Split(name, @"\s+");
            foreach (var part in namepart)
            {
                AddIdentifier(part);
            }

        }

        public Location Destination
        {
            get => odestination;
            set => odestination = value;
        }

    }
}

