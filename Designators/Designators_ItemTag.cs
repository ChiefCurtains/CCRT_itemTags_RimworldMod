using RimWorld;
using Verse;

namespace CCRT_itemTags
{
    //Draggable Button in the Architect Menu under the "Icon Tags" group. 
    internal class Designator_TagA : DesignatorBase_ItemTag
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
            defaultLabel = "A. " + ModSettings_ItemTag.newNameA;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colYellowGold;
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
    internal class Designator_TagB : DesignatorBase_ItemTag
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
            defaultLabel = "B. " + ModSettings_ItemTag.newNameB;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colOrange;
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
    internal class Designator_TagC : DesignatorBase_ItemTag
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
            defaultLabel = "C. " + ModSettings_ItemTag.newNameC;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colLightRed;
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
    internal class Designator_TagD : DesignatorBase_ItemTag
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
            defaultLabel = "D. " + ModSettings_ItemTag.newNameD;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colLightGreen;
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
    internal class Designator_TagE : DesignatorBase_ItemTag
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
            defaultLabel = "E. " + ModSettings_ItemTag.newNameE;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colOlive;
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
    internal class Designator_TagF : DesignatorBase_ItemTag
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
            defaultLabel = "F. " + ModSettings_ItemTag.newNameF;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colDarkOlive;
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
    internal class Designator_TagG : DesignatorBase_ItemTag
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
            defaultLabel = "G. " + ModSettings_ItemTag.newNameG;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colTurquoise;
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
    internal class Designator_TagH : DesignatorBase_ItemTag
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
            defaultLabel = "H. " + ModSettings_ItemTag.newNameH;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colSkyBlue;
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
    internal class Designator_TagI : DesignatorBase_ItemTag
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
            defaultLabel = "I. " + ModSettings_ItemTag.newNameI;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colDarkBlue;
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
    internal class Designator_TagJ : DesignatorBase_ItemTag
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
            defaultLabel = "J. " + ModSettings_ItemTag.newNameJ;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colLightPurple;
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
    internal class Designator_TagK : DesignatorBase_ItemTag
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
            defaultLabel = "K. " + ModSettings_ItemTag.newNameK;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colPurple;
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
    internal class Designator_TagL : DesignatorBase_ItemTag
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
            defaultLabel = "L. " + ModSettings_ItemTag.newNameL;
            defaultDesc = null;
            icon = TexCommand_ItemTag.ccrt_iconTex;
            defaultIconColor = Resource_Color_ItemTag.colDarkPurple;
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
