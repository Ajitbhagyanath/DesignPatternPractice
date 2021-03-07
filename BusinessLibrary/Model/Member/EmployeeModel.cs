using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLibrary.Constants;
using BusinessLibrary.Factory;

namespace BusinessLibrary
{
    
    public class EmployeeModel: IMember
    {
        public string FirstName { get;}
        public string LastName { get;}
        public string EmailAddress { get;}
        public string Type { get;}
        //inject Person to Employee instead of creating new instance

        public EmployeeModel(IPerson person, bool AccountProcessing)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Type = person.Type;
            if (AccountProcessing)//if we have requirement to decide email creation by UI
            {
                //SOC
                //separate concern of account process from EmployeeModel
                EmailAddress = FactoryAccount.Create(person,MemberType.Employee);
            }
        }

    }
}
