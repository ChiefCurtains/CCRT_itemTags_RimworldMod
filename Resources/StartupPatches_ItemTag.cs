using System.Collections.Generic;
using Verse;

namespace CCRT_itemTags
{
    [StaticConstructorOnStartup]
    public static class StartupPatches_ItemTag
    {
        //This Allows tagging of ALLLLLLLLL Items, can be tricky so we will revisit. 
        static StartupPatches_ItemTag()
        {
            foreach (var t in DefDatabase<ThingDef>.AllDefs)
            {
                if (t.EverHaulable)
                {
                    t.comps.Add(new CompProperties
                    {
                        compClass = typeof(Comp_ItemTag)
                    });
                }

            }
        }
        //{
        //    var thingDefs = DefDatabase<ThingDef>.AllDefsListForReading;
        //    for (int i = 0; i < thingDefs.Count; i++)
        //    {
        //        var curDef = thingDefs[i];
        //        if (typeof(ThingWithComps).IsAssignableFrom(curDef.thingClass))
        //        {
        //            if (curDef.comps == null)
        //                curDef.comps = new List<CompProperties>();
        //            curDef.comps.Add(new CompProperties() { compClass = typeof(Comp_ItemTag) });
        //        }
        //    }
        //}
    }
}
