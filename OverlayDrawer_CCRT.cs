using RimWorld.Planet;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace CCRT_itemTags
{
    [StaticConstructorOnStartup]
    public class OverlayDrawer_CCRT : MapComponent
    {
        //This makes the tagged icons appear in the overworld. Pretty much shamelessly ripped from XeoNovaDan.
        public OverlayDrawer_CCRT(Map map) /*Copied from XeoNovaDan.*/: base(map)
        {
            drawBatch = new DrawBatch();
            overlayDrawRegister = new List<Pair<Thing, CompItemTags_CCRT>>();
            overlaysToDraw = new List<Pair<Thing, CompItemTags_CCRT>>();
        }
        public override void MapComponentUpdate() //Copied from XeoNovaDan.
        {
            base.MapComponentUpdate();
            if (!WorldRendererUtility.WorldRenderedNow && Find.CurrentMap == map)
                DrawAlltaggedOverlays();
        }
        public void DrawtaggedOverlay(Pair<Thing, CompItemTags_CCRT> p) //Copied from XeoNovaDan.
        {
            if (!overlaysToDraw.Contains(p))
                overlaysToDraw.Add(p);
        }
        public void DrawAlltaggedOverlays() //Copied from XeoNovaDan.
        {
            if (ModSettings_CCRT.ccrt_enableItemTags)
            {
                // Almost 1:1 structure with the vanilla Overlay Drawer code.
                try
                {
                    for (int i = 0; i < overlayDrawRegister.Count; i++)
                    {
                        var curRegister = overlayDrawRegister[i];
                        if (!curRegister.First.Fogged())
                            DrawtaggedOverlay(curRegister);
                    }
                    for (int i = 0; i < overlaysToDraw.Count; i++)
                    {
                        var p = overlaysToDraw[i];
                        RendertaggedOverlay(p);
                    }
                }
                finally
                {
                    overlaysToDraw.Clear();
                }
                drawBatch.Flush();
            }
        }
        private void RendertaggedOverlay(Pair<Thing, CompItemTags_CCRT> p) //Copied from XeoNovaDan.
        {
            // Render tagged icon overlay over the bottom right hand corner of the item on map.
            var thing = p.First;
            Vector3 drawPos = thing.DrawPos;
            var rotSize = thing.RotatedSize;
            drawPos.z -= 0.3f * rotSize.z;
            drawPos.x += 0.3f * rotSize.x;
            drawPos.y = BaseAlt + 0.16216215f;
            drawBatch.DrawMesh(MeshPool.plane05, Matrix4x4.TRS(drawPos, Quaternion.identity, Vector3.one), p.Second.MatToDraw, 0, true);
        }
        public void Register(Thing t, CompItemTags_CCRT c, bool checkRegister = true) //Copied from XeoNovaDan.
        {
            var p = new Pair<Thing, CompItemTags_CCRT>(t, c);
            if (!checkRegister || !overlayDrawRegister.Contains(p))
                overlayDrawRegister.Add(p);
        }
        public void Deregister(Thing t, CompItemTags_CCRT c, bool checkRegister = true) //Copied from XeoNovaDan.
        {
            var p = new Pair<Thing, CompItemTags_CCRT>(t, c);
            if (!checkRegister || overlayDrawRegister.Contains(p))
                overlayDrawRegister.Remove(p);
        }

        private static readonly float BaseAlt = AltitudeLayer.MetaOverlays.AltitudeFor();
        public static readonly Material CCRT_TagMatItemA = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colYellowGold);
        public static readonly Material CCRT_TagMatItemB = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colOrange);
        public static readonly Material CCRT_TagMatItemC = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colLightRed);
        public static readonly Material CCRT_TagMatItemD = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colLightGreen);
        public static readonly Material CCRT_TagMatItemE = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colOlive);
        public static readonly Material CCRT_TagMatItemF = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colDarkOlive);
        public static readonly Material CCRT_TagMatItemG = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colTurquoise);
        public static readonly Material CCRT_TagMatItemH = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colSkyBlue);
        public static readonly Material CCRT_TagMatItemI = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colDarkBlue);
        public static readonly Material CCRT_TagMatItemJ = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colLightPurple);
        public static readonly Material CCRT_TagMatItemK = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colPurple);
        public static readonly Material CCRT_TagMatItemL = MaterialPool.MatFrom("UI/Designators/CCRT_iconTag", ShaderDatabase.MetaOverlay, ColorReference_CCRT.colDarkPurple);

        public DrawBatch drawBatch;
        public List<Pair<Thing, CompItemTags_CCRT>> overlaysToDraw;
        public List<Pair<Thing, CompItemTags_CCRT>> overlayDrawRegister;
    }
}