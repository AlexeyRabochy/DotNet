using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Entities.Generators;

namespace AdvancedGod.Entities
{
    [Couple("Student", 0.2, "Girl")]
    [Couple("Botan", 0.5, "Book")]
    public sealed class SmartGirl : Girl
    {
        public SmartGirl(string name) : base(name) { }

        public SmartGirl(string name, int age, string patronymic) : base(name, age, patronymic)
        {
        }

        public override string ToString()
        {
            return $"SmartGirl, Name: {Name}, Age: {Age}, Patronymic: {Patronymic}";
        }
    }
}
