using BusinessLibrary;
using BusinessLibrary.Constants;
using BusinessLibrary.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //I would assume consoleUI layer as client
            //removed initial code for readability
            //Client should have user interface to add Person as Employee or Contractor as future requirement

            List<IPerson> PersonList = new List<IPerson>();

            #region input new person
            IPerson person = FactoryPerson.Create(PersonType.Manager);
            person.FirstName = "Bruce";
            person.LastName = "Wayne";
            PersonList.Add(person);
            person = FactoryPerson.Create(PersonType.Technician);
            person.FirstName = "James";
            person.LastName = "Bond";
            PersonList.Add(person);
            person = FactoryPerson.Create(PersonType.Worker);
            person.FirstName = "Tony";
            person.LastName = "Stark";
            PersonList.Add(person);

            //Assumption: I am leaving this decision to be made by UI using input control
            //However if not, we don't need this flag handling here.
            bool ProcessAccount = true;
            string memberType = MemberType.Employee;
            #endregion input new person

            //UI need not know how accounts are created
            //So I have separated this concern from UI


            List<IMember> employees = new List<IMember>();
            foreach (var p in PersonList)
            {
                employees.Add(FactoryMember.Create(p, ProcessAccount, memberType));
            }

            //Output is based on processed account decision, member type and designation
            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } :{emp.Type}");
            }
            Console.ReadLine();
        }
    }
    
}
