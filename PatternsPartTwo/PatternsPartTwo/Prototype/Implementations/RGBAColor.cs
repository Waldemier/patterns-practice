using System;

namespace PatternsPartTwo.Prototype.Implementations
{
    public class RGBAColor : Interfaces.ICloneable
    {
        private RGBColor RGBColor { get; set; }
        public double Alpha { get; set; }

        public RGBAColor(RGBColor rGBColor, double alpha)
        {
            RGBColor = rGBColor;
            Alpha = alpha;
        }

        public object ShallowCopy()
        {
            var shallowCopy = new RGBAColor(RGBColor, Alpha);
            return shallowCopy;
        }

        public object DeepCopy()
        {
            var rgbDeepCopy = (RGBColor)RGBColor.DeepCopy();
            var deepCopy = new RGBAColor(rgbDeepCopy, Alpha);
            return deepCopy;
        }

        public override string ToString()
        {
            return $"{RGBColor}, {Alpha}";
        }
    }
}
