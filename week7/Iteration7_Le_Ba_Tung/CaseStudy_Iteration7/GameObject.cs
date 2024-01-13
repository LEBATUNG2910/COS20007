using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration5
{
    public class GameObject : IdentifiableObject
    {
        private string odescription;
        private string oname;

        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            oname = name;
            odescription = desc;
        }
        public string Name
        {
            get => oname;
        }
        public string ShortDescription
        {
            get => oname + "(" + FirstId + ")";
        }
        public virtual string FullDescription
        {
            get => odescription;
        }


    }
}
