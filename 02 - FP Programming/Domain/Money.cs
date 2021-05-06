using CSharpFunctionalExtensions;

namespace Records_Meetup.Domain
{
    public record Money
    {
        private Money(decimal amount) => Amount = amount;

        public decimal Amount { get; }

        public static Result<Money> Create(decimal amount)
            => Result.Success(new Money(amount));

        public static Money operator +(Money a,
                                       Money b)
            => new(a.Amount + b.Amount);

        public static Money operator -(Money a,
                                       Money b)
            => new(a.Amount - b.Amount);
    }
}