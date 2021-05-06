using System;
using System.Threading.Tasks;

using Records_Meetup.Domain;

namespace Records_Meetup
{
    internal class EmailService
    {
        public async Task SendNotificationAsync(Account account)
        {
            await Task.Delay(1000);

            var (balance, email, firstName, lastName, _) = account;

            SendEmail(firstName,
                      lastName,
                      email,
                      balance);
        }

        private void SendEmail(string firstName,
                               string lastName,
                               Email email,
                               Money balance)
            => Console.WriteLine($"Notification {firstName} {lastName} to {email} with the new balance {balance}");
    }
}