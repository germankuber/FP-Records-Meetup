using System;
using System.Threading.Tasks;

namespace Records_Meetup
{
    internal class EmailService
    {
        public async Task SendNotificationAsync(Account account)
        {
            await Task.Delay(1000);

            SendEmail(account.FirstName,
                      account.LastName,
                      account.Email,
                      account.Balance);
        }

        private void SendEmail(string firstName,
                               string lastName,
                               string email,
                               decimal balance)
            => Console.WriteLine($"Notification {firstName} {lastName} to {email} with the new balance {balance}");
    }
}