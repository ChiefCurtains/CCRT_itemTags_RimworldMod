using HarmonyLib;
using RimWorld;
using UnityEngine;
using System.Collections.Generic;
using Verse;
using Verse.AI.Group;
using System.Linq;

namespace CCRT_itemTags.Harmony
{
    public static class HarmonyPatch_Pawn
    {
        [HarmonyPatch(typeof(Pawn))]
        [HarmonyPatch(nameof(Pawn.GetGizmos))]
        public static class Patch_GetGizmos
        {
            public static void Postfix(Pawn __instance, ref IEnumerable<Gizmo> __result)
            {
                var lord = __instance.GetLord();
                LordJob_Ritual ritual;

                // Show favourite button on non player pawns and animals too, or pawns doing rituals where drafting is blocked
                if (!__instance.IsColonistPlayerControlled || (lord != null && (ritual = lord.LordJob as LordJob_Ritual) != null) && ritual.BlocksDrafting)
                {
                    var resultList = __result.ToList();

                    var taggedComp = __instance.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                    {
                        var compGizmos = taggedComp.CompGetGizmosExtra();
                        foreach (var gizmo in compGizmos)
                        {
                            resultList.Add(gizmo);
                        }
                    }
                    __result = resultList;
                }
            }
        }
    }
}

