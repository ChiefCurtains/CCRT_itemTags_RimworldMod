using RimWorld;
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
            Rect rect = inRect.LeftHalf();
            Rect inRect2 = inRect.RightHalf();
            Rect inRect3 = inRect2.LeftHalf();
            Rect inRect4 = inRect2.RightHalf();
            DrawMainOptions(rect);
            DrawRenameEntry(inRect3);
            DrawRenameButtons(inRect4);
        }
        public void DrawMainOptions(Rect inRect)
        {
            Listing_Standard list = new Listing_Standard();
            list.Begin(inRect);
            list.Label("Visibility Toggle");
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Item Tag Overlay", ref ccrt_enableItemTags, "Disable/Enable Item Tags");
            list.Gap(12f);
            list.Label("Toggle Individual Tags");
            list.GapLine(12f);
            list.CheckboxLabeled("Disable Tag A: \"" + newNameA + "\" Tag", ref ccrt_enableTagA);
            list.CheckboxLabeled("Disable Tag B: \"" + newNameB + "\" Tag", ref ccrt_enableTagB);
            list.CheckboxLabeled("Disable Tag C: \"" + newNameC + "\" Tag", ref ccrt_enableTagC);
            list.CheckboxLabeled("Disable Tag D: \"" + newNameD + "\" Tag", ref ccrt_enableTagD);
            list.CheckboxLabeled("Disable Tag E: \"" + newNameE + "\" Tag", ref ccrt_enableTagE);
            list.CheckboxLabeled("Disable Tag F: \"" + newNameF + "\" Tag", ref ccrt_enableTagF);
            list.CheckboxLabeled("Disable Tag G: \"" + newNameG + "\" Tag", ref ccrt_enableTagG);
            list.CheckboxLabeled("Disable Tag H: \"" + newNameH + "\" Tag", ref ccrt_enableTagH);
            list.CheckboxLabeled("Disable Tag I: \"" + newNameI + "\" Tag", ref ccrt_enableTagI);
            list.CheckboxLabeled("Disable Tag J: \"" + newNameJ + "\" Tag", ref ccrt_enableTagJ);
            list.CheckboxLabeled("Disable Tag K: \"" + newNameK + "\" Tag", ref ccrt_enableTagK);
            list.CheckboxLabeled("Disable Tag L: \"" + newNameL + "\" Tag", ref ccrt_enableTagL);
            list.Gap(12f);
            list.End();
        }
        public void DrawRenameEntry(Rect inRect)
        {
            Listing_Standard list = new Listing_Standard();
            list.Begin(inRect);
            list.Label("Custom Tag Names", -1f, null);
            list.GapLine(12f);
            tmpTagNameA = list.TextEntryLabeled("Tag A", tmpTagNameA, 1);
            tmpTagNameB = list.TextEntryLabeled("Tag B", tmpTagNameB, 1);
            tmpTagNameC = list.TextEntryLabeled("Tag C", tmpTagNameC, 1);
            tmpTagNameD = list.TextEntryLabeled("Tag D", tmpTagNameD, 1);
            tmpTagNameE = list.TextEntryLabeled("Tag E", tmpTagNameE, 1);
            tmpTagNameF = list.TextEntryLabeled("Tag F", tmpTagNameF, 1);
            tmpTagNameG = list.TextEntryLabeled("Tag G", tmpTagNameG, 1);
            tmpTagNameH = list.TextEntryLabeled("Tag H", tmpTagNameH, 1);
            tmpTagNameI = list.TextEntryLabeled("Tag I", tmpTagNameI, 1);
            tmpTagNameJ = list.TextEntryLabeled("Tag J", tmpTagNameJ, 1);
            tmpTagNameK = list.TextEntryLabeled("Tag K", tmpTagNameK, 1);
            tmpTagNameL = list.TextEntryLabeled("Tag L", tmpTagNameL, 1);
            list.End();
        }
        public void DrawRenameButtons(Rect inRect)
        {
            Listing_Standard list = new Listing_Standard();
            list.Begin(inRect);
            list.Label("Confirm", -1f, null);
            list.GapLine(12f);
            if (list.ButtonText("Change Tag A Name", null, 1f))
            {
                newNameA = tmpTagNameA;
            }
            if (list.ButtonText("Change Tag B Name", null, 1f))
            {
                newNameB = tmpTagNameB;
            }
            if (list.ButtonText("Change Tag C Name", null, 1f))
            {
                newNameC = tmpTagNameC;
            }
            if (list.ButtonText("Change Tag D Name", null, 1f))
            {
                newNameD = tmpTagNameD;
            }
            if (list.ButtonText("Change Tag E Name", null, 1f))
            {
                newNameE = tmpTagNameE;
            }
            if (list.ButtonText("Change Tag F Name", null, 1f))
            {
                newNameF = tmpTagNameF;
            }
            if (list.ButtonText("Change Tag G Name", null, 1f))
            {
                newNameG = tmpTagNameG;
            }
            if (list.ButtonText("Change Tag H Name", null, 1f))
            {
                newNameH = tmpTagNameH;
            }
            if (list.ButtonText("Change Tag I Name", null, 1f))
            {
                newNameI = tmpTagNameI;
            }
            if (list.ButtonText("Change Tag J Name", null, 1f))
            {
                newNameJ = tmpTagNameJ;
            }
            if (list.ButtonText("Change Tag K Name", null, 1f))
            {
                newNameK = tmpTagNameK;
            }
            if (list.ButtonText("Change Tag L Name", null, 1f))
            {
                newNameL = tmpTagNameL;
            }
            list.End();
        }

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