﻿using System;
using BusinessLibrary.Constants;

namespace BusinessLibrary
{
    public class ManagerModel:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public ManagerModel()
        {
            Type = PersonType.Manager;
        }
    }
}
