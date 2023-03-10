using System;

namespace bank_heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= this.SkillLevel;
            Console.WriteLine($"{this.Name} is absouley destroying the security guards. Decreased security by {this.SkillLevel} points.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{this.Name} has killed all the guards!");
            }
        }

    }
}