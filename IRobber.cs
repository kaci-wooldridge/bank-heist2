// A string property for Name
// An integer property for SkillLevel
// An integer property for PercentageCut
// A method called PerformSkill that takes in a Bank parameter and doesn't return anything.

namespace bank_heist2
{
    public interface IRobber
    {
        string Name { get; }

        int SkillLevel { get; }

        int PercentageCut { get; }

        void PerformSkill(Bank bank);
    }
}