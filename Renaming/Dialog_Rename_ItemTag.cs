using System;
using Verse;
using UnityEngine;
using RimWorld;
using System.Xml.Linq;
using CCRT_itemTags.Renaming;

namespace CCRT_itemTags
{
    // Reference TacticalGroups.Dialog_RenameColonistGroup
    public class Dialog_Rename_ItemTag : Dialog_Rename
    {
        public ExItemTag exItemTag;
        private bool AcceptsInput
        {
            get
            {
                return startAcceptingInputAtFrame <= Time.frameCount;
            }
        }
        private static float ButtonWidth(float textWidth)
        {
            return Math.Max(114f, textWidth + 35f);
        }
        public Dialog_Rename_ItemTag(ExItemTag exItemTag, string initialTagNameOverride = null)
        {
            this.exItemTag = exItemTag;
            //line 72 of Vanilla verse.Dialog_NamePawn.Dialog_NamePawn possible need context?
            forcePause = true;
            doCloseX = true;
            absorbInputAroundWindow = true;
            closeOnAccept = true;
            closeOnClickedOutside = true;
            confBtnTxt = "Accept";
            confBtnWidth = Dialog_Rename_ItemTag.ButtonWidth(confBtnTxt.GetWidthCached());
            size = new Vector2(size.x, size.y);          
        }

        public override void DoWindowContents(Rect inRect) //line 70 (curName = curTagName)
        {
            Text.Font = GameFont.Small;
            bool flag = false;
            if (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return)
            {
                //enter key pressed
                flag = true;
                Event.current.Use();
            }
            GUI.SetNextControlName("RenameField");
            string text = Widgets.TextField(new Rect(19f, 36f, inRect.width - 40f, 35f), curTagName);
            if (AcceptsInput && text.Length < MaxNameLength)
            {
                //changing curTagName ======================
                curTagName = text;
            }
            else if (!AcceptsInput)
            {
                ((TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), GUIUtility.keyboardControl)).SelectAll();
            }
            if (!focusedRenameField)
            {
                UI.FocusControl("RenameField", this);
                focusedRenameField = true;
            }
            if (Widgets.ButtonText(new Rect(15f, inRect.height - 35f - 15f, inRect.width - 15f - 15f, 35f), acceptText, true, true, true, null) || flag)
            {
                AcceptanceReport acceptanceReport = NameIsValid(curTagName);
                if (acceptanceReport.Accepted)
                {
                    SetName(curTagName);
                    Find.WindowStack.TryRemove(this, true);
                    return;
                }
                if (acceptanceReport.Reason.NullOrEmpty())
                {
                    Messages.Message("NameIsInvalid".Translate(), MessageTypeDefOf.RejectInput, false);
                    return;
                }
                Messages.Message(acceptanceReport.Reason, MessageTypeDefOf.RejectInput, false);
            }
        }
        protected override void SetName(string name)
        {
            curTagName = name;
        }




        protected string curTagName;
        private bool focusedRenameField;
        private int startAcceptingInputAtFrame;
        protected string confirmationText;
        private float confBtnWidth;
        private string confBtnTxt;
        private Vector2 size = new Vector2(800f, 800f);
        private const float ButtonHeight = 35f;
        private TaggedString cancelText = "Cancel";
        private TaggedString acceptText = "Accept";
        private const int ContextHash = 136098329;
        private string currentControl;
        private string focusControlOverride;
        private const float HorizontalMargin = 17f;
        private const float VerticalMargin = 4f;
        private const float NameFieldsHeight = 30f;
        private float? renameHeight;
        private TaggedString renameText;
        //private ExItemTag exItemTag;
    }
}
