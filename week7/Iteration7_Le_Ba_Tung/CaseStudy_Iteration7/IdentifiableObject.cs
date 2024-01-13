using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration5
{
    public class IdentifiableObject
    {
        private List<string> oidentifiers = new List<string>();

        public IdentifiableObject(string[] idents)
        {
            foreach (var ident in idents)
            {
                oidentifiers.Add(ident);
            }
        }
        public bool AreYou(string id)
        {
            return oidentifiers.Contains(id.ToLower());
        }
        public string FirstId
        {
            get
            {
                if (oidentifiers.Count != 0)
                {
                    return oidentifiers.First();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public void AddIdentifier(string id)
        {
            oidentifiers.Add(id.ToLower());
        }
    }
}
 