using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using Color = UnityEngine.Color;

namespace CCRT_itemTags
{
    public class CCRT_itemTagsMod : Mod
    {
        //Telling the game that this is a Mod and here is where to locate settings and harmony patches.
        public static ModSettings_ItemTag Settings;
        public static Harmony harmonyInstance;
        public override string SettingsCategory()
        {
            return "Class Specific Item Tags";
        }
        public CCRT_itemTagsMod(ModContentPack content) : base(content)
        {
            //Building Settings in Mod Settings Menu
            Settings = GetSettings<ModSettings_ItemTag>();
            //Starting Harmony Instance
            harmonyInstance = new Harmony("ChiefCurtains.itemTags");
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Settings.DoSettingsWindowContents(inRect);
        }

    }
    /* 
    First of all, thank you XeoNovaDan for sharing your source online! It was immensely helpful in writing this mod and I definitely... borrowed... a significant amount of your code.
    This is my very first attempt at writing anything in C# and I know for a fact that I would not have been able to do it without heavily referencing your work!
    I might be able to use this for something "throw new NotImplementedException($"Tried to draw trade icon for {trad} but {thing} not Tagged");"

    vvv FOR THOSE WHO WISH TO MODIFY ANYTHING  vvv

    I use the "ccrt_" (simplified Chief_Curtains) prefix to define which part of my code is touching the save file.
    If you decide to add new tags or heavily modify any tags here, make your own short form prefix so that debugging can be simpler.
    Also, if I decide to make any updates to the mod or add new tags, I will used the prefix "ccrt_XXXXX". If you do the same, there will be a conflict when I push a new build out.
    */

    //This section is referred to any time the code calls for "TryGetComp" as everthing listed here is a ThingWithComps
    public class Comp_ItemTag : ThingComp
    {
        public override IEnumerable<Gizmo> CompGetGizmosExtra()
        {
            /*Tag button which is seen on the UI. Can be changed to any desired trexture by replacing \Textures\UI\Buttons
            I wanted this to be a toggle with a confirmation check box but the option became messy and would result in tagged things having an X. 
            I don't feel like fixing that so your confirmation is the icon on the entity itself.*/
            yield return new Command_Toggle
            {
                defaultLabel = "Tag This",
                defaultDesc = "Click to tag this item as Item A. Right Click for more Tags.",
                icon = TexCommand_ItemTag.ccrt_iconTagsButtonUI,
                // White color for anyone who creates texture patches.
                defaultIconColor = Color.white,
                toggleAction = delegate ()
                {
                    allowedTagsToggleVisible = !allowedTagsToggleVisible;
                },
                isActive = (() => allowedTagsToggleVisible),
            };
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagA)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemA),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemA = !CCRT_TagItemA;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colYellowGold,
                    defaultLabel = ModSettings_ItemTag.curNameA,
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagB)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemB),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemB = !CCRT_TagItemB;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colOrange,
                    defaultLabel = "CCRT_itemTags.TagB".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagC)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemC),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemC = !CCRT_TagItemC;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colLightRed,
                    defaultLabel = "CCRT_itemTags.TagC".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagD)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemD),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemD = !CCRT_TagItemD;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colLightGreen,
                    defaultLabel = "CCRT_itemTags.TagD".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagE)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemE),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemE = !CCRT_TagItemE;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colOlive,
                    defaultLabel = "CCRT_itemTags.TagE".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagF)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemF),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemF = !CCRT_TagItemF;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colDarkOlive,
                    defaultLabel = "CCRT_itemTags.TagF".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagG)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemG),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemG = !CCRT_TagItemG;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colTurquoise,
                    defaultLabel = "CCRT_itemTags.TagG".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagH)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemH),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemH = !CCRT_TagItemH;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colSkyBlue,
                    defaultLabel = "CCRT_itemTags.TagH".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagI)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemI),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemI = !CCRT_TagItemI;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colDarkBlue,
                    defaultLabel = "CCRT_itemTags.TagI".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagJ)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemJ),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemJ = !CCRT_TagItemJ;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colLightPurple,
                    defaultLabel = "CCRT_itemTags.TagJ".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagK)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemK),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemK = !CCRT_TagItemK;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colPurple,
                    defaultLabel = "CCRT_itemTags.TagK".Translate(),
                };
            }
            if (allowedTagsToggleVisible && ModSettings_ItemTag.ccrt_enableTagL)
            {
                yield return new Command_Toggle
                {
                    isActive = (() => CCRT_TagItemL),
                    toggleAction = delegate ()
                    {
                        CCRT_TagItemL = !CCRT_TagItemL;
                    },
                    icon = TexCommand_ItemTag.ccrt_iconTex,
                    defaultIconColor = Reference_Color_ItemTag.colDarkPurple,
                    defaultLabel = "CCRT_itemTags.TagL".Translate(),
                };
            }

        }
        /*
        All tags which are scribed onto the save file are proceeded with "ccrt_" in order to facilitate debugging, save cleaning, and error reporting. 
        This is the only section that touches the save file.
        A tag which will appear as <ccrt_******tag> </ccrt_******tag> will be appended at the end of the tagged entity. 
        This placement will be effected by mod load order but is irrelevant.
        Section in quotes dictates the actual scribed name in the save file.
        */
        public override void PostExposeData()
        {
            base.PostExposeData();
            Scribe_Values.Look(ref ccrt_itemAtag, "ccrt_itemAtag");
            Scribe_Values.Look(ref ccrt_itemBtag, "ccrt_itemBtag");
            Scribe_Values.Look(ref ccrt_itemCtag, "ccrt_itemCtag");
            Scribe_Values.Look(ref ccrt_itemDtag, "ccrt_itemDtag");
            Scribe_Values.Look(ref ccrt_itemEtag, "ccrt_itemEtag");
            Scribe_Values.Look(ref ccrt_itemFtag, "ccrt_itemFtag");
            Scribe_Values.Look(ref ccrt_itemGtag, "ccrt_itemGtag");
            Scribe_Values.Look(ref ccrt_itemHtag, "ccrt_itemHtag");
            Scribe_Values.Look(ref ccrt_itemItag, "ccrt_itemItag");
            Scribe_Values.Look(ref ccrt_itemJtag, "ccrt_itemJtag");
            Scribe_Values.Look(ref ccrt_itemKtag, "ccrt_itemKtag");
            Scribe_Values.Look(ref ccrt_itemLtag, "ccrt_itemLtag");
        }

        public override void PostSpawnSetup(bool respawningAfterLoad) //Copied from XeoNovaDan.
        {
            /* 
            Try and register the item as a tagged item to render when spawned. 
            This is a generic UI element to make sure that there is no issue with tags being lost or other weirdnes, specifically when ticks are inconsistent.
            */
            base.PostSpawnSetup(respawningAfterLoad);
            cachedTaggedOverlayDrawer = parent.Map.GetComponent<OverlayDrawer_ItemTag>();
            UpdateOverlayHandle();
        }
        public override void PostDeSpawn(Map map) //Copied from XeoNovaDan.
        {
            /* 
            Force deregister an item when despawned e.g. furniture minified, to prevent weird duplicate tagged overlays being rendered. 
            Saves memory and attempts to prevent floating tags in the place of destroyed or discarded entities.
            */
            base.PostDeSpawn(map);
            cachedTaggedOverlayDrawer.Deregister(parent, this, false);
        }
        private void UpdateOverlayHandle()
        {
            if (!parent.Spawned)
                return;
            /* 
            Register/unregister the item to draw a tagged icon over.
            Make sure to add any additional tags to this section or else the overlay will bug out.
            */
            cachedTaggedOverlayDrawer.Deregister(parent, this);
            if (parent.Spawned && (CCRT_TagItemA || CCRT_TagItemB || CCRT_TagItemC || CCRT_TagItemD || CCRT_TagItemE || CCRT_TagItemF || CCRT_TagItemG || CCRT_TagItemH || CCRT_TagItemI || CCRT_TagItemJ || CCRT_TagItemK || CCRT_TagItemL))
                cachedTaggedOverlayDrawer.Register(parent, this);
        }
        private MinifiedThing MinifiedParent => parent as MinifiedThing;

        // One Public Bool for each item tag.
        public bool CCRT_TagItemA
        {
            get
            {
                // Take minified things into account
                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    /*
                    This should never not be null to be honest as InnerThing would have CompNullifiable thus should be autopatched as it's a ThingWithComps
                    paranoid nullcheck
                    */
                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemA;
                }
                return ccrt_itemAtag;
            }
            set
            {

                if (value)
                {
                    /*
                    Preventing an item from having multiple tags. Thats how we end up with some cascading bugs.
                    All Comp Tags EXCEPT A. Do this for each tag type, excluding the parent tag. 
                    Could be a an exclusion argument? 
                    Maybe?
                    It works so I am leaving it alone.
                    */
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }
                // Take minified things into account
                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemA = value;
                }
                else
                    ccrt_itemAtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemB
        {
            get
            {
                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemB;
                }
                return ccrt_itemBtag;
            }
            set
            {
                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }
                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemB = value;
                }
                else
                    ccrt_itemBtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemC
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemC;
                }
                return ccrt_itemCtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemC = value;
                }
                else
                    ccrt_itemCtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemD
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemD;
                }
                return ccrt_itemDtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemD = value;
                }
                else
                    ccrt_itemDtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemE
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemE;
                }
                return ccrt_itemEtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemE = value;
                }
                else
                    ccrt_itemEtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemF
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemF;
                }
                return ccrt_itemFtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemF = value;
                }
                else
                    ccrt_itemFtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemG
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemG;
                }
                return ccrt_itemGtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemG = value;
                }
                else
                    ccrt_itemGtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemH
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemH;
                }
                return ccrt_itemHtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemH = value;
                }
                else
                    ccrt_itemHtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemI
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemI;
                }
                return ccrt_itemItag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemI = value;
                }
                else
                    ccrt_itemItag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemJ
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemJ;
                }
                return ccrt_itemJtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemK = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemJ = value;
                }
                else
                    ccrt_itemJtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemK
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemK;
                }
                return ccrt_itemKtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemL = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemK = value;
                }
                else
                    ccrt_itemKtag = value;
                UpdateOverlayHandle();
            }
        }
        public bool CCRT_TagItemL
        {
            get
            {

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();

                    if (taggedComp != null)
                        return taggedComp.CCRT_TagItemL;
                }
                return ccrt_itemLtag;
            }
            set
            {

                if (value)
                {
                    CCRT_TagItemA = false;
                    CCRT_TagItemB = false;
                    CCRT_TagItemC = false;
                    CCRT_TagItemD = false;
                    CCRT_TagItemE = false;
                    CCRT_TagItemF = false;
                    CCRT_TagItemG = false;
                    CCRT_TagItemH = false;
                    CCRT_TagItemI = false;
                    CCRT_TagItemJ = false;
                    CCRT_TagItemK = false;

                    cachedMatToDraw = null;
                }

                if (MinifiedParent != null)
                {
                    var taggedComp = MinifiedParent.InnerThing.TryGetComp<Comp_ItemTag>();
                    if (taggedComp != null)
                        taggedComp.CCRT_TagItemL = value;
                }
                else
                    ccrt_itemLtag = value;
                UpdateOverlayHandle();
            }
        }

        //Telling the game where to find the textures for cachedMatToDraw
        public Material MatToDraw
        {
            get
            {
                if (cachedMatToDraw == null)
                {
                    if (CCRT_TagItemA)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemA;
                    }
                    else if (CCRT_TagItemB)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemB;
                    }
                    else if (CCRT_TagItemC)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemC;
                    }
                    else if (CCRT_TagItemD)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemD;
                    }
                    else if (CCRT_TagItemE)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemE;
                    }
                    else if (CCRT_TagItemF)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemF;
                    }
                    else if (CCRT_TagItemG)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemG;
                    }
                    else if (CCRT_TagItemH)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemH;
                    }
                    else if (CCRT_TagItemI)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemI;
                    }
                    else if (CCRT_TagItemJ)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemJ;
                    }
                    else if (CCRT_TagItemK)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemK;
                    }
                    else if (CCRT_TagItemL)
                    {
                        cachedMatToDraw = OverlayDrawer_ItemTag.CCRT_TagMatItemL;
                    }
                    else
                        throw new NotImplementedException("Tried to get MatToDraw but item not Tagged CCRT_ItemTags: This is a build error, this should not happen. Contact the mod author on Steam.");
                }
                return cachedMatToDraw;
            }
        }
        /*
        bool values for each tag for scribing to save file. If a new tag is added, make sure there is a bool value added down here.
        FOR BEST RESULTS! Do not use my ccrt_ prefix! Make your own, for example HashSlasher69 could be "hs69_meleetag". 
        This will make it show up as <hs69_meleetag>True</hs69_meleetag> in the save file. 
        MUCH easier to find search and debug a save file.
        */
        private bool ccrt_itemAtag;
        private bool ccrt_itemBtag;
        private bool ccrt_itemCtag;
        private bool ccrt_itemDtag;
        private bool ccrt_itemEtag;
        private bool ccrt_itemFtag;
        private bool ccrt_itemGtag;
        private bool ccrt_itemHtag;
        private bool ccrt_itemItag;
        private bool ccrt_itemJtag;
        private bool ccrt_itemKtag;
        private bool ccrt_itemLtag;
        public bool allowedTagsToggleVisible;
        private OverlayDrawer_ItemTag cachedTaggedOverlayDrawer;
        private Material cachedMatToDraw;
    }
}