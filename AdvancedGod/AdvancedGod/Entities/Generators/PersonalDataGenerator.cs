using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Helpers;

namespace AdvancedGod.Entities.Generators
{
    public class PersonalDataGenerator
    {
        private static readonly string[] MaleNames = { "Петр", "Александр", "Филипп", "Артем", "Роман" };
        private static readonly string[] FemaleNames = { "Анастасия", "Ксения", "Кристина", "Мария", "Александра" };
        private static readonly string MalePatronymicEnd = "ович";
        private static readonly string FemalePatronymicEnd = "овна";

        private readonly Random _random;

        public PersonalDataGenerator()
        {
            _random = new Random();
        }
        public string GenerateName(Gender sex)
        {
            Throw.IfNull(sex, nameof(sex));
            return sex == Gender.Male
                ? MaleNames[_random.Next(MaleNames.Length)]
                : FemaleNames[_random.Next(FemaleNames.Length)];
        }

        public int GenerateAge(int minAge, int maxAge)
        {
            return _random.Next(minAge, maxAge);
        }

        public string GeneratePatronymic(string fatherName, Gender sex)
        {
            Throw.IfNull(fatherName, nameof(fatherName));
            Throw.IfNull(sex, nameof(sex));
            return (sex == Gender.Male) ? fatherName + MalePatronymicEnd : fatherName + FemalePatronymicEnd;
        }

        public string GeneratePatronymic(Gender sex)
        {
            Throw.IfNull(sex, nameof(sex));
            return GeneratePatronymic(GenerateName(Gender.Male), sex);
        }
    }
}
