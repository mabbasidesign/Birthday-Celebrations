using Birthday_Celebrations.Entities;
using Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Celebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthdate> societyMembersWithBirthdates = GetSocietyMembers();
            GetMembersByBirthdate(societyMembersWithBirthdates);
        }

        // GetMembersByBirthdate
        private static void GetMembersByBirthdate(List<IBirthdate> societyMembers)
        {
            Console.WriteLine("Please Enter Year");
            var year = Console.ReadLine();
            societyMembers
                .Where(m => m.BirthDate.EndsWith(year))
                .ToList()
                .ForEach(m => Console.WriteLine(m.BirthDate));
        }

        // GetSocietyMembers
        private static List<IBirthdate> GetSocietyMembers()
        {
            var societyMembers = new List<IBirthdate>();

            while (true)
            {
                Console.WriteLine("Please enter information");
                var input = Console.ReadLine();
                if (input == "End") break;

                var inputArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var numberType = inputArgs[0].ToLower();
                inputArgs = inputArgs.Skip(1).ToArray();

                switch (numberType)
                {
                    case "citizen":
                        string name = inputArgs[0];
                        int age = int.Parse(inputArgs[1]);
                        string id = inputArgs[2];
                        string birthdate = inputArgs[3];
                        societyMembers.Add(new Citizen(id, name, age, birthdate));
                        break;
                    case "pet":
                        name = inputArgs[0];
                        birthdate = inputArgs[1];
                        societyMembers.Add(new Pet(name, birthdate));
                        break;
                }
            }
            return societyMembers;
        }

    }
}
