using System;

namespace Records_Meetup
{
    internal class OpenAccountStatus
    {
        private void SubtractMoney(Action subtractMoney)
            => subtractMoney();
    }
}