using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLibrary.Constants;

namespace BusinessLibrary
{
    public class Accounts:IAccount
    {
        //account has responsibility to create email based on type of person
        private string domain = Domain.Alluma;
        public Accounts(string Domain)
        {
            domain = Domain;//set new domain via constructor
        }
        public Accounts(){}

        public string CreateEmailAccount(IPerson person, string memberType)
        {
            //we can further enhance here by injecting new class for eachtype of email account to remove if/else condition
            if(person.Type==PersonType.Manager && memberType==MemberType.Employee)
                return $"{ person.FirstName}.{person.LastName}@{domain}";
            if(memberType==MemberType.Contractor)
                return $"{ person.FirstName.Substring(0, 1)}.{person.LastName}{".C"}@{domain}";//adding .C at end differentiate contractor as requirement
            else return $"{ person.FirstName.Substring(0, 1) }{person.LastName}@{domain}";
        }
    }
}
