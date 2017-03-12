using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Entities.Generators;

namespace AdvancedGod.Entities
{
    [Couple("Student", 0.4, "PrettyGirl")]
    [Couple("Botan", 0.1, "PrettyGirl")]
    public sealed class PrettyGirl : Girl
    {
        public PrettyGirl(string name) : base(name) { }
        public PrettyGirl(string name, int age, string patronymic) : base(name, age, patronymic)
        {
        }

        public override string ToString()
        {
            return $"PrettyGirl, Name: {Name}, Age: {Age}, Patronymic: {Patronymic}";
        }
    }
}
