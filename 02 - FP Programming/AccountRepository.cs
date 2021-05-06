using Records_Meetup.Domain;

namespace Records_Meetup
{
    internal class AccountRepository
    {
        public Account GetAccount()
            => new(Money.Create(100).Value,
                   Email.Create("german@gmail.com").Value,
                   default,
                   default,
                   AccountStatus.Open);
    }
}