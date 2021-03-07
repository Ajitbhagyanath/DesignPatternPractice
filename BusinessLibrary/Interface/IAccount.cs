using System;
namespace BusinessLibrary
{
    //SRP & DI
    public interface IAccount
    {
        string CreateEmailAccount(IPerson person, string MemberType);
    }
}
