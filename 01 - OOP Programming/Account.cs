namespace Records_Meetup
{
    internal class Account
    {
        private readonly AddMoneyToAccountStrategy _addMoneyToAccountStrategy;
        private readonly AccountStatus _status;

        public Account(decimal balance,
                       Email email,
                       AccountStatus accountStatus,
                       AddMoneyToAccountStrategy addMoneyToAccountStrategy)
        {
            Balance = balance;
            Email = email;
            _status = accountStatus;
            _addMoneyToAccountStrategy = addMoneyToAccountStrategy;
        }

        public decimal Balance { get; private set; }
        public Email Email { get; private set; }
        public string FirstName { get; }
        public string LastName { get; }

        public void SubtractMoney(decimal amount)
            => _status.SubtractMoney(() => Balance -= amount);

        public void AddMoney(decimal amount)
            => _addMoneyToAccountStrategy
               .AddMoney(amount, amount => Balance += amount);

        public void ChangeEmail(Email email)
        {
            if ((string) Email == email)
                throw new EmailCantBeTheSameException();

            Email = email;
        }
    }
}