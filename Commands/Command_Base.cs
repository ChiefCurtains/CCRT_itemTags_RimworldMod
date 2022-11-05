using CCRT_itemTags;
using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using Color = UnityEngine.Color;

namespace CCRT_itemTags
{    
    public class ToggleCommandA : Command_Toggle
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_CCRT.ccrt_enableTagA && CompItemTags_CCRT.allowedTagsToggleVisible)
                {
                    return true;
                }
                return false;

            }

        }
        public ToggleCommandA(CompItemTags_CCRT t)
        {
            defaultLabel = "CCRT_itemTags.TagA".Translate();
            defaultDesc = "TempDesc";
            icon = TexCommand_CCRT.ccrt_iconTex;
            defaultIconColor = ColorReference_CCRT.colYellowGold;
            isActive = (() => t.CCRT_TagItemA);
            toggleAction = delegate ()
            {
                t.CCRT_TagItemA = !t.CCRT_TagItemA;
            };
        }
    }
}



//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagC)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colLightRed,
//        toggleAction = () => CCRT_TagItemC = !CCRT_TagItemC,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}
//if (allowedTagsToggleVisible && ModSettings_CCRT.ccrt_enableTagB)
//{
//    yield return new Command_Toggle
//    {
//        defaultLabel = "CCRT_itemTags.TagA".Translate(),
//        defaultDesc = "TempDesc",
//        icon = TexCommand_CCRT.ccrt_iconTex,
//        defaultIconColor = ColorReference_CCRT.colYellowGold,
//        toggleAction = () => CCRT_TagItemA = !CCRT_TagItemA,
//    };
//}