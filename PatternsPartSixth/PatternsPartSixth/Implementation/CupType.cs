using PatternsPartSixth.Enums;
using System;

namespace PatternsPartSixth.Implementation
{
    public class CupType
    {
        public double Volume { get; }
        public ColorEnum Color { get; }

        public CupType(ColorEnum color, double volume)
        {
            Color = color;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"Volume: {Volume} | Color: {Enum.GetName(Color)}";
        }
    }
}
