using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InGodWeTrust.Helpers;
using InGodWeTrust.Properties;

namespace InGodWeTrust.Entities.Generators
{
    internal class ParentGenerator : HumanGenerator
    {

        protected const int MaxParentAge = 100;
        protected const int MinParentAge = 36;
        protected const int PatronymicSize = 4;
        public override Human CreateHuman()
        {
            return CreateHuman(Gender.Male);
        }

        public override Human CreateHuman(Gender sex)
        {
            return (sex == Gender.Male) ?
                new Parent(GenerateName(sex), GenerateAge(MinParentAge, MaxParentAge), sex, 0)
                :
                null;
        }

        public override Human CreatePair(Human human)
        {
            Student student = human as Student;
            if (student == null) return null;
            return new Parent(ExtractNameFromPatronymic(student.Patronymic), GenerateAge(student.Age + 18, MaxParentAge), Gender.Male, 1);
        }

        public override bool IsOnlyMaleGenerator()
        {
            return true;
        }

        protected string ExtractNameFromPatronymic(string patronymic)
        {
            Throw.IfNull(patronymic, nameof(patronymic));
            return patronymic.Substring(0, patronymic.Length - PatronymicSize);
        }
    }
}
