using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration3
{
    public class GameObject : IdentifiableObject
    {
        private string Odescription;
        private string Oname;

        public GameObject(string[]ids,string name,string desc):base(ids)
        {
            Oname = name;
            Odescription = desc;
        }
        public string Name
        {
            get => Oname;
        }
        public string ShortDescription
        {
            get => Oname + "("+FirstId+")";
        }
        public virtual string  FullDescription
        {
            get => Odescription;
        }

       
    }
}
