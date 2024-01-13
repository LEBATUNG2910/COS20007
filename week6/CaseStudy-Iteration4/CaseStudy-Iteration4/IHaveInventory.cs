using CaseStudy_Iteration4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration4
{
    public interface IHaveInventory
    {

        GameObject Locate(string id);
        string Name
        {
            get;
        }
    }
}
