using System;
using System.Collections.Generic;
using System.Linq;
using RimWorld;
using Verse;
using UnityEngine;
using Verse.Sound;

namespace CCRT_itemTags
{
    public class Dialog_TagName : Window
    {
        public override Vector2 InitialSize
        {
            get
            {
                return size;
            }
        }
        public Dialog_TagName (CompItemTags_CCRT tags, string initialTagNameOverride = null)
        {
            if (tags.CCRT_TagItemA)
            {
                initialTagNameOverride = "Tag A";
            }
            descriptionText = "Rename Tag A";
            renameText = "New Tag A Name";
            absorbInputAroundWindow = true;
            closeOnClickedOutside = true;
            closeOnAccept = true;
            forcePause = true;            
        }
        public override void DoWindowContents(Rect inRect)
        {
            currentControl = GUI.tooltip;
            image = TexCommand_CCRT.ccrt_iconTex;
        }







        private List<Dialog_TagName.TagNameContext> tagNames = new List<Dialog_TagName.TagNameContext>(4);
        private const float TagIconSize = 128f;
        private const float HorizontalMargin = 17f;
        private const float VerticalMargin = 4f;
        private const float NameFieldsHeight = 30f;
        private const float ButtonHeight = 35f;
        private TaggedString renameText;
        private TaggedString acceptText = "Accept".Translate().CapitalizeFirst();
        private TaggedString cancelText = "Cancel".Translate().CapitalizeFirst();
        private float? renameHeight;
        private float? descriptionHeight;
        private TaggedString descriptionText;
        private string currentControl;
        private string focusControlOverride;
        private Vector2 size = new Vector2(800f, 800f);
        private CompItemTags_CCRT tag;
        private const int ContextHash = 136098329;



    }
}
