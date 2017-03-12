using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InGodWeTrust.Entities
{
    internal class Botan : Student
    {
        public double GPA { get; }
        public Botan(string name, int age, Gender sex, string patronymic, double gpa) : base(name, age, sex, patronymic)
        {
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"Botan, Name: {Name}, Age: {Age}, Sex: {Sex}, Patronymic: {Patronymic}, GPA: {GPA:N2}";
        }

        public override ConsoleColor GetForegroundColor()
        {
            return ConsoleColor.Green;
        }
    }
}
