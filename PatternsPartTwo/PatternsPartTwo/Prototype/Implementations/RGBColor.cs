using System;

namespace PatternsPartTwo.Prototype.Implementations
{
    public class RGBColor : Interfaces.ICloneable
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public RGBColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public object DeepCopy()
        {
            var deepCopy = new RGBColor(Red, Green, Blue);
            return deepCopy;
        }

        public object ShallowCopy()
        {
            var shallowCopy = new RGBColor(Red, Green, Blue);
            return shallowCopy;
        }

        public override string ToString()
        {
            return $"{Red}, {Green}, {Blue}";
        }
    }
}
