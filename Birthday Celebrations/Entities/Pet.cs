using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Entities
{
    public class Pet: SocietyMember
    {
        public Pet(string id, string name, string birthDate)
            :base(id)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; }
        public string BirthDate { get; }
    }
}
