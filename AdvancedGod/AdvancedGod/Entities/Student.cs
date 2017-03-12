using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Entities.Generators;
using AdvancedGod.Helpers;

namespace AdvancedGod.Entities
{
    [Couple("Girl", 0.7, "Girl")]
    [Couple("PrettyGirl", 1, "PrettyGirl")]
    [Couple("SmartGirl", 0.5, "Girl")]
    public class Student : Human
    {
        public Student(string name) : base(name, Gender.Male) { }

        public Student(string name, int age, string patronymic) : base(name, age, Gender.Male, patronymic)
        {
        }

        public override string ToString()
        {
            return $"Student, Name: {Name}, Age: {Age}, Patronymic: {Patronymic}";
        }


        public override ConsoleColor GetForegroundColor()
        {
            return ConsoleColor.DarkGreen;
        }
    }
}
