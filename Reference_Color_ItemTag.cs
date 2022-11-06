using System.Collections.Generic;
using UnityEngine;

namespace CCRT_itemTags
{
    /*
    Collection of unity Colors borrowed from CharacterEditor's color picker. 
    These currently draw the static colors used by tags.
    I would like to have them evetually appear in a color picker window for editing of tag colors.
    */
    public static class Reference_Color_ItemTag
    {
        public static List<Color> CCRT_ListOfColors
        {
            get
            {
                bool flag = Reference_Color_ItemTag.lcolors == null;
                if (flag)
                {
                    Reference_Color_ItemTag.lcolors = new List<Color>
                    {
                        colWhite,
                        colLightGray,
                        colGray,
                        colDarkGray,
                        colGraphite,
                        colBlack,
                        colNavyBlue,
                        colDarkBlue,
                        colRoyalBlue,
                        colBlue,
                        colPureBlue,
                        colLightBlue,
                        colSkyBlue,
                        colMaroon,
                        colBurgundy,
                        colDarkRed,
                        colRed,
                        colPureRed,
                        colLightRed,
                        colHotPink,
                        colPink,
                        colDarkPurple,
                        colPurple,
                        colLightPurple,
                        colTeal,
                        colTurquoise,
                        colDarkBrown,
                        colBrown,
                        colLightBrown,
                        colTawny,
                        colBlaze,
                        colOrange,
                        colLightOrange,
                        colGold,
                        colYellowGold,
                        colYellow,
                        colDarkYellow,
                        colChartreuse,
                        colLightYellow,
                        colDarkGreen,
                        colGreen,
                        colPureGreen,
                        colLimeGreen,
                        colLightGreen,
                        colDarkOlive,
                        colOlive,
                        colOliveDrab,
                        colFoilageGreen,
                        colTan,
                        colBeige,
                        colKhaki,
                        colPeach
                    };
                }
                return Reference_Color_ItemTag.lcolors;
            }
        }
        public static readonly Color colWhite = new Color(1f, 1f, 1f);
        public static readonly Color colLightGray = new Color(0.82f, 0.824f, 0.831f);
        public static readonly Color colGray = new Color(0.714f, 0.718f, 0.733f);
        public static readonly Color colDarkGray = new Color(0.506f, 0.51f, 0.525f);
        public static readonly Color colGraphite = new Color(0.345f, 0.345f, 0.353f);
        public static readonly Color colDimGray = new Color(0.245f, 0.245f, 0.245f);
        public static readonly Color colDarkDimGray = new Color(0.175f, 0.175f, 0.175f);
        public static readonly Color colAsche = new Color(0.115f, 0.115f, 0.115f);
        public static readonly Color colBlack = new Color(0f, 0f, 0f);
        public static readonly Color colNavyBlue = new Color(0f, 0.082f, 0.267f);
        public static readonly Color colDarkBlue = new Color(0.137f, 0.235f, 0.486f);
        public static readonly Color colRoyalBlue = new Color(0.157f, 0.376f, 0.678f);
        public static readonly Color colBlue = new Color(0.004f, 0.42f, 0.718f);
        public static readonly Color colPureBlue = new Color(0f, 0f, 1f);
        public static readonly Color colLightBlue = new Color(0.129f, 0.569f, 0.816f);
        public static readonly Color colSkyBlue = new Color(0.58f, 0.757f, 0.91f);
        public static readonly Color colMaroon = new Color(0.373f, 0f, 0.125f);
        public static readonly Color colBurgundy = new Color(0.478f, 0.153f, 0.255f);
        public static readonly Color colDarkRed = new Color(0.545f, 0f, 0f);
        public static readonly Color colRed = new Color(0.624f, 0.039f, 0.055f);
        public static readonly Color colPureRed = new Color(1f, 0f, 0f);
        public static readonly Color colLightRed = new Color(0.784f, 0.106f, 0.216f);
        public static readonly Color colHotPink = new Color(0.863f, 0.345f, 0.631f);
        public static readonly Color colPink = new Color(0.969f, 0.678f, 0.808f);
        public static readonly Color colDarkPurple = new Color(0.251f, 0.157f, 0.384f);
        public static readonly Color colPurple = new Color(0.341f, 0.176f, 0.561f);
        public static readonly Color colLightPurple = new Color(0.631f, 0.576f, 0.784f);
        public static readonly Color colTeal = new Color(0.11f, 0.576f, 0.592f);
        public static readonly Color colTurquoise = new Color(0.027f, 0.51f, 0.58f);
        public static readonly Color colDarkBrown = new Color(0.282f, 0.2f, 0.125f);
        public static readonly Color colBrown = new Color(0.388f, 0.204f, 0.102f);
        public static readonly Color colLightBrown = new Color(0.58f, 0.353f, 0.196f);
        public static readonly Color colTawny = new Color(0.784f, 0.329f, 0.098f);
        public static readonly Color colBlaze = new Color(0.941f, 0.29f, 0.141f);
        public static readonly Color colOrange = new Color(0.949f, 0.369f, 0.133f);
        public static readonly Color colLightOrange = new Color(0.973f, 0.58f, 0.133f);
        public static readonly Color colGold = new Color(0.824f, 0.624f, 0.055f);
        public static readonly Color colYellowGold = new Color(1f, 0.761f, 0.051f);
        public static readonly Color colYellow = new Color(1f, 0.859f, 0.004f);
        public static readonly Color colDarkYellow = new Color(0.953f, 0.886f, 0.227f);
        public static readonly Color colChartreuse = new Color(0.922f, 0.91f, 0.067f);
        public static readonly Color colLightYellow = new Color(1f, 0.91f, 0.51f);
        public static readonly Color colDarkGreen = new Color(0f, 0.345f, 0.149f);
        public static readonly Color colGreen = new Color(0.137f, 0.663f, 0.29f);
        public static readonly Color colPureGreen = new Color(0f, 1f, 0f);
        public static readonly Color colLimeGreen = new Color(0.682f, 0.82f, 0.208f);
        public static readonly Color colLightGreen = new Color(0.541f, 0.769f, 0.537f);
        public static readonly Color colDarkOlive = new Color(0.255f, 0.282f, 0.149f);
        public static readonly Color colOlive = new Color(0.451f, 0.463f, 0.294f);
        public static readonly Color colOliveDrab = new Color(0.357f, 0.337f, 0.263f);
        public static readonly Color colFoilageGreen = new Color(0.482f, 0.498f, 0.443f);
        public static readonly Color colTan = new Color(0.718f, 0.631f, 0.486f);
        public static readonly Color colBeige = new Color(0.827f, 0.741f, 0.545f);
        public static readonly Color colKhaki = new Color(0.933f, 0.835f, 0.678f);
        public static readonly Color colPeach = new Color(0.996f, 0.859f, 0.733f);
        private static List<Color> lcolors;
    }
}
