using Verse;

namespace CCRT_itemTags
{
    [StaticConstructorOnStartup]
    public static class StartupPatches_CCRT
    {

        static StartupPatches_CCRT()
        {
            /*
            Based on ColinFang's startup patch. Much simpler code.
            This is essentially telling the game that "For each thing YOU have designated as "t"  in Verse.ThingDef, if that ThingDef includes "Haulable"
            Then add the ItemTag properties.
            */
            foreach (var t in DefDatabase<ThingDef>.AllDefs)
            {
                if (t.EverHaulable)
                {
                    t.comps.Add(new CompProperties
                    {
                        compClass = typeof(CompItemTags_CCRT)
                    });
                }

            }
        }
    }
}
