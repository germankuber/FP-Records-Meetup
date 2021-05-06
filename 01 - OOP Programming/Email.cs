namespace Records_Meetup
{
    internal class Email
    {
        private readonly string _value;

        public Email(string email) => _value = email;

        public static implicit operator string(Email email) => email._value;
    }
}