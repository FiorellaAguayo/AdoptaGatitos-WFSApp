﻿using System.Drawing;

namespace Graphics
{
    public class ThemeColor
    {
        public static List<string> ColorList = new List<string> {"#E19C5F",
                                                                 "#F08080",
                                                                 "#909AA0",
                                                                 "#C71585",
                                                                 "#6495ED",
                                                                 "#228B22",
                                                                 "#6B8E23",
                                                                 "#FFA500"};

        /// <summary>
        /// Cambia la luminosidad de un color dado según un factor de corrección.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="correctionFactor"></param>
        /// <returns></returns>
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}