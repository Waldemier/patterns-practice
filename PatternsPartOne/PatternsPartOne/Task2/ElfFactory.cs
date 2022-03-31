using PatternsPartOne.Task1;

namespace PatternsPartOne.Task2
{
    public class ElfFactory : Factory
    {
        public override Archer CreateArcher()
        {
            return new ElfArcher();
        }

        public override Swordman CreateSwordman()
        {
            return new ElfSwordsman();
        }
    }
}
