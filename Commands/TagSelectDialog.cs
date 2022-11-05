using System;
using UnityEngine;
using Verse;

namespace CCRT_itemTags.Commands
{
    public
    public class TagSelectDialog : Window
    {
        public override Vector2 InitialSize
        {
            get
            {
                return new Vector2(416f, 292f);
            }
        }
        public TagSelectDialog(int numTag)
        {   
            forcePause = true;
            doCloseX = true;
            absorbInputAroundWindow = true;
            closeOnClickedOutside = true;
        }
        public override void DoWindowContents(Rect inRect)
        {
            bool flag = Widgets.ButtonImage(new Rect(0f, 0f, 256f, 256f), TexCommand_CCRT.ccrt_iconTex, ColorReference_CCRT.colYellowGold);
            if (flag)
            {
                ToggleCommandA.
            }
        }
    }

}
