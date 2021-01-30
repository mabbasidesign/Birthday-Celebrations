using Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Entities
{
    public class Citizen: SocietyMember, IBirthdate
    {
        public Citizen(string id, string name, int age, string birthDate)
            :base (id)
        {
            Name = name;
            Age = age;
            BirthDate = birthDate;
        }

        public string Name { get; }
        public int Age { get; }
        public string BirthDate { get; }
    }
}
