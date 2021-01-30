using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations.Entities
{
    public class Robot : SocietyMember
    {
        public Robot(string id, string model)
            :base(id)
        {
            Model = model;
        }
        public string Model { get; }
    }
}
