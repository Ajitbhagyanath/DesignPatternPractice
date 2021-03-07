using System;
using System.Collections.Generic;
using BusinessLibrary.Constants;

namespace BusinessLibrary.Factory
{
    //static factory will keep single instance to improve performance
    public static class FactoryPerson
    {
        private static Dictionary<string,IPerson> PersonList= null;
        //Create person by Type
        public static IPerson Create(string Type)
        {
            IPerson iperson;
            if (PersonList == null)
            {
                //if we have new role, then just add it here
                PersonList = (new Dictionary<string, IPerson>(){
                    { PersonType.Manager, new ManagerModel() },
                    { PersonType.Worker, new WorkerModel() },
                    { PersonType.Technician, new TechnicianModel() }
                });
            }
            if (PersonList.TryGetValue(Type, out iperson))
                return iperson;
            else throw new NotImplementedException("Person " + Type + " not implemented yet");
        }
    }
}
