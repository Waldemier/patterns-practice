using PatternsPartSixth.Enums;
using PatternsPartSixth.Implementation;
using System;

namespace PatternsPartSixth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cupType = CupTypeFactory.GetCupType(500, ColorEnum.Black);
            var cup = new Cup("SoftServe", cupType);

            var cachedType = CupTypeFactory.GetCupType(500, ColorEnum.Black);
            var cup2 = new Cup("EPAM Systems", cachedType);

            var anotherType = CupTypeFactory.GetCupType(700, ColorEnum.White);
            var cup3 = new Cup("GlobalLogic", anotherType);

            var anotherType2 = CupTypeFactory.GetCupType(700, ColorEnum.White);
            var cup4 = new Cup("N-iX", anotherType2);

            Console.WriteLine(cupType == cachedType);
            Console.WriteLine(anotherType == anotherType2);

            cup.Operation();
            cup2.Operation();
            cup3.Operation();
            cup4.Operation();
        }
    }
}
