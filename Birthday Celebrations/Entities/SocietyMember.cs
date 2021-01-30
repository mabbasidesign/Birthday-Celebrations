using Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Entities
{
    public class SocietyMember : IIdentifiable
    {
        public SocietyMember(string id)
        {
            Id = id;
        }

        public string Id { get; }

        public bool HasInvalidIdEnding(string pattern)
        {
            return this.Id.EndsWith(pattern);
        }
    }
}
