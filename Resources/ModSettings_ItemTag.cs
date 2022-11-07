using RimWorld;
using UnityEngine;
using Verse;

namespace CCRT_itemTags
{
    public class ModSettings_ItemTag : ModSettings
    {
        // This bool MUST be true. It is called on severl times to enable the overlay. It is also what it toggled in settings and the overlay button.
        public static bool ccrt_enableItemTags = true;
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
            Scribe_Values.Look(ref newNameA, nameof(curNameA), "A. " + newNameA, true);
            base.ExposeData();
            
        }
        public void DoSettingsWindowContents(Rect canvas)
        {           
            Listing_Standard list = new Listing_Standard();
            list.ColumnWidth = canvas.width;
            list.Begin(canvas);
            list.Label("Custom Tag Names");
            list.GapLine();
            list.CheckboxLabeled("Disable Item Tag Overlay", ref ccrt_enableItemTags, "Disable/Enable Item Tags");
            list.GapLine();
            list.CheckboxLabeled("Disable \"" + newNameA + "\" Tag", ref ccrt_enableTagA);
            list.CheckboxLabeled("Disable \"" + newNameB + "\" Tag", ref ccrt_enableTagB);
            list.CheckboxLabeled("Disable \"" + newNameC + "\" Tag", ref ccrt_enableTagC);
            list.CheckboxLabeled("Disable \"" + newNameD + "\" Tag", ref ccrt_enableTagD);
            list.CheckboxLabeled("Disable \"" + newNameE + "\" Tag", ref ccrt_enableTagE);
            list.CheckboxLabeled("Disable \"" + newNameF + "\" Tag", ref ccrt_enableTagF);
            list.CheckboxLabeled("Disable \"" + newNameG + "\" Tag", ref ccrt_enableTagG);
            list.CheckboxLabeled("Disable \"" + newNameH + "\" Tag", ref ccrt_enableTagH);
            list.CheckboxLabeled("Disable \"" + newNameI + "\" Tag", ref ccrt_enableTagI);
            list.CheckboxLabeled("Disable \"" + newNameJ + "\" Tag", ref ccrt_enableTagJ);
            list.CheckboxLabeled("Disable \"" + newNameK + "\" Tag", ref ccrt_enableTagK);
            list.CheckboxLabeled("Disable \"" + newNameL + "\" Tag", ref ccrt_enableTagL);
            list.GapLine();
            tmpTagNameA = list.TextEntryLabeled("Change Tag A Name", tmpTagNameA, 1);
            string textA = null;
            if (list.ButtonText("Change Tag A Name", null, 1f))
            {
                newNameA = tmpTagNameA;
            }
            tmpTagNameB = list.TextEntryLabeled("Change Tag B Name", tmpTagNameB, 1);
            string textB = null;
            if (list.ButtonText("Change Tag B Name", null, 1f))
            {
                newNameB = tmpTagNameB;
            }
            tmpTagNameC = list.TextEntryLabeled("Change Tag C Name", tmpTagNameC, 1);
            string textC = null;
            if (list.ButtonText("Change Tag C Name", null, 1f))
            {
                newNameC = tmpTagNameC;
            }
            tmpTagNameD = list.TextEntryLabeled("Change Tag D Name", tmpTagNameD, 1);
            string textD = null;
            if (list.ButtonText("Change Tag D Name", null, 1f))
            {
                newNameD = tmpTagNameD;
            }
            tmpTagNameE = list.TextEntryLabeled("Change Tag E Name", tmpTagNameE, 1);
            string textE = null;
            if (list.ButtonText("Change Tag E Name", null, 1f))
            {
                newNameE = tmpTagNameE;
            }
            tmpTagNameF = list.TextEntryLabeled("Change Tag F Name", tmpTagNameF, 1);
            string textF = null;
            if (list.ButtonText("Change Tag F Name", null, 1f))
            {
                newNameF = tmpTagNameF;
            }
            tmpTagNameG = list.TextEntryLabeled("Change Tag G Name", tmpTagNameG, 1);
            string textG = null;
            if (list.ButtonText("Change Tag G Name", null, 1f))
            {
                newNameG = tmpTagNameG;
            }
            tmpTagNameH = list.TextEntryLabeled("Change Tag H Name", tmpTagNameH, 1);
            string textH = null;
            if (list.ButtonText("Change Tag H Name", null, 1f))
            {
                newNameH = tmpTagNameH;
            }
            tmpTagNameI = list.TextEntryLabeled("Change Tag I Name", tmpTagNameI, 1);
            string textI = null;
            if (list.ButtonText("Change Tag I Name", null, 1f))
            {
                newNameI = tmpTagNameI;
            }
            tmpTagNameJ = list.TextEntryLabeled("Change Tag J Name", tmpTagNameJ, 1);
            string textJ = null;
            if (list.ButtonText("Change Tag J Name", null, 1f))
            {
                newNameJ = tmpTagNameJ;
            }
            tmpTagNameK = list.TextEntryLabeled("Change Tag K Name", tmpTagNameK, 1);
            string textK = null;
            if (list.ButtonText("Change Tag K Name", null, 1f))
            {
                newNameK = tmpTagNameK;
            }
            tmpTagNameL = list.TextEntryLabeled("Change Tag L Name", tmpTagNameL, 1);
            string textL = null;
            if (list.ButtonText("Change Tag L Name", null, 1f))
            {
                newNameL = tmpTagNameL;
            }
            list.End();
        }
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