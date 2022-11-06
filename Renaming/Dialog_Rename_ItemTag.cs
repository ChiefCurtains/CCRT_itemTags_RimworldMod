using System;
using Verse;
using UnityEngine;
using RimWorld;
using System.Xml.Linq;

namespace CCRT_itemTags
{
    /// <summary>
    /// Ok, so we are going to try and reference the Vanilla Dialog_RenameAnimalPen
    /// 
    /// </summary>
    public class Dialog_Raname_ItemTag : Window
    {
        private bool AcceptsInput
        {
            get
            {
                return this.startAcceptingInputAtFrame <= Time.frameCount;
            }
        }
        protected virtual int MaxNameLength
        {
            get
            {
                return 28;
            }
        }
        public override Vector2 InitialSize
        {
            get
            {
                return new Vector2(280f, 175f);
            }
        }

        public Dialog_Raname_ItemTag() //Need to create and IExposable ItemTag.cs
        {
           curName = def.label;
        }
        protected virtual AcceptanceReport NameIsValid(string tagName) //Vanilla Dialog_RenameAnimalPen (line 18)
        {
            if (name.Length == 0)
            {
                return false;
            }
            return true;
        }
        protected override void SetName(string tagName) // "" line 33
        {
            def.label = tagName;
        }

        public ItemTagDef def;
    }
}
