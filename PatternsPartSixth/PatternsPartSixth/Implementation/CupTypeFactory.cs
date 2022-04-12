using PatternsPartSixth.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PatternsPartSixth.Implementation
{
    public static class CupTypeFactory
    {
        private static List<CupType> _cache;

        static CupTypeFactory()
        {
            _cache = new List<CupType>();
        }

        public static CupType GetCupType(double volume, ColorEnum color)
        {
            CupType type;

            if (_cache.Any(x => x.Volume == volume && x.Color == color))
            {
                type = _cache.First(x => x.Volume == volume && x.Color == color);
            }
            else
            {
                type = new CupType(color, volume);
                _cache.Add(type);
            }

            return type;
        }
    }
}
