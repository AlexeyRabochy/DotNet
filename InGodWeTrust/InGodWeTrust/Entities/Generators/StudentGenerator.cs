using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InGodWeTrust.Helpers;
using InGodWeTrust.Properties;

namespace InGodWeTrust.Entities.Generators
{
    internal class StudentGenerator : HumanGenerator
    {
        protected const int MinStudentAge = 18;
        protected const int MaxStudentAge = 82;
        protected readonly string MalePatronymic = "ович";
        protected readonly string FemalePatronymic = "овна";
        public override Human CreateHuman()
        {
            return CreateHuman(GenerateSex());
        }

        public override Human CreateHuman(Gender sex)
        {
            return new Student(GenerateName(sex), GenerateAge(MinStudentAge, MaxStudentAge), sex, GeneratePatronymic(GenerateName(Gender.Male), sex));
        }

        public override Human CreatePair(Human human)
        {
            Parent parent = human as Parent;
            if (parent == null) return null;
            Gender studentSex = GenerateSex();
            string studentName = GenerateName(studentSex);
            parent.AmountOfChildren++;
            return new Student(studentName, GenerateAge(MinStudentAge, parent.Age - 18), studentSex, GeneratePatronymic(parent.Name, studentSex));
        }

        protected string GeneratePatronymic(string name, Gender sex)
        {
            Throw.IfNull(name, nameof(name));
            Throw.IfNull(sex, nameof(sex));
            return (sex == Gender.Male) ? name + MalePatronymic : name + FemalePatronymic;
        }
    }
}
