using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LedCube
{
    class RGB_Led
    {
        Ellipse led = new Ellipse();
        RGB_Colors rGBColors;

        public Ellipse Led
        {
            get
            {
                return led;
            }
            set
            {
                led = value;
            }
        }

        public RGB_Colors RGBcolors
        {
            get
            {
                return rGBColors;
            }
            set
            {
                rGBColors = value;
            }
        }
        
        public RGB_Led(byte red, byte green, byte blue)
        {
            RGB_Colors rgbcolors = new RGB_Colors(red,green,blue);
            RGBcolors=rgbcolors;
            led.Width = 35;
            led.Height = 35;
            led.Fill = new SolidColorBrush(Color.FromArgb(255,red,green,blue));
        }
    }
}
