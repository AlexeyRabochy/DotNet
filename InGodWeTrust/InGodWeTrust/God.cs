using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InGodWeTrust.Entities;
using InGodWeTrust.Entities.Generators;

namespace InGodWeTrust
{
    internal class God : IGod
    {
        private readonly List<HumanGenerator> _generators;
        private readonly List<HumanGenerator> _canCreateFemaleGenerators;
        private List<Human> CreatedHumans { get; }
        private readonly Random _random;
        public God()
        {
            _generators = new List<HumanGenerator>
            {
                new CoolParentGenerator(),
                new ParentGenerator(),
                new BotanGenerator(),
                new StudentGenerator()
            };
            _canCreateFemaleGenerators = _generators.FindAll(g => !g.IsOnlyMaleGenerator()).ToList();
            CreatedHumans = new List<Human>();
            _random = new Random();
        }
        public Human CreateHuman()
        {
            var human = GetAnyGenerator().CreateHuman();
            CreatedHumans.Add(human);
            return human;
        }

        public Human CreateHuman(Gender sex)
        {
            return sex != Gender.Female ?
                GetAnyGenerator().CreateHuman(sex) :
                GetCanCreateFemaleGenerator().CreateHuman(sex);
        }

        public Human CreatePair(Human human)
        {
            return _generators.ConvertAll(g => g.CreatePair(human)).FirstOrDefault(h => h != null);
        }

        public List<Human> CreateHumans(int amount)
        {
            if (amount < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            var result = new List<Human> { CreateHuman(Gender.Male) };

            if (amount <= 1) return result;
            result.Add(CreateHuman(Gender.Female));
            for (var i = 2; i < amount; ++i)
            {
                result.Add(CreateHuman());
            }

            return result;
        }

        public double this[int i]
        {
            get
            {
                if (i < 0 || i >= CreatedHumans.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                var human = CreatedHumans[i] as CoolParent;
                return human?.AmountOfMoney ?? 0;
            }
        }

        public double GetTotalMoney()
        {
            double totalMoney = 0;
            for (var i = 0; i < CreatedHumans.Count; ++i)
            {
                totalMoney += this[i];
            }
            return totalMoney;
        }

        private HumanGenerator GetRandomGenerator(IReadOnlyList<HumanGenerator> generators)
        {
            return generators[_random.Next(generators.Count)];
        }
        private HumanGenerator GetAnyGenerator()
        {
            return GetRandomGenerator(_generators);
        }

        private HumanGenerator GetCanCreateFemaleGenerator()
        {
            return GetRandomGenerator(_canCreateFemaleGenerators);
        }

    }
}
