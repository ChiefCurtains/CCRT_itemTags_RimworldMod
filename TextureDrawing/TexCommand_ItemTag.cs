using UnityEngine;
using Verse;

namespace CCRT_itemTags
{
    [StaticConstructorOnStartup]
    public static class TexCommand_ItemTag
    {
        //main reference for all textures. One texture with multiple colors sourced from ColorReference.
        public static readonly Texture2D ccrt_iconTagsButtonUI = ContentFinder<Texture2D>.Get("UI/Buttons/CCRT_iconTagsButtonUI");
        public static readonly Texture2D ccrt_iconTex = ContentFinder<Texture2D>.Get("UI/Designators/CCRT_iconTag");
        public static readonly Texture2D ccrt_iconTexTrade = ContentFinder<Texture2D>.Get("UI/Designators/CCRT_iconTrade");
        public static readonly Texture2D ccrt_iconReset = ContentFinder<Texture2D>.Get("UI/Designators/CCRT_iconResetTag");
        public static readonly Texture2D ccrt_showTaggedOverlay = ContentFinder<Texture2D>.Get("UI/Buttons/CCRT_iconShowTaggedOverlay");
    }
}
