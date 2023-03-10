using System;

namespace bank_heist2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= this.SkillLevel;
            Console.WriteLine($"{this.Name} is hacking the alarm system. Decreased security by {this.SkillLevel} points.");
            if(bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{this.Name} has disabled the alarm system!");
            }
        }

    }
}