using System;
using BusinessLibrary.Constants;

namespace BusinessLibrary
{
    public class TechnicianModel:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public TechnicianModel()
        {
            Type = PersonType.Technician;
        }
    }
}
