using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincetonLoops
{
    internal class Rgb
    {
        public double Red;
        public double Green;
        public double Blue;

        public Rgb(double red, double green, double blue)
        {
            Red = red;
            Green = green; 
            Blue = blue;
        }

        public void ConvertCmyk(Cmyk input)
        {
            Red = 255 * ((1-input.Cyan) * (1-input.Black));
            Green = 255 * ((1 - input.Magenta) * (1 - input.Black));
            Blue = 255 * ((1 - input.Yellow) * (1 - input.Black));
        }
        public override string ToString()
        {
            return $"Red: {Red} Green: {Green} Blue: {Blue}";
        }
    }
}
