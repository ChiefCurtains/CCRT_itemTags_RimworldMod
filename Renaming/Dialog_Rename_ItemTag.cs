using System;
using Verse;
using UnityEngine;
using RimWorld;
using System.Xml.Linq;
using CCRT_itemTags.Renaming;

namespace CCRT_itemTags
{
    // Reference TacticalGroups.Dialog_RenameColonistGroup
    public abstract class Dialog_Rename_ItemTag : Window
    {
        public IExposable_ItemTag exItemTag;
        private bool AcceptsInput
        {
            get
            {
                return startAcceptingInputAtFrame <= Time.frameCount;
            }
        }
        protected virtual int MaxNameLength
        {
            get
            {
                return 28;
            }
        }
        public override Vector2 InitialSize
        {
            get
            {
                return new Vector2(280f, 175f);
            }
        }

        public Dialog_Rename_ItemTag(IExposable_ItemTag exItemTag,  Rect originRect, string confirmationText)
        {
            forcePause = true;
            doCloseX = true;
            absorbInputAroundWindow = true;
            closeOnAccept = true;
            closeOnClickedOutside = true;
        }
        public void WasOpenedByHotkey()
        {
            startAcceptingInputAtFrame = Time.frameCount + 1;
        }
        protected virtual AcceptanceReport NameIsValid(string name)
        {
            if (name.Length == 0)
            {
                return false;
            }
            return true;
        }

        public override void DoWindowContents(Rect inRect) //line 70 (curName = curTagName)
        {
            Text.Font = GameFont.Small;
            bool flag = false;
            if (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return)
            {
                flag = true;
                Event.current.Use();
            }
            GUI.SetNextControlName("RenameField");
            string text = Widgets.TextField(new Rect(19f, 36f, inRect.width - 40f, 35f), curTagName);
            if (AcceptsInput && text.Length < MaxNameLength)
            {
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
            if (Widgets.ButtonText(new Rect(15f, inRect.height - 35f - 15f, inRect.width - 15f - 15f, 35f), "OK", true, true, true, null) || flag)
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
        protected abstract void SetName(string name);
        protected string curTagName;
        private bool focusedRenameField;
        private int startAcceptingInputAtFrame;
        protected string confirmationText;
    }
}
