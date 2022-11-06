using RimWorld;
using Verse;

namespace CCRT_itemTags
{
    //Draggable Button in the Architect Menu under the "Icon Tags" group. 
    internal class Designator_TagA : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagA)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagA()
        {
            defaultLabel = "CCRT_itemTags.TagA".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colYellowGold;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing t)
        {
            bool flag = !CanDesignateThing(t).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = t as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemA = !compItemTags.CCRT_TagItemA;
            }
        }


    }
    internal class Designator_TagB : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagB)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagB()
        {
            defaultLabel = "CCRT_itemTags.TagB".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colOrange;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemB = !compItemTags.CCRT_TagItemB;
            }
        }
    }
    internal class Designator_TagC : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagC)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagC()
        {
            defaultLabel = "CCRT_itemTags.TagC".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colLightRed;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemC = !compItemTags.CCRT_TagItemC;
            }
        }
    }
    internal class Designator_TagD : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagD)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagD()
        {
            defaultLabel = "CCRT_itemTags.TagD".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colLightGreen;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }

        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemD = !compItemTags.CCRT_TagItemD;
            }
        }
    }
    internal class Designator_TagE : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagE)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagE()
        {
            defaultLabel = "CCRT_itemTags.TagE".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colOlive;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemE = !compItemTags.CCRT_TagItemE;
            }
        }
    }
    internal class Designator_TagF : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagF)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagF()
        {
            defaultLabel = "CCRT_itemTags.TagF".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colDarkOlive;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemF = !compItemTags.CCRT_TagItemF;
            }
        }
    }
    internal class Designator_TagG : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagG)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagG()
        {
            defaultLabel = "CCRT_itemTags.TagG".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colTurquoise;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemG = !compItemTags.CCRT_TagItemG;
            }
        }
    }
    internal class Designator_TagH : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagH)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagH()
        {
            defaultLabel = "CCRT_itemTags.TagH".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colSkyBlue;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing t)
        {
            bool flag = !CanDesignateThing(t).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = t as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemH = !compItemTags.CCRT_TagItemH;
            }
        }
    }
    internal class Designator_TagI : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagI)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagI()
        {
            defaultLabel = "CCRT_itemTags.TagI".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colDarkBlue;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemI = !compItemTags.CCRT_TagItemI;
            }
        }


    }
    internal class Designator_TagJ : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagJ)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagJ()
        {
            defaultLabel = "CCRT_itemTags.TagJ".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colLightPurple;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemJ = !compItemTags.CCRT_TagItemJ;
            }
        }


    }
    internal class Designator_TagK : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagK)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagK()
        {
            defaultLabel = "CCRT_itemTags.TagK".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colPurple;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemK = !compItemTags.CCRT_TagItemK;
            }
        }


    }
    internal class Designator_TagL : Designator_Base
    {
        public override bool Visible
        {
            get
            {
                if (ModSettings_ItemTag.ccrt_enableTagL)
                {
                    return visible;
                }
                else
                {
                    return !visible;
                }

            }

        }

        public Designator_TagL()
        {
            defaultLabel = "CCRT_itemTags.TagL".Translate();
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Reference_Color_ItemTag.colDarkPurple;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;
        }
        public override void DesignateThing(Thing thing)
        {
            bool flag = !CanDesignateThing(thing).Accepted;
            if (!flag)
            {
                ThingWithComps thingWithComps = thing as ThingWithComps;
                Comp_ItemTag compItemTags = thingWithComps?.GetComp<Comp_ItemTag>();
                compItemTags.CCRT_TagItemL = !compItemTags.CCRT_TagItemL;
            }
        }


    }
}
