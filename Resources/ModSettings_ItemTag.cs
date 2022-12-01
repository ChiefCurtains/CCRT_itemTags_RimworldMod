using UnityEngine;
using Verse;

namespace CCRT_itemTags
{
    public class ModSettings_ItemTag : ModSettings
    {
        // This bool MUST be true. It is called on severl times to enable the overlay. It is also what it toggled in settings and the overlay button.
        public static bool ccrt_enableItemTags = true;
        public static bool ccrt_enableTag = true;
        public static bool ccrt_enableTagA = true;
        public static bool ccrt_enableTagB = true;
        public static bool ccrt_enableTagC = true;
        public static bool ccrt_enableTagD = true;
        public static bool ccrt_enableTagE = true;
        public static bool ccrt_enableTagF = true;
        public static bool ccrt_enableTagG = true;
        public static bool ccrt_enableTagH = true;
        public static bool ccrt_enableTagI = true;
        public static bool ccrt_enableTagJ = true;
        public static bool ccrt_enableTagK = true;
        public static bool ccrt_enableTagL = true;
        public static bool ccrt_enableTagM = true;
        public static string curNameA = "curNameA";
        public static string curNameB = "curNameB";
        public static string curNameC = "curNameC";
        public static string curNameD = "curNameD";
        public static string curNameE = "curNameE";
        public static string curNameF = "curNameF";
        public static string curNameG = "curNameG";
        public static string curNameH = "curNameH";
        public static string curNameI = "curNameI";
        public static string curNameJ = "curNameJ";
        public static string curNameK = "curNameK";
        public static string curNameL = "curNameL";
        public static string newNameA;
        public static string newNameB;
        public static string newNameC;
        public static string newNameD;
        public static string newNameE;
        public static string newNameF;
        public static string newNameG;
        public static string newNameH;
        public static string newNameI;
        public static string newNameJ;
        public static string newNameK;
        public static string newNameL;
        public override void ExposeData()
        {
            //scribing the setting to the save file so it persists after reloading the save.
            Scribe_Values.Look(ref ccrt_enableItemTags, nameof(ccrt_enableItemTags), true);
            Scribe_Values.Look(ref ccrt_enableTagA, nameof(ccrt_enableTagA), true);
            Scribe_Values.Look(ref ccrt_enableTagB, nameof(ccrt_enableTagB), true);
            Scribe_Values.Look(ref ccrt_enableTagC, nameof(ccrt_enableTagC), true);
            Scribe_Values.Look(ref ccrt_enableTagD, nameof(ccrt_enableTagD), true);
            Scribe_Values.Look(ref ccrt_enableTagE, nameof(ccrt_enableTagE), true);
            Scribe_Values.Look(ref ccrt_enableTagF, nameof(ccrt_enableTagF), true);
            Scribe_Values.Look(ref ccrt_enableTagG, nameof(ccrt_enableTagG), true);
            Scribe_Values.Look(ref ccrt_enableTagH, nameof(ccrt_enableTagH), true);
            Scribe_Values.Look(ref ccrt_enableTagI, nameof(ccrt_enableTagI), true);
            Scribe_Values.Look(ref ccrt_enableTagJ, nameof(ccrt_enableTagJ), true);
            Scribe_Values.Look(ref ccrt_enableTagK, nameof(ccrt_enableTagK), true);
            Scribe_Values.Look(ref ccrt_enableTagL, nameof(ccrt_enableTagL), true);
            Scribe_Values.Look(ref ccrt_enableTagM, nameof(ccrt_enableTagM), true);
            Scribe_Values.Look(ref newNameA, nameof(curNameA), newNameA, true);
            Scribe_Values.Look(ref newNameB, nameof(curNameB), newNameB, true);
            Scribe_Values.Look(ref newNameC, nameof(curNameC), newNameC, true);
            Scribe_Values.Look(ref newNameD, nameof(curNameD), newNameD, true);
            Scribe_Values.Look(ref newNameE, nameof(curNameE), newNameE, true);
            Scribe_Values.Look(ref newNameF, nameof(curNameF), newNameF, true);
            Scribe_Values.Look(ref newNameG, nameof(curNameG), newNameG, true);
            Scribe_Values.Look(ref newNameH, nameof(curNameH), newNameH, true);
            Scribe_Values.Look(ref newNameI, nameof(curNameI), newNameI, true);
            Scribe_Values.Look(ref newNameJ, nameof(curNameJ), newNameJ, true);
            Scribe_Values.Look(ref newNameK, nameof(curNameK), newNameK, true);
            Scribe_Values.Look(ref newNameL, nameof(curNameL), newNameL, true);
            base.ExposeData();

        }
        public void DoWindowContents(Rect inRect)
        {
            Listing_Standard list = new Listing_Standard();
            Rect rect = new Rect(0f, 0f, inRect.width, 1200f);
            rect.xMax *= 0.8f;
            list.Begin(rect);
            GUI.EndGroup();
            Widgets.BeginScrollView(inRect, ref ScrollPos, rect, true);
            list.Label("Visibility Toggle");
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Item Tag Overlay", ref ccrt_enableItemTags, "Disable/Enable Item Tags");
            list.CheckboxLabeled("Disable Trade Tag", ref ccrt_enableTagM, "Disable/Enable Trade Tag");
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag A: \"" + newNameA + "\" Tag", ref ccrt_enableTagA);
            tmpTagNameA = list.TextEntryLabeled("Tag A:         \"" + newNameA + "\" : ", tmpTagNameA, 1);
            if (list.ButtonText("Change Tag A Name", null, 1f))
            {
                newNameA = tmpTagNameA;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag B: \"" + newNameB + "\" Tag", ref ccrt_enableTagB);
            tmpTagNameB = list.TextEntryLabeled("Tag B:         \"" + newNameB + "\" : ", tmpTagNameB, 1);
            if (list.ButtonText("Change Tag B Name", null, 1f))
            {
                newNameB = tmpTagNameB;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag C: \"" + newNameC + "\" Tag", ref ccrt_enableTagC);
            tmpTagNameC = list.TextEntryLabeled("Tag C:         \"" + newNameC + "\" : ", tmpTagNameC, 1);
            if (list.ButtonText("Change Tag C Name", null, 1f))
            {
                newNameC = tmpTagNameC;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag D: \"" + newNameD + "\" Tag", ref ccrt_enableTagD);
            tmpTagNameD = list.TextEntryLabeled("Tag D:         \"" + newNameD + "\" : ", tmpTagNameD, 1);
            if (list.ButtonText("Change Tag D Name", null, 1f))
            {
                newNameD = tmpTagNameD;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag E: \"" + newNameE + "\" Tag", ref ccrt_enableTagE);
            tmpTagNameE = list.TextEntryLabeled("Tag E:         \"" + newNameE + "\" : ", tmpTagNameE, 1);
            if (list.ButtonText("Change Tag E Name", null, 1f))
            {
                newNameE = tmpTagNameE;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag F: \"" + newNameF + "\" Tag", ref ccrt_enableTagF);
            tmpTagNameF = list.TextEntryLabeled("Tag F:         \"" + newNameF + "\" : ", tmpTagNameF, 1);
            if (list.ButtonText("Change Tag F Name", null, 1f))
            {
                newNameF = tmpTagNameF;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag G: \"" + newNameG + "\" Tag", ref ccrt_enableTagG);
            tmpTagNameG = list.TextEntryLabeled("Tag G:         \"" + newNameG + "\" : ", tmpTagNameG, 1);
            if (list.ButtonText("Change Tag G Name", null, 1f))
            {
                newNameG = tmpTagNameG;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag H: \"" + newNameH + "\" Tag", ref ccrt_enableTagH);
            tmpTagNameH = list.TextEntryLabeled("Tag H:         \"" + newNameH + "\" : ", tmpTagNameH, 1);
            if (list.ButtonText("Change Tag H Name", null, 1f))
            {
                newNameH = tmpTagNameH;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag I: \"" + newNameI + "\" Tag", ref ccrt_enableTagI);
            tmpTagNameI = list.TextEntryLabeled("Tag I:         \"" + newNameI + "\" : ", tmpTagNameI, 1);
            if (list.ButtonText("Change Tag I Name", null, 1f))
            {
                newNameI = tmpTagNameI;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag J: \"" + newNameJ + "\" Tag", ref ccrt_enableTagJ);
            tmpTagNameJ = list.TextEntryLabeled("Tag J:         \"" + newNameJ + "\" : ", tmpTagNameJ, 1);
            if (list.ButtonText("Change Tag J Name", null, 1f))
            {
                newNameJ = tmpTagNameJ;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag K: \"" + newNameK + "\" Tag", ref ccrt_enableTagK);
            tmpTagNameK = list.TextEntryLabeled("Tag K:         \"" + newNameK + "\" : ", tmpTagNameK, 1);
            if (list.ButtonText("Change Tag K Name", null, 1f))
            {
                newNameK = tmpTagNameK;
            }
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag L: \"" + newNameL + "\" Tag", ref ccrt_enableTagL);
            tmpTagNameL = list.TextEntryLabeled("Tag L:         \"" + newNameL + "\" : ", tmpTagNameL, 1);
            if (list.ButtonText("Change Tag L Name", null, 1f))
            {
                newNameL = tmpTagNameL;
            }
            Widgets.EndScrollView();
        }

        private static Vector2 ScrollPos = Vector2.zero;
        private static float gap = 12f;
        private static float lineGap = 3f;
        public static float Gap { get => gap; set => gap = value; }
        public static float LineGap { get => lineGap; set => lineGap = value; }
        private string tmpTagNameA;
        private string tmpTagNameB;
        private string tmpTagNameC;
        private string tmpTagNameD;
        private string tmpTagNameE;
        private string tmpTagNameF;
        private string tmpTagNameG;
        private string tmpTagNameH;
        private string tmpTagNameI;
        private string tmpTagNameJ;
        private string tmpTagNameK;
        private string tmpTagNameL;
    }
}