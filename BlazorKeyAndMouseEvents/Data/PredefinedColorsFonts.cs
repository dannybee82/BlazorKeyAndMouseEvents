using System.Drawing.Text;

namespace BlazorKeyAndMouseEvents.Data
{

    /// <summary>
    /// PredefinedColorsFonts - This class contains an array with (148) predefined color names, supported by all browsers.
    /// This class gets also all installed fonts.
    /// </summary>
    public static class PredefinedColorsFonts
    {

        /// <summary>
        /// GetAllPredifinedColors() - this method returns an array with 148 predefined color names.
        /// </summary>
        /// <returns>string[]</returns>

        public static string[] GetAllPredifinedColors()
        {
            return _predefinedColors;
        }

        /// <summary>
        /// GetAllFonts() - This method returns all (websafe) fonts
        /// </summary>
        /// <returns></returns>

        public static string[] GetAllFonts()
        {
            return _allWebSafeFonts;
        }

        /// <value>
        /// _predefinedColors = string[] array.
        /// </value>

        private static string[] _predefinedColors = new string[] {
            "aliceblue",
            "antiquewhite",
            "aqua",
            "aquamarine",
            "azure",
            "beige",
            "bisque",
            "black",
            "blanchedalmond",
            "blue",
            "blueviolet",
            "brown",
            "burlywood",
            "cadetblue",
            "chartreuse",
            "chocolate",
            "coral",
            "cornflowerblue",
            "cornsilk",
            "crimson",
            "cyan",
            "darkblue",
            "darkcyan",
            "darkgoldenrod",
            "darkgray",
            "darkgrey",
            "darkgreen",
            "darkkhaki",
            "darkmagenta",
            "darkolivegreen",
            "darkorange",
            "darkorchid",
            "darkred",
            "darksalmon",
            "darkseagreen",
            "darkslateblue",
            "darkslategray",
            "darkslategrey",
            "darkturquoise",
            "darkviolet",
            "deeppink",
            "deepskyblue",
            "dimgray",
            "dimgrey",
            "dodgerblue",
            "firebrick",
            "floralwhite",
            "forestgreen",
            "fuchsia",
            "gainsboro",
            "ghostwhite",
            "gold",
            "goldenrod",
            "gray",
            "grey",
            "green",
            "greenyellow",
            "honeydew",
            "hotpink",
            "indianred",
            "indigo",
            "ivory",
            "khaki",
            "lavender",
            "lavenderblush",
            "lawngreen",
            "lemonchiffon",
            "lightblue",
            "lightcoral",
            "lightcyan",
            "lightgoldenrodyellow",
            "lightgray",
            "lightgrey",
            "lightgreen",
            "lightpink",
            "lightsalmon",
            "lightseagreen",
            "lightskyblue",
            "lightslategray",
            "lightslategrey",
            "lightsteelblue",
            "lightyellow",
            "lime",
            "limegreen",
            "linen",
            "magenta",
            "maroon",
            "mediumaquamarine",
            "mediumblue",
            "mediumorchid",
            "mediumpurple",
            "mediumseagreen",
            "mediumslateblue",
            "mediumspringgreen",
            "mediumturquoise",
            "mediumvioletred",
            "midnightblue",
            "mintcream",
            "mistyrose",
            "moccasin",
            "navajowhite",
            "navy",
            "oldlace",
            "olive",
            "olivedrab",
            "orange",
            "orangered",
            "orchid",
            "palegoldenrod",
            "palegreen",
            "paleturquoise",
            "palevioletred",
            "papayawhip",
            "peachpuff",
            "peru",
            "pink",
            "plum",
            "powderblue",
            "purple",
            "rebeccapurple",
            "red",
            "rosybrown",
            "royalblue",
            "saddlebrown",
            "salmon",
            "sandybrown",
            "seagreen",
            "seashell",
            "sienna",
            "silver",
            "skyblue",
            "slateblue",
            "slategray",
            "slategrey",
            "snow",
            "springgreen",
            "steelblue",
            "tan",
            "teal",
            "thistle",
            "tomato",
            "turquoise",
            "violet",
            "wheat",
            "white",
            "whitesmoke",
            "yellow",
            "yellowgreen"
        };

        private static string[] _allWebSafeFonts = new string[]
        {
            "Andalé Mono",
            "Arial",
            "Arial Black",
            "Baskerville",
            "Bradley Hand",
            "Brush Script MT",
            "Comic Sans MS",
            "Courier",
            "Georgia",
            "Gill Sans",
            "Helvetica",
            "Impact",
            "Lucida",
            "Luminari",
            "Monaco",
            "Palatino",
            "Tahoma",
            "Times New Roman",
            "Trebuchet MS",
            "Verdana"
        };


    }
}
