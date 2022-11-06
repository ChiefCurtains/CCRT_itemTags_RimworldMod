using System;
using System.Runtime.CompilerServices;
using Verse;

namespace CCRT_itemTags
{
    /*
    Each of these public classes are designated as a filter for the storage, equipment, and restriction of items and entities in Rimworld. 
    If you add a new tag, you need to add a new SpecialThingFilterWorker to this section.

    Remember, for newer C# users poking around in here. Each of these are Public Classes so imagine them as their own Item on the solution explorer.
    I have consolidated them all into a single CS file for the sake of organization. Any modification, for any reason, should be done within the respective class or
    by adding a new one.

    Simply copy and paste the public class here and change the "SpecialThingFilterWorker_XXXXXXX and "return taggedcomp.XXXXXXX" to your tag. 
    Make sure to reference them in the SpecialThingFilters.xml file. 
    Follow the formatting there EXACTLY, !!IMPORTANT!! DO NOT change the allowedByDefault tag, harmony will handle that.
    */
    public class SpecialThingFilterWorker_TagItemA : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemA;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemB : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemB;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemC : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemC;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemD : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemD;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemE : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemE;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemF : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemF;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemG : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemG;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemH : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemH;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemI : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemI;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemJ : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemJ;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemK : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemK;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    public class SpecialThingFilterWorker_TagItemL : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                return taggedComp.CCRT_TagItemL;
            return false;
        }
        public override bool CanEverMatch(ThingDef def)
        {
            return def.HasComp(typeof(Comp_ItemTag));
        }
    }
    //Making sure there is an ability to filter out ANY tagged items from a stockpile.
    public class SpecialThingFilterWorker_NoTag : SpecialThingFilterWorker
    { 
        public override bool Matches(Thing t)
        {
            var taggedComp = t.TryGetComp<Comp_ItemTag>();
            if (taggedComp != null)
                /* 
                I attempted multiple methods of making this return simpler. Every solution ended up making the Filter windows go nuts.
                So if someone knows better and decides to update this, please hit me up on steam "Chief_Curtains" and let me know how you did it.
                I would love to see the result!
                */
                return !taggedComp.CCRT_TagItemA && 
                    !taggedComp.CCRT_TagItemB && 
                    !taggedComp.CCRT_TagItemC && 
                    !taggedComp.CCRT_TagItemD && 
                    !taggedComp.CCRT_TagItemE && 
                    !taggedComp.CCRT_TagItemF && 
                    !taggedComp.CCRT_TagItemG && 
                    !taggedComp.CCRT_TagItemH && 
                    !taggedComp.CCRT_TagItemI && 
                    !taggedComp.CCRT_TagItemJ && 
                    !taggedComp.CCRT_TagItemK && 
                    !taggedComp.CCRT_TagItemL;
            return true;
        }

        public override bool AlwaysMatches(ThingDef def)
        {
            return !def.HasComp(typeof(Comp_ItemTag));
        }
    }

}
