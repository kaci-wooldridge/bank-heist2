using System;

namespace bank_heist2
{
    public class Bank
    {
        public int CashOnHand { get; set; }

        public int AlarmScore { get; set; }

        public int VaultScore { get; set; }

        public int SecurityGuardScore { get; set; }

        public bool IsSecure 
        { 
            get 
            { 
                return !(AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0);
            }
        }

        public Bank(int coh, int alarm, int vault, int security)
        {
            CashOnHand = coh;
            AlarmScore = alarm;
            VaultScore = vault;
            SecurityGuardScore = security;
        }
    }
}
