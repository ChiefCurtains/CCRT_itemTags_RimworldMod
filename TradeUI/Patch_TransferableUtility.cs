using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace CCRT_itemTags.TradeUI
{
    public static class Patch_TransferableUtility
    {
        [HarmonyPatch(typeof(TransferableUtility))]
        [HarmonyPatch(nameof(TransferableUtility.TransferAsOne))]
        public static class Patch_TransferableUtility_TransferAsOne
        {
            public static void Postfix(ref bool __result, Thing a, Thing b)
            {
                var tagCompA = a.TryGetComp<Comp_ItemTag>();
                var tagCompB = b.TryGetComp<Comp_ItemTag>();
                if (tagCompA != null && tagCompB != null)
                {
                    bool taggedTrade1 = tagCompA.CCRT_TagItemTrade;
                    bool taggedTrade2 = tagCompB.CCRT_TagItemTrade;
                    if (taggedTrade1 != taggedTrade2)
                    {
                        __result = false;
                        return;
                    }
                }
            }
        }
    }
}

