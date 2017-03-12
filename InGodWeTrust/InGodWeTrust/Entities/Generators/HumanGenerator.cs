using System;
using InGodWeTrust.Helpers;

namespace InGodWeTrust.Entities.Generators
{
    internal abstract class HumanGenerator
    {
        private readonly string[] _maleNames = new string[] { "Петр", "Александр", "Филипп", "Артем", "Роман" };
        private readonly string[] _femaleNames = new string[] { "Анастасия", "Ксения", "Кристина", "Мария", "Александра" };
        protected Random Random = new Random();
        public abstract Human CreateHuman();
        public abstract Human CreateHuman(Gender sex);
        public abstract Human CreatePair(Human human);

        public virtual bool IsOnlyMaleGenerator()
        {
            return false;
        }

        protected string GenerateName(Gender sex)
        {
            Throw.IfNull(sex, nameof(sex));
            return sex == Gender.Male
                ? _maleNames[Random.Next(_maleNames.Length)]
                : _femaleNames[Random.Next(_femaleNames.Length)];
        }

        protected int GenerateAge(int minAge, int maxAge)
        {
            return Random.Next(minAge, maxAge);
        }

        protected Gender GenerateSex()
        {
            return (Gender)Random.Next(2);
        }
    }
}
