using System;

namespace Records_Meetup
{
    internal interface AddMoneyToAccountStrategy
    {
        void AddMoney(decimal amount,
                      Action<decimal> addMoney);
    }
}