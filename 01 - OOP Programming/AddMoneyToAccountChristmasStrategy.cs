using System;

namespace Records_Meetup
{
    internal class AddMoneyToAccountChristmasStrategy
    {
        private readonly decimal _bonus = 999;

        private void AddMoney(decimal amount,
                              Action<decimal> addMoney)
            => addMoney(amount + _bonus);
    }
}