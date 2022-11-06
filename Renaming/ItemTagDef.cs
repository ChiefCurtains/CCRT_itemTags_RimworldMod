using System.Text;
using Verse;

namespace CCRT_itemTags
{
    /// <summary>
    /// Based on Rimworld.BackStoryDef Line 79
    /// </summary>
    public class ItemTagDef : BuildableDef
    {
        public string TagAName(LabelValue label)
        {
            return tagAName;
        }
        public string tagAName;
        
    }
}
