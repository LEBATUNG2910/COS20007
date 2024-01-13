using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration4
{
    public class IdentifiableObject
    {
        
            private List<string> Oidentifiers = new List<string>();

            public IdentifiableObject(string[] idents)
            {
                foreach (var ident in idents)
                {
                    Oidentifiers.Add(ident);
                }
            }
            public bool AreYou(string id)
            {
                return Oidentifiers.Contains(id.ToLower());
            }
            public string FirstId
            {
                get
                {
                    if (Oidentifiers.Count != 0)
                    {
                        return Oidentifiers.First();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            public void AddIdentifier(string id)
            {
                Oidentifiers.Add(id.ToLower());
            }
        }
    }

