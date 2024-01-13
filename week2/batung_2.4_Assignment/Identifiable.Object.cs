using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batung_2._4_Assignment
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();

        public IdentifiableObject(string[] idents)
        {
            foreach (var ident in idents)
            {
                _identifiers.Add(ident);
            }
        }
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }
        public string FirstId
        {
            get
            {
                if (_identifiers.Count != 0)
                {
                    return _identifiers.First();
                    //return string.Empty;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
