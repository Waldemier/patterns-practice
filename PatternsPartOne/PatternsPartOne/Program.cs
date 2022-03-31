using PatternsPartOne.Task1;
using PatternsPartOne.Task2;
using PatternsPartOne.Task3;
using System;
using System.Collections.Generic;

namespace PatternsPartOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Task 1
            Barrack[] barracks = new Barrack[] { new SwordmanBarrack(), new ArcherBarrack() };
            var warriors = new List<Warrior>();

            foreach (var barrack in barracks)
            {
                warriors.Add(barrack.RecruitWarrior());
                warriors.Add(barrack.RecruitWarrior());
                warriors.Add(barrack.RecruitWarrior());
            }

            foreach (var warrior in warriors)
            {
                warrior.Attack();
            }

            // Task 2
            Factory[] factories = new Factory[] { new ElfFactory(), new OrcFactory() };

            Battlefield battlefield = new Battlefield();

            foreach (var factory in factories)
            {
                battlefield.Swordmans.Add(factory.CreateSwordman());
                battlefield.Swordmans.Add(factory.CreateSwordman());
                battlefield.Swordmans.Add(factory.CreateSwordman());
                battlefield.Swordmans.Add(factory.CreateSwordman());
                battlefield.Swordmans.Add(factory.CreateSwordman());
                battlefield.Swordmans.Add(factory.CreateSwordman());
                battlefield.Archers.Add(factory.CreateArcher());
                battlefield.Archers.Add(factory.CreateArcher());
                battlefield.Archers.Add(factory.CreateArcher());
                battlefield.Archers.Add(factory.CreateArcher());
                battlefield.Archers.Add(factory.CreateArcher());
                battlefield.Archers.Add(factory.CreateArcher());
            }

            battlefield.BegginFight();

            // Task 3
            var stringer = new Stringer(" This is 23:08pm and we dont know WHAT TO WRITE. ");
            var result = stringer.Upper().Trim().Reverse().Lower().RemoveSymbol(".").Result();
            Console.WriteLine(result);
        }
    }
}
