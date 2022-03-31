namespace PatternsPartOne.Task1
{
    public class SwordmanBarrack : Barrack
    {
        public override Warrior RecruitWarrior()
        {
            return new Swordman();
        }
    }
}
