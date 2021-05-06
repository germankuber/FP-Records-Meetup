using System;

namespace Records_Meetup
{
    internal interface AccountStatus
    {
        void SubtractMoney(Action subtractMoney);
    }
}