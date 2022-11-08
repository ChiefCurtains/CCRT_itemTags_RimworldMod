using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace CCRT_itemTags
{
    /// <summary>
    /// TagNameDefs.xml
    /// </summary>
    public class TagNamesDef : BuildableDef
    {
        public static TagNamesDef Named(string defName)
        {
            return DefDatabase<TagNamesDef>.GetNamed(defName, true);
        }
        public TagNamesDef category;
    }
}
