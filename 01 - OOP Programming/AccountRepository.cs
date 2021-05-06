namespace Records_Meetup
{
    internal class AccountRepository
    {
        public Account GetAccount() => new Account(100, new Email("german@gmail.com"), default, default);
    }
}