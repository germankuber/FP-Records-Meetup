using System;
using System.Threading.Tasks;

using Records_Meetup.Domain;

namespace Records_Meetup
{
    internal class AccountService
    {
        private readonly Func<Money, Money, Money> _strategy;

        public AccountService(Func<Money, Money, Money> strategy)
            => _strategy = strategy;

        public async Task<Account> AddMoneyAsync(Money amount)
        {
            var account = new AccountRepository().GetAccount();

            account.AddMoney(amount, _strategy);

            await new EmailService().SendNotificationAsync(account);

            return account;
        }
    }
}