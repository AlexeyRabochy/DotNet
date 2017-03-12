using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InGodWeTrust.Entities.Generators
{
    internal class CoolParentGenerator : ParentGenerator
    {
        private const double MinAmountOfMoney = 1000;
        private const double MaxAmountOfMoney = 100000;
        public override Human CreateHuman(Gender sex)
        {
            return sex == Gender.Male ? new CoolParent(GenerateName(sex), GenerateAge(MinParentAge, MaxParentAge), sex, 0, GenerateAmountOfMoney()) : null;
        }

        public override Human CreatePair(Human human)
        {
            Botan botan = human as Botan;
            return botan == null ?
                null :
                new CoolParent(ExtractNameFromPatronymic(botan.Patronymic), GenerateAge(botan.Age, MaxParentAge), Gender.Male, 1, Math.Pow(10, botan.GPA));
        }

        protected double GenerateAmountOfMoney()
        {
            return MinAmountOfMoney + Random.NextDouble() * (MaxAmountOfMoney - MinAmountOfMoney);
        }
    }
}
