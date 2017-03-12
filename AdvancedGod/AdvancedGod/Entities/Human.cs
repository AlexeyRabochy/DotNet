using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Entities.Generators;
using AdvancedGod.Helpers;

namespace AdvancedGod.Entities
{
    public abstract class Human : IHasName
    {
        public string Name { get; }
        public int Age { get; }
        public Gender Sex { get; }
        public string Patronymic { get; set; }

        protected PersonalDataGenerator PersonalDataGenerator;

        protected readonly ConsoleColor DefaultForegroundConsoleColor = ConsoleColor.Gray;

        protected Human(string name, Gender sex)
        {
            Throw.IfNull(name, nameof(name));
            Throw.IfNull(sex, nameof(sex));

            PersonalDataGenerator = new PersonalDataGenerator();
            Name = name;
            Sex = sex;
        }

        public string GetChildName()
        {
            return PersonalDataGenerator.GenerateName(Gender.Female);
        }

        protected Human(string name, int age, Gender sex, string patronymic) : this(name, sex)
        {
            Throw.IfNull(patronymic, nameof(patronymic));
            Age = age;
            Patronymic = patronymic;
        }

        public void ToConsole()
        {
            Console.ForegroundColor = GetForegroundColor();
            Console.Write(this);
            Console.Write(Environment.NewLine);
            Console.ForegroundColor = DefaultForegroundConsoleColor;
        }

        public abstract ConsoleColor GetForegroundColor();
    }
}
