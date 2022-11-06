using System.Collections.Generic;
using Verse;

namespace CCRT_itemTags
{
    [StaticConstructorOnStartup]
    public static class StartupPatches_ItemTag
    {

        static StartupPatches_ItemTag()
        {
            var thingDefs = DefDatabase<ThingDef>.AllDefsListForReading;
            for (int i = 0; i < thingDefs.Count; i++)
            {
                var curDef = thingDefs[i];
                if (typeof(ThingWithComps).IsAssignableFrom(curDef.thingClass))
                {
                    if (curDef.comps == null)
                        curDef.comps = new List<CompProperties>();
                    curDef.comps.Add(new CompProperties() { compClass = typeof(Comp_ItemTag) });
                }
            }
        }
    }
}
