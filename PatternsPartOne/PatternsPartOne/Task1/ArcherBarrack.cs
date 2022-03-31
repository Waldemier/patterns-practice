namespace PatternsPartOne.Task1
{
    public class ArcherBarrack : Barrack
    {
        public override Warrior RecruitWarrior()
        {
            return new Archer();
        }
    }
}
