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
        public static string curNameA;
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
            Scribe_Values.Look(ref curNameA, nameof(curNameA), "A. " + curNameA);
            base.ExposeData();
            
        }
        public void DoSettingsWindowContents(Rect canvas)
        {
            //adding my save settings window with a single button. ha
            
            Listing_Standard list = new Listing_Standard();
            list.ColumnWidth = canvas.width;
            list.Begin(canvas);
            list.Label("Custom Tag Names");
            list.GapLine();
            list.CheckboxLabeled("Disable Item Tag Overlay", ref ccrt_enableItemTags, "Disable/Enable Item Tags");
            list.GapLine();
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagA".Translate() + "\" Tag", ref ccrt_enableTagA);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagB".Translate() + "\" Tag", ref ccrt_enableTagB);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagC".Translate() + "\" Tag", ref ccrt_enableTagC);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagD".Translate() + "\" Tag", ref ccrt_enableTagD);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagE".Translate() + "\" Tag", ref ccrt_enableTagE);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagF".Translate() + "\" Tag", ref ccrt_enableTagF);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagG".Translate() + "\" Tag", ref ccrt_enableTagG);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagH".Translate() + "\" Tag", ref ccrt_enableTagH);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagI".Translate() + "\" Tag", ref ccrt_enableTagI);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagJ".Translate() + "\" Tag", ref ccrt_enableTagJ);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagK".Translate() + "\" Tag", ref ccrt_enableTagK);
            list.CheckboxLabeled("Disable \"" + "CCRT_itemTags.TagL".Translate() + "\" Tag", ref ccrt_enableTagL);
            list.GapLine();
            //string flagA = list.TextEntry(curNameA);
            //if (list.ButtonText("Change Tag A Name", null, 1f))
            //{
            //    if (flagA != null)
            //    {
            //        curNameA = "A. " + flagA;
            //    }
            //}
            list.SubLabel("As of this version, Tag Names can be modified in \\Steam\\steamapps\\workshop\\content\\294100\\2879583413\\1.4\\Languages\\English\\Keys", 20f);
            list.SubLabel("As of this version, Tag Filters can be modified in \\Steam\\steamapps\\workshop\\content\\294100\\2879583413\\1.4\\Languages\\English\\DefInjected\\SpecialThingFilterDef", 20f);
            list.End();
        }
        //I am going to look at TacticalGroups.Dialog_RenameColonistGroup for reference.
        public class Dialog_RenameTagA : Dialog_Rename
        {
            public Dialog_RenameTagA()
            {
                curName = tagAName.nameTagA;
            }
            protected override AcceptanceReport NameIsValid(string name)
            {
                return true;
            }
            protected override void SetName(string name)
            {
                tagAName.SetName(name);
            }
            public TagAName tagAName; 
        }
    }
    //leaving it here for now. So far, I can follow the trail from Dialog_RenameColonistGroup to TieredFloatMenu to ColonistGroup : IExposable
}