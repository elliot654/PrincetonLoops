using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincetonLoops
{
    internal class Cmyk
    {
        public double Cyan;
        public double Magenta;
        public double Yellow;
        public double Black;

        public Cmyk(double cyan, double magenta, double yellow, double black)
        {
            Cyan = cyan;
            Magenta = magenta;
            Yellow = yellow;
            Black = black;
        }

        public void ConvertRgb(Rgb input)
        {
            double red = input.Red/255;
            double green = input.Green/255;
            double blue = input.Blue / 255;
            Black = 1 - Math.Max(red, Math.Max(green, blue));
            Cyan = ((1-red-Black)/(1-Black));
            Magenta = ((1 - green - Black) / (1 - Black));
            Yellow = ((1 - blue - Black) / (1 - Black));
        }

        public override string ToString()
        {
            return $"Cyan: {Cyan} Magenta: {Magenta} Yellow: {Yellow} Black: {Black}";
        }
    }
}
