using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Entities.Generators;

namespace AdvancedGod.Entities
{
    [Couple("Girl", 0.7, "SmartGirl")]
    [Couple("PrettyGirl", 1, "PrettyGirl")]
    [Couple("SmartGirl", 0.8, "Book")]
    public class Botan : Student
    {
        public Botan(string name) : base(name) { }
        public Botan(string name, int age, string patronymic) : base(name, age, patronymic) { }

        public override string ToString()
        {
            return $"Botan, Name: {Name}, Age: {Age}, Patronymic: {Patronymic}";
        }
    }
}
