using RimWorld;
using Verse;

namespace CCRT_itemTags
{
    public abstract class Designator_Base : Designator
    {
        public override int DraggableDimensions
        {
            get
            {
                return 2;
            }
        }
        protected Designator_Base()
        {
            useMouseIcon = true;
            soundDragSustain = SoundDefOf.Designate_DragStandard;
            soundDragChanged = SoundDefOf.Designate_DragStandard_Changed;
            soundSucceeded = SoundDefOf.Designate_Claim;
            useMouseIcon = true;

        }
        public override AcceptanceReport CanDesignateCell(IntVec3 c)
        {
            if (!c.InBounds(Map))
            {
                return false;
            }
            foreach (Thing t in c.GetThingList(Map))
            {
                if (CanDesignateThing(t).Accepted)
                {
                    return true;
                }
            }
            return false;
        }
        public override void DesignateSingleCell(IntVec3 c)
        {
            foreach (Thing t in c.GetThingList(Map))
            {
                if (CanDesignateThing(t).Accepted)
                {
                    DesignateThing(t);
                }
            }
        }
        public override AcceptanceReport CanDesignateThing(Thing t)
        {
            bool flag = t.Position.Fogged(t.Map);
            AcceptanceReport result;
            if (flag)
            {
                result = false;
            }
            else
            {
                CompItemTags_CCRT compItemTags = (t is ThingWithComps thingWithComps) ? thingWithComps.GetComp<CompItemTags_CCRT>() : null;
                result = (compItemTags != null);
            }
            return result;
        }
        public bool visible = true;
    }
}
