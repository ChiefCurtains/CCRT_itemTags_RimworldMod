using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace CCRT_itemTags.Harmony
{
    public static class Patch_QualityUtility
    {

        [HarmonyPatch(typeof(QualityUtility))]
        [HarmonyPatch(nameof(QualityUtility.SendCraftNotification))]
        public static class Patch_SendCraftNotification
        {

            public static void Postfix(ref Thing thing)
            {
                // Auto favourite produced items that are Masterwork or higher quality
                if (Resources.Mod_ItemTag.Settings.autoTag)
                {
                    bool isBuilding = thing is Building;
                    if ((isBuilding && Resources.Mod_ItemTag.Settings.autoTagConstructedThings) || (!isBuilding && Resources.Mod_ItemTag.Settings.autoTagManufacturedThings))
                    {
                        var qualityComp = thing.TryGetComp<CompQuality>();
                        if (qualityComp != null && Resources.Mod_ItemTag.Settings.autoTagProductQualityRange.Includes(qualityComp.Quality))
                        {
                            var favouriteComp = thing.TryGetComp<Comp_ItemTag>();
                            if (favouriteComp != null)
                                favouriteComp.Favourited = true;
                        }
                    }
                }
            }

        }

    }
}

