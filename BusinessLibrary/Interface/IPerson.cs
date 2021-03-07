using System;
namespace BusinessLibrary
{
    //SRP & DI
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Type { get; set; }
    }
}
