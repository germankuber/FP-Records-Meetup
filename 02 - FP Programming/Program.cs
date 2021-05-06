using System;
using System.Threading.Tasks;

using Records_Meetup.Domain;

namespace Records_Meetup
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var account = await new AccountService(default).AddMoneyAsync(Money.Create(200).Value);

            account.AddMoney(Money.Create(999).Value);
            await Task.Delay(2000);
            Console.WriteLine($"Account balance {account.Balance}");

            Console.ReadKey();
        }
    }
}