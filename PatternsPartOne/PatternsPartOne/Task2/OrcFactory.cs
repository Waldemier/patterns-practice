using PatternsPartOne.Task1;

namespace PatternsPartOne.Task2
{
    public class OrcFactory : Factory
    {
        public override Archer CreateArcher()
        {
            return new OrcArcher();
        }

        public override Swordman CreateSwordman()
        {
            return new OrсSwordsman();
        }
    }
}
