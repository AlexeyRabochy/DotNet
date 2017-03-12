using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InGodWeTrust.Helpers;

namespace InGodWeTrust.Entities
{
    internal class Student : Human
    {
        public string Patronymic { get; }
        public Student(string name, int age, Gender sex, string patronymic) : base(name, age, sex)
        {
            Throw.IfNull(patronymic, nameof(patronymic));
            Patronymic = patronymic;
        }

        public override string ToString()
        {
            return $"Student, Name: {Name}, Age: {Age}, Sex: {Sex}, Patronymic: {Patronymic}";
        }


        public override ConsoleColor GetForegroundColor()
        {
            return ConsoleColor.DarkGreen;
        }
    }
}
