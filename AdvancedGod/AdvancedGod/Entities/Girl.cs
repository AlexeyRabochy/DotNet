using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Entities.Generators;

namespace AdvancedGod.Entities
{
    [Couple("Student", 0.7, "Girl")]
    [Couple("Botan", 0.3, "SmartGirl")]
    public class Girl : Human
    {
        public Girl(string name) : base(name, Gender.Female) { }
        public Girl(string name, int age, string patronymic) : base(name, age, Gender.Female, patronymic) { }

        public override ConsoleColor GetForegroundColor()
        {
            return ConsoleColor.Red;
        }

        public override string ToString()
        {
            return $"Girl, Name: {Name}, Age: {Age}, Patronymic: {Patronymic}";
        }
    }
}
