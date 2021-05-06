namespace Records_Meetup.Domain
{
    public record Account(Money Balance,
                          Email Email,
                          string FirstName,
                          string LastName,
                          AccountStatus Status);
}