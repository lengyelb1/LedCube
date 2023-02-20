using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedCube
{
    class RGB_Colors
    {
        char[] rgb_colors = new char[3];

        public char [] Rbg_colors
        {
            get
            {
                return rgb_colors;
            }
            set
            {
                rgb_colors = value;
            }
        }

        public RGB_Colors(byte red,byte green,byte blue)
        {
            char[] rbg_colors = new char[3];
            rgb_colors[0] = Convert.ToChar(red);
            rgb_colors[1] = Convert.ToChar(green);
            rgb_colors[2] = Convert.ToChar(blue);
            Rbg_colors = rbg_colors;
        }
    }
}
