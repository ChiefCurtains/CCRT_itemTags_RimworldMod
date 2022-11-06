using System;
using System.Collections.Generic;
using System.Linq;
using CCRT_itemTags.Resources;
using RimWorld;
using RimWorld.Planet;
using UnityEngine;
using Verse;
using Verse.AI;
using Verse.Sound;

namespace CCRT_itemTags.Renaming
{
    // Reference TacticalGroups.ColonistGroup
    public class IExposable_ItemTag : IExposable, ILoadReferenceable
    {
        public void SetName(string name) //line 73 (curName = curTagName, tagName = groupName)
        {
            tagName = name;
            curTagName = tagName;
        }
        public string GetUniqueLoadID() //line 1355 (groupID = tagId)
        {
            return GetType().ToString() + tagID.ToString();
        }
        public virtual void ExposeData()
        {
            Scribe_Values.Look(ref tagName, "tagName", null, false); //line 1259 (groupName = tagName)
            Scribe_Values.Look(ref tagID, "tagID", 0, false); // line 1260 (groupID = tagID)

            if (Scribe.mode == LoadSaveMode.PostLoadInit) //line 1318 (curGroupName = curTagName, groupName = tagName, defaultGroupName = defaultTagName, groupID = tagID)
            {
                curTagName = (tagName ?? (defaultTagName + " " + tagID.ToString()));
            }
        }
        public override string ToString()
        {
            string str = curTagName; //line 1348 (groupID = tagID)
            return str.ToString();
        }
        public virtual void Init()
        {
            defaultTagName = Strings.TagName;
            defaultTagNameA = Strings.TagName + " A";
        }
        public string curTagName; //line 1418
        public string tagName; //line 1511
        public string defaultTagName; //line 1514
        public string defaultTagNameA;
        public int tagID; //line 1481
    }
}
