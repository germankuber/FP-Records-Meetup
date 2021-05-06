using System.Threading.Tasks;

namespace Records_Meetup
{
    internal class AccountService
    {
        public async Task<Account> AddMoneyAsync(decimal amount)
        {
            var account = new AccountRepository().GetAccount();

            account.AddMoney(amount);

            new EmailService().SendNotificationAsync(account);

            return account;
        }
    }
}