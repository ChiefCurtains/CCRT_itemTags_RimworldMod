using System;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace CCRT_itemTags.TradeUI
{
    public class Patch_TransferableUIUtility
    {
        [HarmonyPatch(typeof(TransferableUIUtility))]
        [HarmonyPatch(nameof(TransferableUIUtility.DoExtraIcons))]
        public static class Patch_TransferableUIUtility_DoExtraIcons
        {
            public static void Postfix(Transferable trad, Rect rect, ref float curX)
            {
                var iconRect = new Rect(curX - 24, (rect.height - 24) / 2, 24, 24);
                ThingWithComps thing = trad.AnyThing as ThingWithComps;
                if (thing != null)
                {
                    Comp_ItemTag compTagged = thing.TryGetComp<Comp_ItemTag>();
                    if (compTagged != null)
                    {
                        bool tagTrade = compTagged.CCRT_TagItemM;

                        if (tagTrade)
                        {
                            GUI.DrawTexture(iconRect, TexCommand_ItemTag.ccrt_iconTex);
                        }
                        return;
                    }
                }
            }
        }
    }
}

