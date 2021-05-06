using System;
using System.Threading.Tasks;

namespace Records_Meetup
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var account = await new AccountService().AddMoneyAsync(200);

            account.AddMoney(999);
            await Task.Delay(2000);
            Console.WriteLine($"Account balance {account.Balance}");

            Console.ReadKey();

        }
    }
}
