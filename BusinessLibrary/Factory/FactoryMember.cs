using System;
using System.Collections.Generic;
using BusinessLibrary.Constants;

namespace BusinessLibrary.Factory
{
    public static class FactoryMember
    {

        private static Dictionary<string, IMember> _IEmployee = null;
        public static IMember Create(IPerson iperson, bool ProcessAccount, string Type)
        {
            IMember member;
            //if we have new role, then just add it here
            _IEmployee = (new Dictionary<string, IMember>(){
                { MemberType.Employee, new EmployeeModel(iperson,ProcessAccount) },
                { MemberType.Contractor, new ContractorModel(iperson,ProcessAccount) }
            //we can add more type like Vendor, sub contractor and such here
            });
            if (_IEmployee.TryGetValue(Type, out member))
                return member;
            else
                throw new NotImplementedException("Member " + Type + " not implemented yet");
        }
    }
}
