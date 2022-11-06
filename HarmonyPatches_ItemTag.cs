using HarmonyLib;
using RimWorld;
using Verse;

namespace CCRT_itemTags
{
    [StaticConstructorOnStartup]

    //Setting up the harmony instance
    public static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            //Tels the startup pacth to run anthing in the Solution starting with [HarmonyPatch(typeof(""))]
            CCRT_itemTagsMod.harmonyInstance.PatchAll();
        }

    }
    [HarmonyPatch(typeof(ThingFilter))]
    [HarmonyPatch(nameof(ThingFilter.SetFromPreset))]

    /*
    Patching Stockpiles allowing all tags by default. 
    Make sure that the SpecialThingFilter XML includes the line "<allowedByDefault>true</allowedByDefault>" for EACH tag type.
    This will prevent the game from treating Chunks and other things that are "Things" and not "ThingsWithComps" as excluded from all filters. 
    That causes a lot of issues with recipes using chunks, etc
    */
    class Patch_ThingFilter_SetFromPreset
    {
        public static SpecialThingFilterDef AllowTaggedADef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagA");
        public static SpecialThingFilterDef AllowTaggedBDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagB");
        public static SpecialThingFilterDef AllowTaggedCDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagC");
        public static SpecialThingFilterDef AllowTaggedDDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagD");
        public static SpecialThingFilterDef AllowTaggedEDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagE");
        public static SpecialThingFilterDef AllowTaggedFDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagF");
        public static SpecialThingFilterDef AllowTaggedGDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagG");
        public static SpecialThingFilterDef AllowTaggedHDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagH");
        public static SpecialThingFilterDef AllowTaggedIDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagI");
        public static SpecialThingFilterDef AllowTaggedJDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagJ");
        public static SpecialThingFilterDef AllowTaggedKDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagK");
        public static SpecialThingFilterDef AllowTaggedLDef = DefDatabase<SpecialThingFilterDef>.GetNamed("CCRT_itemTags_AllowItemTagL");

        public static void Prefix(ThingFilter __instance)
        {
            //New stockpiles default to not allow tagged.
            __instance.SetAllow(AllowTaggedADef, allow: false);
            __instance.SetAllow(AllowTaggedBDef, allow: false);
            __instance.SetAllow(AllowTaggedCDef, allow: false);
            __instance.SetAllow(AllowTaggedDDef, allow: false);
            __instance.SetAllow(AllowTaggedEDef, allow: false);
            __instance.SetAllow(AllowTaggedFDef, allow: false);
            __instance.SetAllow(AllowTaggedGDef, allow: false);
            __instance.SetAllow(AllowTaggedHDef, allow: false);
            __instance.SetAllow(AllowTaggedIDef, allow: false);
            __instance.SetAllow(AllowTaggedJDef, allow: false);
            __instance.SetAllow(AllowTaggedKDef, allow: false);
            __instance.SetAllow(AllowTaggedLDef, allow: false);
        }
    }

    [HarmonyPatch(typeof(PlaySettings))]
    [HarmonyPatch("ExposeData")]
    public static class Patch_ExposeData
    {
        public static void Postfix()
        {
            Scribe_Values.Look<bool>(ref ModSettings_ItemTag.ccrt_enableItemTags, "ccrt_enableItemTags", true, false);
        }
    }
    [HarmonyPatch(typeof(PlaySettings))]
    [HarmonyPatch("DoPlaySettingsGlobalControls")]
    //Adding the toggle icon to the lower right. Toggle icon calls on the above ExposeData patch.
    public static class Patch_DoPlaySettingsGlobalControls
    {
        public static void Postfix(ref WidgetRow row, bool worldView)
        {
            if (!worldView)
            {
                row.ToggleableIcon(ref ModSettings_ItemTag.ccrt_enableItemTags, TexCommand_ItemTag.ccrt_showTaggedOverlay, "Toggle Tagged Overlay", null, null);
            }
        }
    }
}
