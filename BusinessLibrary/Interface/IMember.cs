using System;
namespace BusinessLibrary
{
    //SRP & DI
    public interface IMember
    {
        string FirstName { get; }
        string LastName { get; }
        string EmailAddress { get; }
        string Type { get; }
    }
}
