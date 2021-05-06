using CSharpFunctionalExtensions;

using Records_Meetup.Domain;

namespace Records_Meetup
{
    public static class AccountEmailLogicExtensions
    {
        public static Result<Account> ChangeEmail(this Account @this,
                                                  Email email)
            => @this.Email == email
                   ? Result.Failure<Account>("The email could not be the same")
                   : @this with
                     {
                         Email = email
                     };
    }
}