using System;
namespace BusinessLibrary.Factory
{
    public static class FactoryAccount
    {
        public static string Create(IPerson iperson, string MemberType)
        {
            return new Accounts().CreateEmailAccount(iperson, MemberType);
        }
    }
}
