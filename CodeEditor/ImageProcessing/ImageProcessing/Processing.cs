﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing
{
    class Processing
    {
        public Processing()
        {

        }

        public static bool ConvertToGrey(Bitmap b)
        {
            for(int i=0; i<b.Width;i++)
                for(int j=0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int grey = (byte)(.299 * r1 + .587 * g1 + .114 * b1);

                    r1 = grey;
                    g1 = grey;
                    b1 = grey;

                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            return true;
        }
        public static bool ConvertToNegative(Bitmap b)
        {
            for(int i=0;i<b.Width;i++) // loop for width
                for(int j = 0; j < b.Height; j++) //loop for height
                {
                    Color c1 = b.GetPixel(i, j); // get pixel from colour
                    int a = c1.A; //extracting ARGB from pixel colour
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    //For Negative Values
                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;
                    b.SetPixel(i, j, Color.FromArgb(a, r1, g1, b1));

                }

            return true;
        }


    }
}
