using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace CCRT_itemTags
{
    /*
    Ok, so we have basically built a short version of the vanilla code 
    ThingDef.DescriptionDetialed > ApparelProperties.GetLayerString > ApparelLayerDef > ApparelLayerDefs.XML
    Now we will need to build a Def file for the tags and include the "Label" field. DONE

    I may not actually need this.
    Now I will need to make an IExposable value for TagFriendlyName to be used by. This is the vanilla 
    equivalent of Thing.DescriptionDetailed. Mine will be "public class TagEntity" TagFriendlyName.

    Myabe instead I can go with a "public virtual string TagFriendlyName" nested in the ModSettings class?
    */
    /// <summary>
    /// Based on Vanilla ApparelProperties Class
    /// </summary>
    public class TagProperties 
    {
        //Vanilla Apparel Properties (line 118)
        public string GetTagNameString() 
        {
            //Vanilla Equivalent is pointing to ApparelLayerDef
            return (from label in tagNames
                        //"label" field from TagNamesDef.xml
                    select label.tagAName).ToCommaList(false, false).CapitalizeFirst();
        }
        public List<ItemTagDef> tagNames = new List<ItemTagDef>();
    }
}
