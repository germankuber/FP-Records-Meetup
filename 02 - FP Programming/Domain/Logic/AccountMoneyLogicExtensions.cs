using System;

using Records_Meetup.Domain;

namespace Records_Meetup
{
    public static class AccountMoneyLogicExtensions
    {
        public static Account AddMoney(this Account @this,
                                       Money amount)
            => @this with
               {
                   Balance = @this.Balance + amount
               };

        public static Account AddMoney(this Account @this,
                                       Money amount,
                                       Func<Money, Money, Money> strategy)
            => @this with
               {
                   Balance = strategy(@this.Balance, amount)
               };

        public static Account SubtractMoney(this Account @this,
                                            Money amount)
            => @this.Status switch
               {
                   AccountStatus.Open => @this with
                                         {
                                             Balance = @this.Balance - amount
                                         },
                   AccountStatus.Close => @this,
                   _                   => throw new ArgumentOutOfRangeException()
               };
    }
}