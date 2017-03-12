using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using AdvancedGod.Helpers;

namespace AdvancedGod.Entities.Generators
{
    public class EntitiesGenerator
    {
        private const int MinStudentAge = 18;
        private const int MaxStudentAge = 30;

        private readonly Random _random;

        private delegate Human HumanGenerator();

        private readonly List<HumanGenerator> _generators;
        private readonly PersonalDataGenerator _personalDataGenerator;
        public static string MethodNameForGenerationChildName = "GetChildName";
        private const string DefaultEntityName = "Unnamed";
        private const string Package = "AdvancedGod.Entities.";

        private readonly Func<double, bool> _isLikeChecker;

        public EntitiesGenerator()
        {
            _random = new Random();
            _personalDataGenerator = new PersonalDataGenerator();
            _generators = new List<HumanGenerator>
            {
                () => new Student(_personalDataGenerator.GenerateName(Gender.Male),
                                  _personalDataGenerator.GenerateAge(MinStudentAge, MaxStudentAge),
                                  _personalDataGenerator.GeneratePatronymic(Gender.Male)),
                () => new Botan(_personalDataGenerator.GenerateName(Gender.Male),
                                _personalDataGenerator.GenerateAge(MinStudentAge, MaxStudentAge),
                                _personalDataGenerator.GeneratePatronymic(Gender.Male)),
                () => new Girl(_personalDataGenerator.GenerateName(Gender.Female),
                               _personalDataGenerator.GenerateAge(MinStudentAge, MaxStudentAge),
                               _personalDataGenerator.GeneratePatronymic(Gender.Female)),
                () => new PrettyGirl(_personalDataGenerator.GenerateName(Gender.Female),
                                     _personalDataGenerator.GenerateAge(MinStudentAge, MaxStudentAge),
                                     _personalDataGenerator.GeneratePatronymic(Gender.Female)),
                () => new SmartGirl(_personalDataGenerator.GenerateName(Gender.Female),
                                    _personalDataGenerator.GenerateAge(MinStudentAge, MaxStudentAge),
                                    _personalDataGenerator.GeneratePatronymic(Gender.Female))
            };
        }

        public EntitiesGenerator(Func<double, bool> isLikeChecker) : this()
        {
            _isLikeChecker = isLikeChecker;
        }

        public Human CreateRandomHuman() => GetRandomGenerator(_generators)();

        public IHasName Couple(Human parent, Human anotherParent)
        {
            Throw.IfNull(parent, nameof(parent));
            Throw.IfNull(parent, nameof(anotherParent));

            if (parent.Sex == anotherParent.Sex)
            {
                throw new SameSexException(parent, anotherParent);
            }

            var childType = CalculateChildType(parent, anotherParent);
            if (childType == null) return null;

            var childName = ExtractChildName(anotherParent);
            var child = (IHasName)Activator.CreateInstance(childType, childName);
            var patronymicProperty = childType.GetProperty("Patronymic");
            if (patronymicProperty == null) return child;

            var childSex = (Gender)childType.GetProperty("Sex").GetValue(child);
            patronymicProperty.SetValue(child, _personalDataGenerator.GeneratePatronymic(parent.Sex == Gender.Male ? parent.Name : anotherParent.Name, childSex));
            return child;
        }

        private string ExtractChildName(Human parent)
        {
            var methodChildName = parent.GetType()
                .GetMethods()
                .FirstOrDefault(
                    m => m.ReturnType == typeof(string) &&
                        m.GetParameters().Length == 0 &&
                        m.Name.Equals(MethodNameForGenerationChildName));
            Throw.IfNull(methodChildName, nameof(methodChildName));
            string childName;
            try
            {
                childName = (string)methodChildName?.Invoke(parent, null);
            }
            catch (TargetParameterCountException)
            {
                childName = DefaultEntityName;
            }
            return childName;
        }

        private Type CalculateChildType(Human parent, Human anotherParent)
        {
            Throw.IfNull(parent, nameof(parent));
            Throw.IfNull(anotherParent, nameof(anotherParent));

            var parentAttributes = CoupleAttributeEnumerator.CreateFor(parent);
            var anotherParentAttributes = CoupleAttributeEnumerator.CreateFor(anotherParent);

            var parentPairAttribute = parentAttributes.FirstOrDefault(attr => attr.Pair.Equals(anotherParent.GetType().Name));
            var anotherParentPairAttribute = anotherParentAttributes.FirstOrDefault(attr => attr.Pair.Equals(parent.GetType().Name));

            Throw.IfNull(parentPairAttribute, nameof(parentPairAttribute));
            Throw.IfNull(anotherParentPairAttribute, nameof(anotherParentPairAttribute));

            return IsLike(parentPairAttribute?.Probability ?? 0) && IsLike(anotherParentPairAttribute?.Probability ?? 0)
                ? Type.GetType($"{Package}{parentPairAttribute?.ChildType}")
                : null;
        }

        private bool IsLike(double probability)
        {
            if (_isLikeChecker != null) return _isLikeChecker(probability);
            Throw.IfOutOfRange(probability, nameof(probability), 0, 1);
            return _random.NextDouble() < probability;
        }
        private HumanGenerator GetRandomGenerator(IReadOnlyList<HumanGenerator> generators)
        {
            return generators[_random.Next(generators.Count)];
        }
    }
}
