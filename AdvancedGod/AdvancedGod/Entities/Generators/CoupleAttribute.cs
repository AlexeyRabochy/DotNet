using System;
using AdvancedGod.Helpers;

namespace AdvancedGod.Entities.Generators
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class CoupleAttribute : Attribute
    {
        public string Pair { get; }
        public double Probability { get; }
        public string ChildType { get; }

        public CoupleAttribute(string pair, double probability, string childType)
        {
            Throw.IfNull(pair, nameof(pair));
            Throw.IfOutOfRange(probability, nameof(probability), 0, 1);
            Throw.IfNull(childType, nameof(childType));

            Pair = pair;
            Probability = probability;
            ChildType = childType;
        }
    }
}
