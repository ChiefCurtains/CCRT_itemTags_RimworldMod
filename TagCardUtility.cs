using RimWorld;
using System.Text.RegularExpressions;
using Verse;
using UnityEngine;

namespace CCRT_itemTags
{
    public abstract class TagCardDialog : Window
    {
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
        public TagCardDialog()
        {
            forcePause = true;
            doCloseX = true;
            absorbInputAroundWindow = true;
            closeOnAccept = false;
            closeOnClickedOutside = true;
        }
        //public static void DoTagNameInputRect(Rect rect, ref string tagName, int maxLength)
        //{
        //    string text = Widgets.TextField(rect, tagName);
        //    if (text.Length <= maxLength && ValidNameRegex.IsMatch(text))
        //    {
        //        tagName = text;
        //    }
        //}

        protected virtual AcceptanceReport NameIsValid(string name)
        {
            if (name.Length == 0)
            {
                return false;
            }
            return true;
        }

        //public static void DrawTagCard(Rect rect, ItemTag tagName)
        //{
        //    string tagCommonName = tagName.TagName;
        //    TagCardUtility.DoTagNameInputRect(rect, ref tagCommonName, 12);
        //}

        public void WasOpenedByHotkey()
        {
            startAcceptingInputAtFrame = Time.frameCount + 1;
        }

        public override void DoWindowContents(Rect inRect)
        {
            Text.Font = GameFont.Small;
            bool flag = false;
            if (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return)
            {
                flag = true;
                Event.current.Use();
            }
            GUI.SetNextControlName("RenameTag");
            string text = Widgets.TextField(new Rect(0f, 15f, inRect.width, 35f), curName);
            if (AcceptsInput && text.Length < MaxNameLength)
            {
                curName = text;
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
                AcceptanceReport acceptanceReport = NameIsValid(curName);
                if (!acceptanceReport.Accepted)
                {
                    if (acceptanceReport.Reason.NullOrEmpty())
                    {
                        Messages.Message("NameIsInvalid".Translate(), MessageTypeDefOf.RejectInput, false);
                        return;
                    }
                    Messages.Message(acceptanceReport.Reason, MessageTypeDefOf.RejectInput, false);
                    return;
                }
                else
                {
                    SetName(curName);
                    Find.WindowStack.TryRemove(this, true);
                }
            }

        }
        protected abstract void SetName(string name);
        protected string curName;
        private int startAcceptingInputAtFrame;
        public static Regex ValidNameRegex = new Regex("^[\\p{L}0-9 '\\-.]*$");
        private bool focusedRenameField;
    }
}
