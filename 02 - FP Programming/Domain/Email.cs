using CSharpFunctionalExtensions;

namespace Records_Meetup.Domain
{
    public record Email
    {
        private Email(string email) => Value = email;

        public string Value { get; }

        public static Result<Email> Create(string email)
            => Result.Success(new Email(email));
    }
}