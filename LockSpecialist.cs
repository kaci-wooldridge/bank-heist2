using System;

namespace bank_heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= this.SkillLevel;
            Console.WriteLine($"{this.Name} is breaking into the vault. Decreased security by {this.SkillLevel} points.");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{this.Name} has entered the vault!");
            }
        }

        public LockSpecialist(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }

    }
}