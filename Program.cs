using System;
using System.Collections.Generic;
using System.Linq;

namespace bank_heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker hacker1 = new("Will", 75, 5);
            Hacker hacker2 = new("Morgan", 75, 5);
            LockSpecialist lock1 = new("Logan", 75, 5);
            LockSpecialist lock2 = new("Marek", 75, 5);
            Muscle muscle1 = new("Matthew", 75, 10);
            Muscle muscle2 = new("Chris", 75, 10);
            BossLady boss = new("Kaci", 100, 60);

            List<IRobber> alphaTeam = new()
            {
                hacker1, hacker2, lock1, lock2, muscle1, muscle2, boss
            };

            List<IRobber> rolodex = new()
            {
                hacker1, hacker2, lock1, lock2, muscle1, muscle2
            };

            Dictionary<string, IRobber> TheSquad = new()
            {
            };

            Console.WriteLine("We're totally robbing a bank today.");
            Console.WriteLine($"So far we've got a team of {rolodex.Count()} members available.");
            Console.WriteLine("Do you know anyone else that'd be down to join us?!");
            Console.ReadLine();
            Console.WriteLine("......");
            Console.ReadLine();
            Console.WriteLine("Stupid question. Of course you do.");
            while (true)
            {
                Console.WriteLine("What's their name?");
                string userPickName = Console.ReadLine();
                if (userPickName == "")
                {
                    break;
                }
                
                Console.WriteLine("And what's their specialty?");
                taco:
                Console.WriteLine(@"
                1-Hacking
                2-Strength
                3-Lock Picking
                ");
                int userPickSpecialty = int.Parse(Console.ReadLine());

                Console.WriteLine("And what's their skill level? On a scale of 1-100?");
                int userPickSkill = int.Parse(Console.ReadLine());

                Console.WriteLine("What kind of percentage are they looking for?");
                int userPickPercent = int.Parse(Console.ReadLine());

                if(userPickSpecialty == 1)
                {
                    Hacker hacker = new(userPickName, userPickSkill, userPickPercent);
                    TheSquad.Add(userPickName, hacker);
                    rolodex.Add(hacker);
                    Console.WriteLine("And the next member you want to add?");
                }
                else if(userPickSpecialty == 2)
                {
                    Muscle muscle = new(userPickName, userPickSkill, userPickPercent);
                    TheSquad.Add(userPickName, muscle);
                    rolodex.Add(muscle);
                    Console.WriteLine("And the next member you want to add?");
                }
                else if(userPickSpecialty ==3)
                {
                    LockSpecialist lockSpecialist = new(userPickName, userPickSkill, userPickPercent);
                    TheSquad.Add(userPickName, lockSpecialist);
                    rolodex.Add(lockSpecialist);
                    Console.WriteLine("And the next member you want to add?");
                }
                else
                {
                    Console.WriteLine("Please select a specialty!");
                    goto taco;
                }
            }

            Random r = new Random();
            int alarmValue = r.Next(0, 101);
            int vaultValue = r.Next(0, 101);
            int securityValue = r.Next(0, 101);
            int cohValue = r.Next(50000, 1000001);

            Bank bank = new(cohValue, alarmValue, vaultValue, securityValue);

            Dictionary<string, int> securities = new Dictionary<string, int>() {
                {"Alarm", bank.AlarmScore}, {"Vault", bank.VaultScore}, {"Security Guard", bank.SecurityGuardScore}
            };

            Dictionary<string, int> orderedSecurities = new Dictionary<string, int>();
            orderedSecurities = securities.OrderBy(key => key.Value).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Most secure system: {orderedSecurities.Keys.ElementAt(orderedSecurities.Count - 1)}");
            Console.WriteLine($"Least secure system: {orderedSecurities.Keys.ElementAt(0)}");

            foreach (var item in rolodex)
            {
                Console.WriteLine($"{item.Name} {item.GetType().Name} skill-level:{item.SkillLevel} cut:{item.PercentageCut}%");
            }

        }
    }
}