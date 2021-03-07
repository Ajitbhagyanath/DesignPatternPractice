using System;
using BusinessLibrary.Constants;
using BusinessLibrary.Factory;

namespace BusinessLibrary
{
    public class ContractorModel:IMember
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string EmailAddress { get; }
        public string Type { get; }
        //inject Person to Employee instead of creating new instance because account process is not a concern of EmployeeModel
        public ContractorModel(IPerson person, bool AccountProcessing)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Type = person.Type;
            if (AccountProcessing)
            {
                EmailAddress = FactoryAccount.Create(person,MemberType.Contractor);
            }
        }
    }
}
