using System;

namespace bank_heist2
{
    public class BossLady : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= this.SkillLevel;
            bank.VaultScore -= this.SkillLevel;
            bank.SecurityGuardScore -= this.SkillLevel;
            Console.WriteLine($"{this.Name} is doing everyone's jobs for them. Decreased all security by {this.SkillLevel} points.");
            if (bank.AlarmScore <= 0 || bank.VaultScore <=0 || bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{this.Name} is the best and does it all!");
            }
        }

        public BossLady(string name, int skillLevel, int percentageCut)
        {
            name = Name;
            skillLevel = SkillLevel;
            percentageCut = PercentageCut;
        }

    }
}